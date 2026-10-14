# Testing

A [unit test](glossary.md#unit-test) is a small piece of code that calls your code and checks the result. Run them all with one command, and in seconds you know whether a change broke something.

Tests start in [Step 1.6](../stages/1-math-gate/README.md#16-first-tests). From then on, every PR that changes game logic includes tests.

## Set up the test project

From the root of your repository:

```sh
dotnet new xunit -o tests/MathQuest.Tests
dotnet sln add tests/MathQuest.Tests
dotnet add tests/MathQuest.Tests reference src/MathQuest
dotnet test
```

The third command lets the tests use your game's code. ([dotnet reference add](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-reference-add))

Tests can only see `public` classes and methods. `Program` isn't public, so move the code you want to test into its own `public` class.

## Learn how to write tests

Do the Microsoft tutorial, then come back to your own code. ([Unit testing C# with xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-xunit))

You'll use two kinds of tests:

- `[Fact]` checks one fixed case.
- `[Theory]` with `[InlineData]` runs the same check on several inputs.

## What makes code testable

Some code is easy to test, and some isn't. This matters more than anything else on this page.

- **Easy:** a method that takes inputs and returns a result. For example, it takes two numbers and an operator, and returns the answer.
- **Hard:** a method that reads the keyboard, prints to the screen, or picks random numbers on its own.

When something is hard to test, move the console or randomness out of it, and pass in what it needs. ([Unit testing best practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices))

`Random` is the tricky one. A `Random` made with a fixed [seed](glossary.md#seed), such as `new Random(42)`, picks the same numbers every run. How could your code receive a seeded `Random` during a test? ([Random and seeds](https://learn.microsoft.com/en-us/dotnet/api/system.random))

## Habits

- Name each test for what it checks: `Division_AlwaysHasWholeNumberAnswer`.
- Test edge cases: zero, the biggest number on hard mode, health hitting exactly 0.
- When you find a bug, first write a test that fails because of it, then fix the bug. ([Red, green, refactor](https://www.codecademy.com/article/tdd-red-green-refactor))
