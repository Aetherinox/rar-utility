using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.ComponentModel;

[AttributeUsage(AttributeTargets.Assembly)]
internal class BuildDateAttribute : Attribute
{
    public BuildDateAttribute(string value)
    {
        DateTime = DateTime.ParseExact(
            value,
            "yyyyMMddHHmmss",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None);
    }

    public DateTime DateTime { get; }
}

namespace WinrarKG
{

    class Helpers
    {

        /*
            Find App

            find WinRAR application to make it easier on the user when saving
            the generated key file.

            First we check Windows Environment Variables;
            then check where we "think" it may be.
        */

        public string FindApp(String filename)
        {

            String default_path64 = @"C:\\Program Files\\WinRAR\\";
            String default_path86 = @"C:\\Program Files (x86)\\WinRAR\\";

            /*
                Windows env variables
            */

            String path = Environment.GetEnvironmentVariable("path");
            String[] folders = path.Split(';');
            foreach (String folder in folders)
            {
                if (File.Exists(folder + filename))
                {
                    return folder;
                }
                else if (File.Exists(folder + "\\" + filename))
                {
                    return folder + "\\";
                }
            }

            /*
                Program files 64
            */

            if (Directory.Exists(default_path64))
            {
                if (File.Exists(default_path64 + filename))
                {
                    return default_path64;
                }
            }

            /*
                Program files 86
            */

            if (Directory.Exists(default_path86))
            {
                if (File.Exists(default_path86 + filename))
                {
                    return default_path86;
                }
            }

            /*
                rar last resort
                Utilize powershell get-command to see if WinRAR is installed
            */

            string ps_query         = "(get-command winrar.exe).Path";
            string ps_result        = PowershellQ(ps_query);
            ps_result               = ps_result.Replace(@"\", @"\\").Replace(@"""", @"\""");
            string rar_where        = null;

            using (var reader = new StringReader(ps_result))
            {
                rar_where = @reader.ReadLine();
            }

            if (File.Exists(rar_where))
            {
                return Path.GetDirectoryName(rar_where);
            }

            return String.Empty;
        }

        /*
            Linker Timestamp UTC

            used to help obtain the build date of the software.
            This method doesn't work if you compile your application with /deterministic flag 
        */

        public static DateTime GetLinkerTimestampUtc(Assembly assembly)
        {
            var location = assembly.Location;
            return GetLinkerTimestampUtc(location);
        }

        /*
            Get Linker Timestamp UTC

            used to help obtain the build date of the software.
            This method doesn't work if you compile your application with /deterministic flag 
        */

        public static DateTime GetLinkerTimestampUtc(string filePath)
        {
            const int peHeaderOffset = 60;
            const int linkerTimestampOffset = 8;
            var bytes = new byte[2048];

            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                file.Read(bytes, 0, bytes.Length);
            }

            var headerPos = BitConverter.ToInt32(bytes, peHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(bytes, headerPos + linkerTimestampOffset);
            var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return dt.AddSeconds(secondsSince1970);
        }

        /*
            Get Build Date/Time

            An alternative method to obtaining the build date of the software. 
            The functions above should not be used incombination with the one below.

            @usage  : DateTime build_date = Helpers.GetBuildDate(Assembly.GetExecutingAssembly());
        */

        public static DateTime GetBuildDate(Assembly assembly)
        {
            const string BuildVersionMetadataPrefix = "+build";

            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (attribute?.InformationalVersion != null)
            {
                var value = attribute.InformationalVersion;
                var index = value.IndexOf(BuildVersionMetadataPrefix);
                if (index > 0)
                {
                    value = value.Substring(index + BuildVersionMetadataPrefix.Length);
                    if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
                    {
                        return result;
                    }
                }
            }

            return default;
        }

        public static DateTime GetBuild(Assembly assembly)
        {
            var attribute = assembly.GetCustomAttribute<BuildDateAttribute>();
            return attribute?.DateTime ?? default(DateTime);
        }

        public string PowershellQ(string query)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                // Source functions
                ps.AddScript(query);

                // invoke execution on pipeline (collect output)
                Collection<PSObject> PSOutput = ps.Invoke();

                // new string
                StringBuilder sb = new StringBuilder();

                // loop through each output object item
                foreach (PSObject outputItem in PSOutput)
                {
                    // if null object dumped to pipeline during script execution; then a null object may be present here
                    if (outputItem != null)
                    {
                        Console.WriteLine($"Output line: [{outputItem}]");
                        sb.AppendLine(outputItem.ToString());
                    }
                }

                // error stream
                if (ps.Streams.Error.Count > 0)
                {
                    // Error collection
                }

                return sb.ToString();
            }
        }
    }
}
