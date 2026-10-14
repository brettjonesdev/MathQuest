# Code style

Code that looks the same everywhere is easier to read and review. Two tools come with .NET, so you don't need to install anything:

- **`dotnet format`** rewrites your code to match your style rules: spacing, braces, `using` order, and more. ([dotnet format](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-format))
- **Code analyzers** run while you build and warn you about bugs and style problems. ([Code analysis in .NET](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview))

## Set it up

1. Create an `.editorconfig` file at the root of the repository. It holds your style rules, and both your editor and `dotnet format` read it. ([Code style options in .editorconfig](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/code-style-rule-options))
2. Run `dotnet format` and commit the result in its own PR, so your reviewer isn't buried in formatting changes mixed with real ones.
3. Make style problems show up as build warnings. Turn on `EnforceCodeStyleInBuild`, then give each rule you care about a severity, such as `warning`, in `.editorconfig`. Without a severity, a rule stays silent. ([Code analysis in .NET](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview))
4. Add this step to your [CI](glossary.md#ci-continuous-integration) workflow, so a PR fails if it isn't formatted:
   ```sh
   dotnet format --verify-no-changes
   ```

## Habits

- Run `dotnet format` before you push.
- Fix warnings when you see them. A pile of 50 warnings hides the one that matters.
- Change a rule only when you have a reason, and say why in the PR.
