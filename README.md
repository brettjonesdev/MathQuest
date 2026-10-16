# MathQuest

Learn C# by building one game in four stages, ending in Unity. Every stage ends with a game you can play and show off. Each new stage starts by improving the code you already wrote.

The game is math-powered: answering math problems is how you open gates, land attacks, and beat the boss.

## The four stages

| Stage | Game | You'll learn |
|---|---|---|
| [1. Math Gate](stages/1-math-gate/README.md) | Answer questions to get through 10 gates before you run out of lives. | Loops, conditions, input, methods, your first unit tests |
| [2. Math Arena](stages/2-math-arena/README.md) | Turn-based fights where every attack is a math problem. | Classes, encapsulation, inheritance, automated checks |
| [3. Math Dungeon](stages/3-math-dungeon/README.md) | Explore rooms, find the key, and beat the boss. Stage 2 fights happen inside the dungeon. | Game loops, state machines, interfaces, separating logic from display |
| [4. MathQuest in Unity](stages/4-unity/README.md) | The same game with graphics. Your Stage 3 game rules run inside Unity unchanged. | DLLs, Unity basics, one game with two front ends |

Each stage has:

- **Steps**: small goals, one pull request each. "Step 1.3" means Stage 1, step 3.
- **Look up**: a video or reading for each step. Watch or read it first, then use the idea right away.
- **Done when**: a checklist. When every box is true, the stage is finished.
- **Pick two features**: a menu of extras. You choose which ones to build, and you design them.

Steps say *what* the game should do, not *how* to code it. Figuring out the how is the job.

## How you'll work

1. Follow [Getting started](docs/getting-started.md) once, to set up your tools and your fork.
2. Every change happens on a [branch](docs/glossary.md#branch) and goes in through a [pull request (PR)](docs/glossary.md#pull-request-pr). See [Workflow](docs/workflow.md).
3. Request a review from your reviewer on every PR. A PR merges only after it's approved.
4. From Step 1.6, every PR that changes game logic includes tests. See [Testing](docs/testing.md).
5. When a stage's "Done when" list is all true, [tag](docs/glossary.md#tag) the commit `stage-1-done`, and so on.
6. Share each finished stage with your friends. See [Sharing your game](docs/sharing.md).

## Rules of the road

- **Keep building the same game.** Stage 2 doesn't start a new project; it changes your Stage 1 code. Reshaping working code without breaking it is called [refactoring](docs/glossary.md#refactor), and it's the main skill here.
- **Feel the mess before you fix it.** Some steps ask you to do something the simple way first. Do it. The cleanup makes more sense once you've seen the problem.
- **Look things up.** Searching for an answer is part of programming, not cheating.
- **Ask questions in your PRs.** The PR template has a spot for them.

## Help

- [Glossary](docs/glossary.md): what a word means.
- [Learn C#](docs/learn-csharp.md): courses to work through alongside the stages.
- [Design](docs/design.md): classes, OOP, and design principles.

## Repository layout

```
README.md                  this file
docs/                      setup, workflow, testing, glossary, design, and more
stages/                    one README per stage
.github/                   pull request template (and later, your CI workflows)
MathQuest.slnx             the solution file; you create it in Getting started
src/MathQuest/             your game (split into Core and Cli in Stage 4)
tests/MathQuest.Tests/     your tests (from Step 1.6)
unity/MathQuest/           your Unity project (Stage 4)
```
