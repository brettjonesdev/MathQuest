# Stage 2: Math Arena

## Goal

Your Stage 1 game becomes a turn-based battle. A hero fights 3 monsters in a row. On each turn the player picks an action:

- **Attack:** answer a problem to deal damage.
- **Heavy attack:** a harder problem that deals more damage. A wrong answer wastes the turn.
- **Heal:** use a potion. There aren't many.

Monsters hit back. Beat all 3 to win.

Change the Stage 1 code instead of starting over. Your problem-making code should end up inside the battle, moved and improved, not rewritten.

## Done when

- [ ] You can win or lose a full run of 3 fights.
- [ ] `Main` holds no game state: no `heroHp` or `monsterHp` variables.
- [ ] Nothing outside a character can set its health to a broken value, like `-500`.
- [ ] Adding a new monster type takes one new class and no changes to the battle code.
- [ ] Tests and a style check run automatically on every PR, and they pass.
- [ ] You built two features from the menu below.
- [ ] Pushing the `stage-2-done` tag publishes a [release](../../docs/glossary.md#release) your friends can download.

## Steps

### 2.1 One fight, the simple way

One hero against one monster, with all the health and damage numbers as variables in `Main`. Get it working. Then think about what it would take to add a second monster. Don't fix it yet.

Look up:
- [while and do loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements) · [break and continue](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements)

### 2.2 Characters

Make a `Character` [class](../../docs/glossary.md#class) that holds its own name, health, and attack. It knows how to take damage and whether it's still alive. Write tests that prove health never drops below 0 or goes above the maximum.

A class is like a Scratch sprite: its own variables and its own scripts. Each `new Character(...)` is like a clone.

Look up:
- [Classes (Brackeys video)](https://www.youtube.com/watch?v=WKjfCHxeEz4)
- [Encapsulation explained (CodeBeauty video)](https://www.youtube.com/watch?v=vQ6k1U6nADY)
- [Properties](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- [Math.Clamp](https://learn.microsoft.com/en-us/dotnet/api/system.math.clamp)

### 2.3 Problems become objects

Turn your Stage 1 problem code into a class, or a few. The game plays exactly the same, and your tests prove it.

If a test needs `Random` to pick the same numbers every time, find a way to hand the class its `Random`.

Look up:
- [Random and seeds](https://learn.microsoft.com/en-us/dotnet/api/system.random)
- [Records](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records)
- [Value and reference types (Tarodev video)](https://www.youtube.com/watch?v=ldq7ZByB4p8)

### 2.4 The battle

Move the fight into a class. Fight 3 monsters in a row, using a list. `Main` only starts things.

Each class should have one clear job ([high cohesion](../../docs/glossary.md#cohesion)) and know as little as possible about the others ([low coupling](../../docs/glossary.md#coupling)). Watch the video first, then check your classes against it.

Look up:
- [Coupling and cohesion explained (Gui Ferreira video)](https://www.youtube.com/watch?v=7pdrZDqEPIw)
- [List&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)
- [Objects as arguments (Bro Code video)](https://www.youtube.com/watch?v=OuR9e9R3yWs)

### 2.5 Hero and monsters

Create different kinds of characters that share what's common and differ where they need to. A troll and a goblin shouldn't need copies of the same code.

Look up:
- [Inheritance tutorial](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/inheritance)
- [Polymorphism: virtual and override](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism)
- [Abstract classes (Bro Code video)](https://www.youtube.com/watch?v=06BrbJm7Sho)

### 2.6 Robots check your PRs

Set up a GitHub Actions [workflow](../../docs/glossary.md#workflow-github-actions) that runs `dotnet test` on every pull request. A red ❌ on your PR means something broke. This is called [continuous integration (CI)](../../docs/glossary.md#ci-continuous-integration).

Hints:
- Use .NET version `10.0.x` in the workflow. Older versions can't read your `.slnx` file.
- If nothing runs, check that Actions are turned on for your fork. See [Getting started](../../docs/getting-started.md#2-fork-and-clone).

Look up:
- [GitHub Actions quickstart](https://docs.github.com/en/actions/get-started/quickstart)
- [Building and testing .NET](https://docs.github.com/en/actions/tutorials/build-and-test-code/net)

### 2.7 Robots check your style

Your code follows one consistent style, and a PR with messy formatting fails CI. See [Code style](../../docs/code-style.md).

Look up:
- [dotnet format](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-format)
- [Code style options in .editorconfig](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/code-style-rule-options)

### 2.8 Your two features

Pick two from the menu. Plan each one in an issue first, then link the issue from your PR.

### 2.9 Robots ship your game

Your finished stage, shipped. Pushing a `stage-N-done` tag builds your game for Windows, Mac, and Linux, then publishes a GitHub Release with all three files. Do one release by hand first, following [Sharing your game](../../docs/sharing.md), so you know what you're automating.

Hints:
- Your workflow needs `permissions: contents: write`, or GitHub won't let it create the release.
- Build the Mac version on a Mac [runner](../../docs/glossary.md#runner). Mac builds made on Linux may refuse to run.

Look up:
- [Running a workflow when a tag is pushed](https://docs.github.com/en/actions/reference/workflows-and-actions/workflow-syntax)
- [Matrix builds: one job per platform](https://docs.github.com/en/actions/how-tos/write-workflows/choose-what-workflows-do/run-job-variations)
- [gh release create](https://cli.github.com/manual/gh_release_create)

## Pick two features

- **Weaknesses.** Some monsters only take damage from certain operations. A Multiplication Troll ignores addition.
- **Critical hits.** Fast answers, or long streaks, deal double damage.
- **Status effects.** Poison that hurts every turn, or a stun that skips a turn.
- **XP and ranks.** Earn XP from fights. Higher ranks raise health and damage.
- **Shop.** Spend gold between fights on potions or upgrades.
- **Your own idea.** Pitch it in an issue first.

## Before you move on

- If you added a map with rooms, what would have to change in your code?
- Which classes would you be scared to touch? Why?

Check what you learned: [Concepts, Stage 2](../../docs/concepts.md#stage-2-math-arena).
