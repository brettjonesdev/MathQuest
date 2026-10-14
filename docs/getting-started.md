# Getting started

Do this once, before Stage 1.

## 1. Install your tools

- **The .NET SDK**, version 10. ([download](https://dotnet.microsoft.com/en-us/download))
- **An editor.** Pick one:
  - Visual Studio Code with the C# Dev Kit extension. ([setup guide](https://code.visualstudio.com/docs/csharp/get-started))
  - JetBrains Rider, which is free for non-commercial use. ([free license FAQ](https://sales.jetbrains.com/hc/en-gb/articles/18950890312210-The-free-non-commercial-licensing-FAQ))
- **Git**, plus a GitHub account. ([Installing Git](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git))

You'll type commands in a *terminal*. In VS Code, use **Terminal → New Terminal**. In Rider, use the **Terminal** tab at the bottom. Check that .NET installed by running:

```sh
dotnet --version
```

New to git and GitHub? Do [GitHub Hello World](https://docs.github.com/en/get-started/using-github/hello-world) first. It takes about 10 minutes.

## 2. Fork and clone

1. [Fork](glossary.md#fork) this repository to your own GitHub account. ([Fork a repository](https://docs.github.com/en/pull-requests/how-tos/work-with-forks/fork-a-repo))
2. [Clone](glossary.md#clone) your fork to your computer. ([Cloning a repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository))
3. On your fork, open the **Actions** tab and turn workflows on. Forks start with them off, and Stage 2 needs them.

Do these two with your reviewer:

4. Add your reviewer as a collaborator: **Settings → Collaborators**. ([Inviting collaborators](https://docs.github.com/en/repositories/managing-your-repositorys-settings-and-features/repository-access-and-collaboration/inviting-collaborators-to-a-personal-repository))
5. Protect `main`, so a PR needs one approval before it can merge. ([Creating rulesets](https://docs.github.com/en/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/creating-rulesets-for-a-repository))

## 3. Create the solution

Make a branch first:

```sh
git checkout -b stage1-hello
```

Then, from the root of your clone:

```sh
dotnet new sln -n MathQuest
dotnet new console -o src/MathQuest --use-program-main --langVersion 9
dotnet sln add src/MathQuest
dotnet new gitignore
```

What these do:

- `dotnet new sln` creates a [solution](glossary.md#solution): one file that groups your projects. Your test project joins it later.
- `dotnet new console` creates the game [project](glossary.md#project). `--use-program-main` gives you a classic `Main` method, which you'll spend Stage 1 moving code out of.
- `--langVersion 9` uses C# 9, the version Unity understands. Stage 4 brings your code into Unity, and this keeps it ready. ([C# language versions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-versioning))
- `dotnet new gitignore` tells git to skip build output, such as the `bin/` and `obj/` folders.

### Check the C# 9 setup

Open `src/MathQuest/MathQuest.csproj`. Inside `<PropertyGroup>`, make sure these two lines are there, and add them if they aren't:

```xml
<LangVersion>9</LangVersion>
<ImplicitUsings>disable</ImplicitUsings>
```

Open `src/MathQuest/Program.cs`:

- If it starts with `namespace MathQuest;`, ending in a semicolon, change it to `namespace MathQuest {` and add a `}` at the end of the file. C# 9 doesn't have the semicolon version.
- If it doesn't have `using System;` at the top, add it.

### Run it

```sh
dotnet run --project src/MathQuest
```

You should see `Hello, World!`. Now open [Step 1.1](../stages/1-math-gate/README.md#11-hello) and make it your own.
