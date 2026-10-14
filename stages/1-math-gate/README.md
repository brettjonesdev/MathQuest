# Stage 1: Math Gate

## Goal

A console game. The player faces 10 gates, and each gate asks a math question. A right answer opens the gate. A wrong answer costs a life. Get through all 10 to win; lose 3 lives and it's game over.

## Done when

- [ ] A friend can play from start to finish without your help.
- [ ] Typing garbage at any prompt never crashes the game.
- [ ] `Main` reads like an outline: a short list of steps, with the details in other [methods](../../docs/glossary.md#method).
- [ ] `dotnet test` passes, and tests cover how problems are made and checked.
- [ ] You built two features from the menu below.
- [ ] The final commit is [tagged](../../docs/glossary.md#tag) `stage-1-done`.

## Steps

### 1.1 Hello

`dotnet run` greets the player by name, asks one math question you wrote yourself, like `7 + 5`, and says whether the answer was right.

Do [Getting started](../../docs/getting-started.md) first. This is your first [pull request](../../docs/glossary.md#pull-request-pr), so follow [Workflow](../../docs/workflow.md) too.

`Console.WriteLine` is like Scratch's *say* block. `Console.ReadLine` is like *ask and wait*.

Look up:
- [Create a .NET console app](https://learn.microsoft.com/en-us/dotnet/core/tutorials/create-console-app?pivots=vscode)
- [Console.ReadLine](https://learn.microsoft.com/en-us/dotnet/api/system.console.readline)
- [String interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/string-interpolation): like JavaScript's template literals

### 1.2 Random problems

Every run asks a different addition or subtraction question.

Look up:
- [Random.Next (the max is never picked!)](https://learn.microsoft.com/en-us/dotnet/api/system.random.next)
- [Random numbers (Bro Code video)](https://www.youtube.com/watch?v=1gSFd-YVFP8)

### 1.3 Play again?

After each question, ask "Play again? (y/n)". `y`, `Y`, `yes`, and `YES` all mean yes. `n` and `no` mean quit. Anything else asks again.

A loop is like Scratch's *repeat until* block.

Look up:
- [Loops (Brackeys video)](https://www.youtube.com/watch?v=9ozOSKCiO0I)
- [Trim](https://learn.microsoft.com/en-us/dotnet/api/system.string.trim) · [ToLower](https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower)

### 1.4 Gates and lives

The full game: 10 gates, 3 lives, and a win or game-over message. Write it all in `Main` for now. Messy is fine.

Look up:
- [Branches and loops tutorial](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops)
- [if and switch statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)

### 1.5 Split `Main`

[Refactor](../../docs/glossary.md#refactor) `Main` into methods. Each method does one job, and its name says what that job is. Good candidates: making a problem, asking a question, checking an answer. The game plays exactly the same as before.

Look up:
- [Methods (Brackeys video)](https://www.youtube.com/watch?v=bPQx0paXrbw)
- [Do one thing (Dreams of Code video)](https://www.youtube.com/watch?v=ywDxJbULcdM)
- Extract Method in your editor: [Rider](https://www.jetbrains.com/help/rider/Refactorings__Extract_Method.html) · [VS Code](https://code.visualstudio.com/docs/csharp/refactoring)

### 1.6 First tests

Add a test project. Write [unit tests](../../docs/glossary.md#unit-test) for the methods that don't touch the console.

Notice which methods are easy to test and which aren't. That's the lesson of this step.

Look up:
- [Testing](../../docs/testing.md)

### 1.7 Bulletproof input and difficulty

Bad input gets a friendly "try again", never a crash. The player picks easy, medium, or hard, and the numbers change to match. Add × and ÷. Division answers always come out even, with no remainders.

Hint for division: make the answer first, then build the question from it.

Look up:
- [int.TryParse](https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse): a safer `parseInt`
- [The remainder operator %](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators)
- [Enums](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)

### 1.8 Your two features

Pick two from the menu. Plan each one in an [issue](../../docs/glossary.md#issue) first, then link the issue from your PR.

## Pick two features

- **Streak bonus.** Several right answers in a row earn extra points or a life.
- **High score.** Save the best score to a file, and show it when the game starts. ([File.WriteAllText](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.writealltext) · [File.ReadAllText](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext))
- **Hints.** The player can ask for a hint, but it costs points.
- **Boss gate.** The last gate is a harder, multi-step problem.
- **Speed scoring.** Faster answers score more points. ([Stopwatch](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch))
- **ASCII art.** Draw gates that open, and a big victory screen.
- **Your own idea.** Pitch it in an issue first.

## Before you move on

- Which part would be hardest to change if a new rule came along?
- What did you copy and paste more than once?

Write your answers in the PR description of your last Stage 1 PR. Stage 2 starts from there.

Check what you learned: [Concepts, Stage 1](../../docs/concepts.md#stage-1-math-gate).
