# Glossary

Quick definitions, A to Z.

### Branch
A separate line of work in git. You make changes on a branch, and `main` stays safe until your PR merges.

### Build
Turning your C# code into something the computer can run. `dotnet build` does it, and `dotnet run` builds first, then runs.

### CI (continuous integration)
A robot that checks every PR, for example by running your tests. If it fails, you see a red ❌ on the PR. You set it up in Step 2.6.

### Class
A blueprint for objects. It bundles data, like health, with the code that uses it, like `TakeDamage`. Like a Scratch sprite: its own variables and its own scripts.

### Class library
A project that holds code for other projects to use, but doesn't run by itself. It builds into a [DLL](#dll-assembly).

### Clone
Copying a repository from GitHub to your computer, so you can work on it.

### Cohesion
How well the parts of a class belong together. High cohesion is good: the class has one clear job.

### Commit
A saved snapshot of your changes in git, with a message that says what changed.

### Coupling
How much one class depends on the details of another. Low coupling is good: you can change one class without breaking the others.

### DLL (assembly)
A compiled file of C# code, ready for other programs to use. Each project builds into one. Unity can load DLLs, which is how your game rules get into Unity in Stage 4.

### Encapsulation
Keeping a class's data private, so other code can only change it in safe ways. For example, nothing outside can set health to -500.

### Enum
A type with a fixed list of named values, like `Easy`, `Medium`, and `Hard`.

### Fork
Your own copy of someone else's GitHub repository. You work in your fork.

### Front end
The part of a program that shows things and collects input. Your console code is one front end, and Unity becomes another.

### Game logic
The rules of your game: how problems are made, how damage works, what's in each room. It doesn't care how things look on screen.

### Game loop
The loop at the heart of every game: read input, update the world, show the result, repeat. Like Scratch's *forever* block.

### Inheritance
Making a new class based on an existing one. A `Troll` can inherit from `Monster`, and get everything `Monster` has for free.

### Interface
A list of methods a class promises to have, without saying how they work. Different classes can keep the same promise in different ways.

### Issue
A to-do item on GitHub: a bug, a feature idea, or a plan.

### Method
A named block of code that does one job. It can take inputs (parameters) and give back a result (a return value). Like a custom block in Scratch or a function in JavaScript.

### Namespace
A name that groups related classes, like a folder for code. `System.Console` means the `Console` class in the `System` namespace.

### Project
A folder with a `.csproj` file, which builds into one program or one [DLL](#dll-assembly).

### Pull request (PR)
A request to merge your branch into `main`. Your reviewer reads it, comments, and approves it.

### Refactor
Reshaping code without changing what it does. The game plays the same; the code is just easier to work with.

### Release
A download page on GitHub, attached to a tag, where people can get your game.

### Runner
The computer GitHub uses to run your workflow. You choose Windows, Mac, or Linux.

### Seed
The starting number for `Random`. The same seed always gives the same "random" numbers, which makes tests repeatable.

### Solution
A file (`.slnx`) that groups your projects, so you can build and test them all at once.

### State machine
A way to organize something that behaves differently depending on what's happening. A game might be in a menu state, an exploring state, or a fight state, and it switches between them.

### Tag
A name stuck on one commit, like `stage-1-done`, so you can find it later.

### Terminal
A window where you type commands, like `dotnet run` or `git commit`.

### Unit test
A small piece of code that calls your code and checks the answer. `dotnet test` runs them all.

### Workflow (GitHub Actions)
A file in `.github/workflows/` that tells GitHub what to do automatically, like run your tests on every PR.
