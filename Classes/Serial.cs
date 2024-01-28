/*
    @app        : WinRAR Keygen
    @repo       : https://github.com/Aetherinox/WinrarKeygen
    @author     : Aetherinox
*/

#region "Using"

using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Res = WinrarKG.Properties.Resources;
using Cfg = WinrarKG.Properties.Settings;

#endregion

namespace WinrarKG
{
    class Serial
    {

        #region "Define: Fileinfo"

            /*
                Define > File Name
                    utilized with logging
            */

            readonly static string log_file = "Serial.cs";

        #endregion

        #region "Define: Classes"

            private AppInfo AppInfo     = new AppInfo( );
            private Helpers Helpers     = new Helpers( );

        #endregion

        #region "Define: Base Paths"

            /*
                Could not find Winrar.exe

                patch_launch_fullpath       : Full path to exe
                patch_launch_dir            : Directory only
                patch_launch_exe            : Patcher exe filename only
            */

            static private string patch_launch_fullpath     = Process.GetCurrentProcess( ).MainModule.FileName;
            static private string patch_launch_dir          = Path.GetDirectoryName( patch_launch_fullpath );
            static private string patch_launch_exe          = Path.GetFileName( patch_launch_fullpath );
            static private string app_target_exe            = Cfg.Default.app_winrar_exe;

        #endregion

        #region "Define: Base Paths > CLI"

            /*
                variables > current keygen path / folder
            */

            static private string app_cli_exe               = Cfg.Default.app_def_exe;                          // winrarkg_cli.exe
            static private string app_cli_path              = Path.Combine( patch_launch_dir, app_cli_exe );    // x:\path\to\winrarkg_cli.exe

        #endregion

        #region "Method: Generate"

            /*
                 To generate WinRAR license key, we rely on our command-line tool.
                 Utilize MS Powershell to run the generation command and then feed results
                 back into the keygen.

                 @param : str query
                          command to execute in winrar cli
             */

            public string Generate( string query )
            {

                // Export patched resource file
                File.WriteAllBytes( app_cli_exe, WinrarKG.Properties.Resources.winrarkg_cli );

                if ( !File.Exists( app_cli_exe ) )
                {
                    MessageBox.Show
                    (
                        new Form( ) { TopMost = true, TopLevel = true, StartPosition = FormStartPosition.CenterScreen },
                        string.Format( Res.msgbox_err_libmissing_msg, Environment.NewLine, app_cli_exe, Environment.NewLine, Environment.NewLine ),
                        Res.msgbox_err_libmissing_title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return "Failed to generate license";
                }

                string[] ps_query   = { query };
                string results      = Helpers.PowershellQ( ps_query );

                if ( !String.IsNullOrEmpty( results ) )
                {
                    // delete resource
                    if (File.Exists( app_cli_path ) )
                        File.Delete( app_cli_path );

                    return results;
                }

                return "Failed to generate license";

            }

        #endregion

    }
}
