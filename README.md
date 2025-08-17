[![Luny Logo](~Media/LunyLogo.png)](https://lunyscript.com)

# Unity Realtime Scripting

#### Program anything in Lua - Editor and Runtime scripting for all platforms

## Are you iterating or still compiling?

Luny hot reloads a script the moment it changed on disk. You remain focused in the code editor, merely glancing at the immediate effect of your changes in the Editor or build window.

Simple runtime script example for context:
```
local context = ...

context.Awake = function()
    -- create an instance from a Inspector assigned prefab
    context.go = Object.Instantiate(context.InspectorPrefab)
end

context.Update = function()
    -- make it move slowly to the right
    local pos = context.go.transform.position
    pos = pos + Vector3(0.02, 0, 0)
    context.go.transform.position = pos
end
```

For hot reload you only need to consider some housekeeping. Like not instantiating 'go' anew every time. Instantiate only when it does not exist, or destroy it when the script 'unloads':
```
context.OnScriptUnload = function()
    Object.Destroy(context.go)
end
```
## Luny 0.5 Features

- Full Unity API available with more to come ...
- Instant script reload: no compiling, no domain reload.
- Bind custom objects with value get/set either automatic via reflection or by writing binding methods.
- Inspector editing of 'context' values
- Sandboxing prevents runtime scripts from accessing potentially destructive APIs.
- Lua function calls are fully async-awaitable
- Uses [LuaCSharp](https://github.com/nuskey8/Lua-CSharp), a high performance C# implementation of Lua
- Compatible with all Editor and Runtime platforms.
- Compatible with _Auto-Refresh_ and _Enter PlayMode_ options.
- Supported and maintained, built with passion and dedication

Visit [LunyScript.com](https://lunyscript.com) for more info.

### Limitations

Version 0.5 (alpha) has some ways to go. I will focus on solidifying Editor scripting first, then turn to Runtime scripting which is functional but lacks critical features.

Major areas of work:

- Documentation
- More editor functionality
- Essential 'System' namespace types (eg File/Path, String, Collections)
- Essential runtime features (eg execute scripts when instantiating, coroutines, ..)
- Improve Lua interoperation with C#/Inspector and custom object binding
- Improve bindings generator (generic T, ref/out, tuples, operators, more collections)
- Expose more Unity assemblies/packages, eg Input, Cinemachine, Physics, etc

Please don't hesitate to send requests and to report any issues!

## Requirements: Unity 6000.0.35f1 or newer

Since Luny is a new project and I'm just a crazy solo developer, I do not wish to spend time on supporting already out-of-support Unity versions.

I promise to maintain support for 6.0 LTS until at least October 2027: the end of life of Unity 6.0 LTS for Enterprise/Industry customers.

## MIT License

[![License: MIT](https://cdn.prod.website-files.com/5e0f1144930a8bc8aace526c/65dd9eb5aaca434fac4f1c34_License-MIT-blue.svg)](/LICENSE)
.. as I wish to keep it free and open!

If you share the same sentiment, please [subscribe to my Patreon](https://www.patreon.com/CodeSmile) as I continue to pour my worklife-balance into improving Luny!

## Installing Luny

In the Unity Editor:

* Open **Window => Package Management => Package Manager**
* Click top-left [**&#10133;**] button and choose **Install package from git URL...**
* Enter: `https://github.com/CodeSmile-0000011110110111/de.codesmile.luny.git`

## A word from the author

<picture><source srcset="~Media/steffen.jpg" sizes="(max-width: 100px) 100px" type="image/jpeg"/></picture>

![Steffen aka CodeSmile](~Media/steffen.jpg)

Luny was a crazy amount of work (~9 months) to create just the infrastructure for Unity to support Lua as a natural alternative to C#. I wish to keep working on Luny since it's downright awesome to iterate without delays, to stay in the flow while coding. To that end, I want you to .. 

.. use Luny first of all! Provide feedback, make requests, report issues: [all right here](https://github.com/CodeSmile-0000011110110111/de.codesmile.luny/issues) or via social channels: [Website](https://lunyscript.com/), [Discussions](https://discussions.unity.com/t/i-maed-my-first-luny-script/1597492/), [Discord](https://discord.gg/EkwNb4rB7W), [X](https://x.com/sitterheim), [Email](mailto:steffen@steffenitterheim.de) <sup>(for personal inquiries)</sup>. And [join my Patreon](www.patreon.com/c/CodeSmile) to stay in the loop.

Let me know what your use-cases are, and how Luny helps, or could be helpful if only it did that specific thing.

Then just follow the most important Luny Club rules: 

1. DO talk about Luny!
2. DO talk about Luny!

Spreading the word is most helpful! :)

# Getting Started with Luny

For this walkthrough I encourage you to have your editor window sized so that you can at least see the Unity Editor's 'Console' window somewhere on the side. 

Type often, save often, watch the changes happen in the Console by 'printing' a lot of things. Use the same approach as you explore other uses later. To "log" strings use:
```
local hello = "World!"

print(hello)    -- Debug.Log
log(hello)      -- same as 'print'
warn(hello)     -- Debug.LogWarning
error(hello)    -- Debug.LogError
```

## Example Editor Script
How about: A Unity Editor utility script that automatically opens new Scene assets?

Exactly the kind of script we often wish for but rarely write because of the friction imposed upon us. Particularly when we need to figure many things out one by one:

- What class is this callback in again?
- Oh god .. which of these callbacks to use?
- Are these static events I can subscribe to or do I have to subclass?
- Could these parameters be null or empty?
- What exactly are these `string[]` parameters anyway?
- If they are paths, are these absolute or relative?
- What's the file extension for scenes?
- How to open a scene, but in the editor?

So that's several minutes wasted on just compiling the C# code multiple times in quick succession. You got actual work to do, remember?

Here's the crazy **Luny** solution, I'll explain it in detail below "after the break":
```
local context = ...

context.OnPostprocessAllAssets = function(imported)
    if #imported == 1 and imported[1]:EndsWith(".unity") then
        EditorSceneManager.OpenScene(imported[1]);
    end
end
```

## Your First Editor Script

Create a new Editor Lua script in a `/Editor` folder:

![Create Editor Lua Script](~Media/create-editor-lua-script.png)

Capture the script's context table in a local variable, where `...` is Lua's _varargs_ operator:
```
local context = ...
```

Implement event functions in the context table, using the same name as the C# callback:
```
context.OnPostprocessAllAssets = function(imported, deleted, moved, movedFrom)
    print("Asset Postprocessing, imported count: " .. #imported)
end
```

You can omit unused, trailing arguments for clarity and brevity:
```
context.OnPostprocessAllAssets = function(imported)
end
```

Lua understands english, naturally uses `1` as a list's first element, and counts elements with the `#` prefix:
```
if #imported == 1 and imported[1]:EndsWith(".unity") then
end
```

Since `imported[1]` is a string, we can call a function that operates 'on' a string by using the `:` (colon) operator:
```
imported[1]:EndsWith(".unity")
```

The `:` operator is syntactic sugar for the more verbose alternative, resembling a C# static method call:
```
string.EndsWith(imported[1], ".unity")
```

Both `UnityEditor` and `UnityEngine` APIs are at your disposal, these are merely tip-of-the-iceberg examples:
```
-- static method call:
EditorSceneManager.OpenScene("Main Scene.unity");

-- some vector math:
local input = Vector3.new(10, 20, 30)
local velocity = input.normalized * Time.deltaTime
```

Saving reloads the script without having to change window focus. Anything in the context survives reload:
```
local context = ...
context.Reloads = context.Reloads and context.Reloads + 1 or 1
print("Reloaded script " .. context.Reloads .. " times")
```

The `..` operator concatenates strings. You may be more curious about the `and or` pattern though. It's what we call a ternary expression:
```
(condition) ? (consequent) : (alternative)      // C# ternary expression
(condition) and (consequent) or (alternative)   -- Lua ternary equivalent
```

The ternary expression is used because all variables default to the value `nil`. Lua's keyword for `null` actually means: "value not assigned". The first time this script runs, we will have to assign a `number` value since we cannot increment a `nil` value. 

You can also write this logic more traditionally:
```
if not context.Reloads then 
    context.Reloads = 0
end

context.Reloads = context.Reloads + 1 
```

If you're very accustomed to C languages, you may prefer to use the equality operator. Its inequality counterpart is the `~=` operator, which - I promise - you'll get used to:
```
if context.Reloads == nil then
    context.Reloads = 0
end
```
A `nil` value evaluates to false in a boolean condition.

Like in C#, some of us prefer longer over more lines. At least for very short, simple statements it can be a useful formatting alternative:
```
if context.Reloads == nil then context.Reloads = 0 end
```
I could show you how you can make multiple statements on the same line, but I do not wish to endorse this style. 

If you ever find need for structuring things, use a table. The table is Lua's sole collection type, mimicking both a list and a key-value store. How you format the braces is entirely up to you: 

```
local myTable = {
    tableInsideTheTable = { "This", "Is, "A", "List", "Of", "Strings", "!", },
    TheNumberWeShallCallPI = 3.1415,
    doesAnyOfThisMakeSense = false,
    aDeeperTable =
    {
        name = "Knee-deep",
        evenDeeperTable = { name = "in the Tables" }
    }
}
```

A table is highly suitable for hierarchical structures, including storing game and configuration data. But unlike structured text files (I won't name names) it's actually executable code **and** it can have comments **and** won't whine about your 'unexpected' trailing commas. 

Some example use-cases for embedded functionality right in the game and config data:

- generate or initialize content
- choose which content to load
- validate, optimize, analyze, format, or convert the content
- send a webrequest before returning

What you can't do: mining bitcoins on user's devices. Generally speaking.

Most IDEs and text editors support syntax highlighting, error checking, and auto-completion suggestions for Lua, either built-in or via a plugin. Check your editor's plugin manager.

# Manual

Work in progress ...

For now it's all [in this Google Document](https://docs.google.com/document/d/1hHC7lTNleZO1LdInfF2t4gKYvXcB3-7nUFL5vbHpQVI/edit?usp=sharing).

I also [maintain a DevLog](https://docs.google.com/document/d/1jADnS6rsSx28-uWu8C4ubvCQD08zRO8sNLwtv8uASNU/edit?usp=sharing) for the curious, but more importantly for myself.

# Community-Sponsored Project

I aim to create something unique and special that satisfies game developers' dirty desires. I think I found it! :)

If you agree, [join my Patreon](https://www.patreon.com/CodeSmile) to stay informed. Please consider supporting the project with a subscription!

I am confident that Luny can be fully community sponsored by 2028. It would only take 10 new subscribers at $10 per month on average over the next 3 years to make that happen. I really wish to keep the project free for all.
