# ScriptHookTest for GTA V

This is a very simple mod that can act as a basis for testing things with script hooks.

It requires that you install ScriptHookV.NET (follow instructions):
https://www.gta5-mods.com/tools/scripthookv-net

## Building

Open up the project in Visual Studio 2017 and Build.

You might have to modify `Properties -> Build Events -> Post-build event command line`,
since it is currently setup to copy the mod to the `scripts` folder after it is built.

This is currently `C:\Program Files (x86)\Steam\SteamApps\common\Grand Theft Auto V\scripts`,
and would have to be modified to suit your machine in case you want the automatic copying to work.

## License

ChaosMod is distributed under the terms of both the MIT license and the Apache License (Version 2.0).

See LICENSE-APACHE and LICENSE-MIT for details.
