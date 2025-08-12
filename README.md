![Luny Logo](~Media/LunyLogo.png)

# [Lua in Unity for everything!](https://lunyscript.com)

**Are you iterating, or still compiling?**

Luny enables Editor, Runtime and Mod scripting with Lua. 

Example Editor utility script that opens new Scene assets right away:
```
local context = ...

context.OnPostprocessAllAssets = function(importedPaths)
    if #importedPaths == 1 and importedPaths[1]:endsWith(".unity") then
        EditorSceneManager.OpenScene(importedPaths[1]);
    end
end
```

## Features

- Full Unity API available with more to come ...
- Instant script reload: no compiling, no domain reload. 
- Sandboxing prevents runtime scripts from accessing the file system.
- Uses [LuaCSharp](https://github.com/nuskey8/Lua-CSharp), a high performance C# implementation of Lua
- Compatible with all Editor and Runtime platforms.
- Compatible with _Auto-Refresh_ and _Enter PlayMode_ options.

Visit [LunyScript.com](https://lunyscript.com) for more info.

# Requirements
### Unity 6000.0.35f1 or newer

# Installation

* Open **Window => Package Management => Package Manager** in Unity Editor
* Click top-left **&#10133;** button and choose: **Install package from git URL...**
* Enter: `https://github.com/CodeSmile-0000011110110111/de.codesmile.luny.git`

# Manual

Work in progress ...

For now it's all in this Google Document:
https://docs.google.com/document/d/1hHC7lTNleZO1LdInfF2t4gKYvXcB3-7nUFL5vbHpQVI/edit?usp=sharing

I also maintain a DevLog for the curious:
https://docs.google.com/document/d/1jADnS6rsSx28-uWu8C4ubvCQD08zRO8sNLwtv8uASNU/edit?usp=sharing

# Patreon

Stay informed and support the project: https://www.patreon.com/CodeSmile

I highly appreciate any and all subscriptions. It helps to keep the project going, it's a full-time investment and the name 'Luny' isn't far off because it's somewhat crazy to pour this much time and effort (not to mention my savings) into enabling Lua for Unity developers.
