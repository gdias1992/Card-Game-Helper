# Card Game Helper
https://www.unknowncheats.me/forum/other-games/492843-yu-gi-oh-master-duel-helper.html

## Features
- Speedhack
- Enemy Surrender (solo play only)

## Requirements
- [MelonLoader](https://github.com/LavaGang/MelonLoader)
- Visual Studio 2019/2022
- .NET Framework 4.7.2

## How to build
After applying [MelonLoaderInstaller.exe](https://github.com/LavaGang/MelonLoader/releases) to your game executable and run the game for the first time, it will extract all the Visual Studio required dependencies. 

Then open the GitHub project and add the following references to your project:

- STEAM_FOLDER/.../GAME_FOLDER/MelonLoader/MelonLoader.dll
- STEAM_FOLDER/.../GAME_FOLDER/MelonLoader/Managed/UnityEngine*.dll (all dll's with UnityEngine in the name, except by UnityEngine.InputModule.dll)
- STEAM_FOLDER/.../GAME_FOLDER/MelonLoader/Managed/Assembly-CSharp.dll
- STEAM_FOLDER/.../GAME_FOLDER/MelonLoader/Managed/Il2Cppmscorlib.dll
- STEAM_FOLDER/.../GAME_FOLDER/MelonLoader/Managed/UnhollowerBaseLib.dll
