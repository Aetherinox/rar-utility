# WinRAR License Generator
Allows you to generate and activate a copy of [WinRAR v6.22+](https://win-rar.com).

# About
Developer holds no responsibility with what people decide to do with this app. It was developed strictly for demonstration purposes only.
Developed under the following conditions:
- Visual Studio 2022 (17.6.4)
- v4.8.0 .NET Framework
- C# language

# Usage
If you wish to simply use the keygen, head over to the [Releases](https://github.com/Aetherinox/WinrarKeygen/releases) section and download the latest binary as a `zip` or `rar`. The binary release should only contain two files:
- /bin/`WinrarKG.exe`
- /bin/`WinrarKG.exe.config`

Make sure these two files are both in the same folder.

# Build
Download the source files and launch the `.csproj` project file in Visual Studio.

If you decide to modify or re-build my code, you are to not re-distribute. Unlike a lot of keygens, my files are free of malware, and I do not want people taking advantage of a quick solution that you can dump your non-sense malware into and re-distribute.

If you're looking to do a quick credits swap and re-distribute just so you can make a name for yourself; I'd highly recommend you actually learn C# and make something yourself.

# Signed Releases
As of `v1.0.0.0` and onwards, binaries are GPG signed with the key `90B445D4C960D301`. You can find the key available on most keyservers:
- [pgp.mit.edu](https://pgp.mit.edu/)
- [keyserver.ubuntu.com](keyserver.ubuntu.com)
- [keys.openpgp.org](https://keys.openpgp.org)

Binaries are also signed with a certificate which has the serial number `10d43e641e59fa884c773add600159dd`. If you downloaded this elsewhere on the internet and the binary is not signed with that certificate serial number; **IT IS NOT MINE**. You should delete it.

# App.config
This file holds default values that the app uses when launching. You shouldn't need to modify these, but they're provided just in case:
```xml
  <appSettings>
    <add key="username_default" value="Aetherinox"/>
    <add key="company_default" value="Unlimited Business License"/>
    <add key="libs_default" value="library"/>
    <add key="github_url" value="https://github.com/Aetherinox/WinrarKeygen"/>
    <add key="ClientSettingsProvider.ServiceUri" value=""/>
  </appSettings>
```
Don't modify these unless you know what you're doing, improperly configured, the Activation and Response will not generate into a valid serial key.

# Previews
![Main screen](https://i.imgur.com/3hrolF6.png)
![Save key file](https://i.imgur.com/Z96Xc55.png)
![Save success](https://i.imgur.com/Urt186k.png)
![License activated](https://i.imgur.com/oUKAXf9.png)
![About panel](https://i.imgur.com/pr3SC89.png)