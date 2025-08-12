![Luny Logo](~Media/LunyLogo.png)

# **Are you iterating, or still compiling?**

[Luny](https://lunyscript.com) enables Editor, Runtime and Mod scripting with Lua in Unity. 

Example utility editor script, opens created Scene assets:
```
local context = ...

context.OnPostprocessAllAssets = function(imported)
    if #imported == 1 and imported[1]:endsWith(".unity") then
        EditorSceneManager.OpenScene(imported[1]);
    end
end
```

Just create a new Lua script asset in a `/Editor` folder:

![Create Editor Lua Script](~Media/create-editor-lua-script.png)

Capture the script's context table in a local variable:
```
local context = ...
```

Simply implement the event function by name:
```
context.OnPostprocessAllAssets = function(imported, deleted, moved, movedFrom)
end
```

You can omit unused function arguments:
```
context.OnPostprocessAllAssets = function(imported)
end
```

The UnityEditor and UnityEngine APIs are at your disposal.
```
EditorSceneManager.OpenScene("My First Scene");
```

Changes take effect instantly. Context survives reload:
```
local context = ...
context.Reloads = context.Reloads and 1 or context.Reloads + 1
print("Reloaded script " .. context.Reloads .. " times")
```

No compiling, no domain reload. Iterate, iterate, iterate.


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

I highly appreciate any and all subscriptions. It helps to keep the project going, it's a full-time investment and the name 'Luny' is a good fit alos because it's crazy to pour this much time and effort (not to mention my savings) into enabling Lua for Unity developers.
