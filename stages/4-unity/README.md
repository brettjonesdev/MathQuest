# Stage 4: MathQuest in Unity

## Goal

Your dungeon game, with graphics: health bars, an answer box, monsters that flinch when you hit them, and rooms you can see. You'll build a new [front end](../../docs/glossary.md#front-end) in Unity. The rules of the game don't get rewritten. Your Stage 3 classes run inside Unity unchanged.

When you're done, one set of game rules powers two front ends: the console and Unity. Fix a bug or add a monster once, and both versions get it.

## How the pieces fit

```
src/MathQuest.Core/       the game rules: problems, characters, battles, rooms, states
src/MathQuest.Cli/        the console front end: Main, plus everything that prints or reads keys
tests/MathQuest.Tests/    tests for Core
unity/MathQuest/          the Unity project; it uses a copy of Core's DLL
```

Unity can't read `.csproj` files, but it can load a compiled [DLL](../../docs/glossary.md#dll-assembly). So Core gets built into a DLL, and a build step copies it into the Unity project.

The console project is called `Cli`, short for command-line interface. Naming it `MathQuest.Console` would hide C#'s own `Console`, and every `Console.WriteLine` would break.

## Done when

- [ ] The console game still works, and all tests pass.
- [ ] Core has no `Console` calls and nothing Unity-specific. It doesn't know which front end is using it.
- [ ] You can fight a battle in Unity, and its rules come from Core.
- [ ] You can explore the dungeon and beat the boss in Unity.
- [ ] Your friends can play it in a web browser from a link.
- [ ] You built two features from the menu below.
- [ ] The final commit is tagged `stage-4-done`.

## Steps

### 4.1 Hello, Unity

Install Unity and finish Unity Essentials. Then create a Unity project in `unity/MathQuest/` with a Unity `.gitignore`, put something of your own on screen, and get it merged.

A Unity *GameObject* is like a MakeCode sprite. You can start this step while you're still in Stage 3.

Look up:
- [Install the Unity Hub](https://docs.unity.com/en-us/hub/install-hub), then the current [Unity 6 LTS](https://unity.com/releases/unity-6)
- [Unity Essentials](https://learn.unity.com/pathway/unity-essentials)
- [The Unity Tutorial for Complete Beginners (Game Maker's Toolkit video)](https://www.youtube.com/watch?v=XtQMytORBmM)
- [Unity .gitignore](https://github.com/github/gitignore/blob/main/Unity.gitignore)

Want more? [Junior Programmer](https://learn.unity.com/pathway/junior-programmer) and [Create with Code](https://learn.unity.com/course/create-with-code) are long, but they're the official next step.

### 4.2 Split the core

Move your game rules into a [class library](../../docs/glossary.md#class-library) called `MathQuest.Core`. Target `netstandard2.1`, the version Unity can load. Rename the console project to `MathQuest.Cli`. The console game and tests work exactly as before.

You've used C# 9 since Stage 1, so the language is ready for Unity. A few newer .NET methods don't exist in `netstandard2.1`, though. The build errors will point to them.

Look up:
- [What an assembly (DLL) is](https://learn.microsoft.com/en-us/dotnet/standard/assembly/)
- [Create a class library](https://learn.microsoft.com/en-us/dotnet/core/tutorials/create-class-library?pivots=vscode)
- [.NET Standard](https://learn.microsoft.com/en-us/dotnet/standard/net-standard)

### 4.3 Core in Unity

A build step copies `MathQuest.Core.dll` into `Assets/Plugins/`. A Unity script creates a problem with your Core code and shows it on screen.

Hints:
- Add the copied DLL to `.gitignore`, and build Core before you open Unity.
- If Core uses records or `init`, `netstandard2.1` needs one small extra class first. Search the build error to find it.
- If Core uses a package like `System.Text.Json`, Unity needs that package's DLLs too.

Unity calls your script's `Update()` every frame, like MakeCode's `game.onUpdate`.

Look up:
- [Using a DLL in Unity (managed plug-ins)](https://docs.unity3d.com/Manual/plug-ins-managed.html)
- [Running a step after the build](https://learn.microsoft.com/en-us/visualstudio/msbuild/how-to-extend-the-visual-studio-build-process)
- [MonoBehaviour.Update()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html)

### 4.4 The battle scene

A screen with the hero, a monster, health bars, a problem, and a box to type the answer. The rules all come from your Core `Battle`. Unity scripts only show things and pass along what the player did.

Look up:
- [Which UI system to use](https://docs.unity3d.com/Manual/UI-system-compare.html)
- [TextMesh Pro](https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html)
- [Game Programming Patterns: Update Method](https://gameprogrammingpatterns.com/update-method.html)

### 4.5 Make it feel good

Hits should feel like hits. Add damage numbers, a flash or shake when someone gets hurt, and sound. None of this touches Core.

Look up:
- [Juice it or lose it (talk)](https://www.youtube.com/watch?v=Fy0aCDmgnxg)
- [The art of screenshake (talk)](https://www.youtube.com/watch?v=AJdEqssNZ-U)
- [Audio Source](https://docs.unity3d.com/Manual/class-AudioSource.html)

### 4.6 The dungeon

Rooms you can see and move between, built from your Core rooms. If you made data files in Stage 3, load the same files here.

Look up:
- [Prefabs](https://docs.unity3d.com/Manual/Prefabs.html)
- [Tilemaps](https://docs.unity3d.com/Manual/tilemaps/tilemaps-landing.html)
- [Game Programming Patterns: Component](https://gameprogrammingpatterns.com/component.html)

### 4.7 Ship it

Make a web build and post it, so anyone can play from a link.

Look up:
- [Unity web builds](https://docs.unity3d.com/Manual/webgl.html)
- [Uploading HTML5 games to itch.io](https://itch.io/docs/creators/html5)
- [Sharing your game](../../docs/sharing.md): the "Stay safe" section still applies.

### 4.8 Your two features

Pick two from the menu. Plan each one in an issue first, then link the issue from your PR.

## Pick two features

- **Title and game-over screens**, with buttons.
- **Animated characters.** Idle, attack, and hurt animations.
- **Music** that changes when a fight starts.
- **Particle effects** for spells, potions, or a monster's defeat.
- **Monster data in Unity.** Define monsters as Unity assets you can edit in the editor. ([ScriptableObject](https://docs.unity3d.com/Manual/class-ScriptableObject.html))
- **Both front ends.** Add something new to Core, like a new item or monster, and make it work in the console and in Unity.
- **Your own idea.** Pitch it in an issue first.
