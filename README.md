# WinRAR License Generator
Allows you to generate and activate a copy of [WinRAR v6.22+](https://win-rar.com).

# About
Developer holds no responsibility with what people decide to do with this app. It was developed strictly for demonstration purposes only.
Developed under the following conditions:
- Visual Studio 2022 (17.6.4)
- v4.8.0 .NET Framework

# Usage
Download the project repo and open with Visual Studio.
If building your own version or want to move my binaries, you must ensure the following three files are in the same directory with each other:
- /bin/`WinrarKG.exe`
- /bin/`WinrarKG.exe.config`
- /bin/`library/winrarkg_cli.exe`

The already-built executable binaries are located in the`/bin/` folder. Launch them to use the software.

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