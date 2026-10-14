# Stage 3: Math Dungeon

## Goal

A text dungeon crawler. The player moves between rooms by typing commands like `go north` and `take potion`. Somewhere in the dungeon is a key, and behind a locked door is the boss. Walking into a room with a monster starts a fight, and that fight is your Stage 2 battle.

This stage is about how games are organized. Every game, including every Unity game, runs a [game loop](../../docs/glossary.md#game-loop): read input, update the world, show the result. You're going to build that loop yourself.

## Where this is heading

In Stage 4, you'll rebuild the screen side of your game in Unity and reuse the rest. The console becomes just one [front end](../../docs/glossary.md#front-end): the part that shows things and collects input. Unity becomes a second one.

That only works if your [game logic](../../docs/glossary.md#game-logic) follows three rules:

1. **It never prints.** It returns what happened, and the front end decides how to show it.
2. **It never waits for input.** Unity calls your code many times a second, like MakeCode's `game.onUpdate`. So give your game one method per player action, like "answer this problem" or "handle this command". Each one does its work and returns. The loop that waits for the keyboard lives in the console front end.
3. **It never opens files.** Unity's web version can't. The front end reads the file and hands your game the text.

Steps 3.1 to 3.3 can be messy. Step 3.4 is where your game starts following the rules.

## Done when

- [ ] You can explore, fight, find the key, and beat the boss, or die trying.
- [ ] `Main` is one line that starts the game.
- [ ] Your game logic never calls `Console` and never opens files. Only the console front end does.
- [ ] Adding a room doesn't require changes to the combat or game loop code.
- [ ] Tests cover command parsing, moving between rooms, and whole turns of the game.
- [ ] You built two features from the menu below.
- [ ] The final commit is tagged `stage-3-done`.

## Steps

### 3.1 Rooms and commands

A `Game` class owns everything: the player, the rooms, and whether the game is still running. It loops: read a command, do it, show what happened. That's Scratch's *forever* block.

Build a few rooms connected by exits. The player can `look`, `go <direction>`, `take <item>`, and see their inventory. Unknown commands get a helpful reply, never a crash. Write tests for the command parser.

Look up:
- [Game Programming Patterns: Game Loop](https://gameprogrammingpatterns.com/game-loop.html)
- [Dictionary&lt;TKey,TValue&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)
- [Splitting strings](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/strings/common-tasks/split)
- [Building a text adventure in C# (video)](https://www.youtube.com/watch?v=qKsE-DtKRlg)

### 3.2 Game states

The game behaves differently depending on what's happening: a menu, exploring, a fight, game over. Start with the simplest approach that works. When it gets messy, give each [state](../../docs/glossary.md#state-machine) its own class. Your Stage 2 battle becomes the fight state.

Look up:
- [Game Programming Patterns: State](https://gameprogrammingpatterns.com/state.html)
- [Interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces)

### 3.3 A goal

Add the key, the locked door, and the boss. The game can now be won. Let objects answer questions about themselves: a door knows whether it's locked, and a player knows whether they have the key.

Look up:
- [Using properties](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties)
- [HashSet&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1)
- [Tell, don't ask (Martin Fowler)](https://martinfowler.com/bliki/TellDontAsk.html)

### 3.4 Logic and display (getting ready for Unity)

Make your game follow the three rules from [Where this is heading](#where-this-is-heading). Everything that prints, reads the keyboard, or opens files moves into the console front end.

Now you can test whole turns of the game without a console: call an action, then check what came back.

Look up:
- [Separation of concerns](https://en.wikipedia.org/wiki/Separation_of_concerns)
- [Cohesion and coupling: the difference](https://enterprisecraftsmanship.com/posts/cohesion-coupling-difference/)
- [Dependency inversion in C# and Unity (Code With K video)](https://www.youtube.com/watch?v=MHFPTkNbI5M)

### 3.5 Your two features

Pick two from the menu. Plan each one in an issue first, then link the issue from your PR.

## Pick two features

- **Data files.** Load rooms, items, and monsters from a JSON file instead of code. Remember rule 3: the front end reads the file. ([Reading and writing JSON](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview))
- **Save and load.** Save the game to a file and pick it up later.
- **Map.** A `map` command that draws the rooms you've visited.
- **Riddle NPCs.** Characters who give items in exchange for solving a puzzle.
- **Math items.** A charm that removes a wrong answer, or a scroll that makes the next problem easier.
- **Random dungeons.** Build a different dungeon every time you play.
- **Your own idea.** Pitch it in an issue first.

## Before you move on

- Could you swap the console for a different screen without touching your game logic? What would still get in the way?
- Start the Unity tutorials in [Step 4.1](../4-unity/README.md#41-hello-unity) now, alongside this stage.

Check what you learned: [Concepts, Stage 3](../../docs/concepts.md#stage-3-math-dungeon).
