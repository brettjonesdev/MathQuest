# Concepts

The big ideas in MathQuest, in the order you meet them. Each one says what it is, why it matters, and where you use it.

When you finish a stage, read its section. Could you explain each idea to a friend, using your own code as the example? If not, go back to that step's Look up.

For quick definitions, see the [Glossary](glossary.md).

## How you work

### Version control
Git saves snapshots (commits) of your code, so you can always go back. Branches let you try things without breaking `main`.
*Where:* every step.

### Pull requests and code review
A PR asks to merge your branch. Someone else reads the code before it goes in. Reviews catch bugs, and explaining your change in writing makes you understand it better.
*Where:* every step.

### Automated tests
Code that checks your code. Once you have tests, you can change things without fear. If something breaks, a test tells you right away.
*Where:* from [Step 1.6](../stages/1-math-gate/README.md#16-first-tests) on.

## Stage 1: Math Gate

### Input and output
Programs talk to the player by printing (`Console.WriteLine`) and reading (`Console.ReadLine`). Everything the player types arrives as text, even numbers.
*Where:* Step 1.1.

### Random numbers
`Random` picks numbers for you. `Next(1, 10)` picks from 1 to 9: the second number is never picked.
*Where:* Step 1.2.

### Loops
A loop repeats code until something is true, like "the player said no" or "lives reached 0". Every game is built around one.
*Where:* Steps 1.3 and 1.4.

### Conditions
`if` and `switch` choose what happens next, based on what's true right now.
*Where:* Step 1.4.

### Methods
A method is a named piece of code with one job. Methods let `Main` read like an outline, and let you reuse code instead of copying it.
*Where:* Step 1.5.

### Single responsibility
Each method, and later each class, should do one job. A method named `AskQuestionAndCheckAnswerAndUpdateScore` is doing too much.
*Where:* Step 1.5.

### Refactoring
Changing how code is organized without changing what it does. You refactor at the start of every stage.
*Where:* Step 1.5, then every stage.

### Testable code
Code that takes inputs and returns a result is easy to test. Code that reads the keyboard or prints is hard to test. Good design keeps the two apart.
*Where:* Step 1.6.

### Parsing and bad input
Turning text into a number can fail. `int.TryParse` tells you whether it worked, instead of crashing.
*Where:* Step 1.7.

### Integer division and remainders
`7 / 2` is `3` with whole numbers, and `7 % 2` is the remainder, `1`.
*Where:* Step 1.7.

### Enums
A fixed set of named choices, like difficulty levels. Safer than using strings or magic numbers.
*Where:* Step 1.7.

## Stage 2: Math Arena

### Classes and objects
A class is a blueprint, and an object is one thing made from it. Each `Character` object has its own health.
*Where:* Step 2.2.

### Encapsulation
A class protects its own data. Other code asks the class to change things, like `TakeDamage(5)`, instead of reaching in and setting `Hp = -500`.
*Where:* Step 2.2.

### Properties
Properties look like variables from outside, but the class controls them. A private setter means only the class itself can change the value.
*Where:* Step 2.2.

### Value and reference types
A number is copied when you pass it around. An object is shared: if two variables point to the same monster, damage through one shows up in the other.
*Where:* Steps 2.3 and 2.4.

### Passing in what a class needs
A class that creates its own `Random` is hard to test. A class that's *handed* a `Random` can be given a seeded one in tests.
*Where:* Step 2.3.

### Lists
A `List` holds any number of things in order, like the monsters waiting to fight.
*Where:* Step 2.4.

### Cohesion and coupling
High cohesion: each class has one clear job. Low coupling: classes know little about each other's insides. Together, they mean you can change one part without breaking the rest.
*Where:* Step 2.4, again in 3.4 and 4.2.

### Inheritance and polymorphism
A `Troll` and a `Goblin` can share code from `Monster`, and each can change only the parts that differ (`virtual` and `override`). The battle code treats them all as monsters.
*Where:* Step 2.5.

### Continuous integration
A robot runs your tests and style checks on every PR, so problems show up before they merge.
*Where:* Steps 2.6 and 2.7.

### Releases
Building your game for each platform and publishing it where anyone can download it.
*Where:* Step 2.9.

## Stage 3: Math Dungeon

### The game loop
Read input, update the world, show the result, repeat. Every game runs one, including every Unity game.
*Where:* Step 3.1.

### Dictionaries
A `Dictionary` looks things up by a key, like finding the room to the `"north"`.
*Where:* Step 3.1.

### Parsing commands
Splitting `"take sword"` into a verb and a noun, then deciding what to do with them.
*Where:* Step 3.1.

### State machines
A game behaves differently in a menu, while exploring, and in a fight. Giving each state its own class keeps that behavior apart.
*Where:* Step 3.2.

### Interfaces
A promise that a class has certain methods. If every state has `HandleInput`, the game can talk to any state the same way.
*Where:* Step 3.2.

### Tell, don't ask
Instead of asking an object for its data and deciding for it, tell it what you want and let it decide. A door knows whether it's locked.
*Where:* Step 3.3.

### Separating logic from display
Game logic decides what happens. A front end decides how it looks. Keeping them apart lets you swap the front end, and test the logic without a screen.
*Where:* Step 3.4.

### Dependency inversion
Important code shouldn't depend on details like the console. The details depend on the important code instead.
*Where:* Step 3.4.

## Stage 4: MathQuest in Unity

### Assemblies and DLLs
Each project builds into a DLL. A class library is a project made to be used by other projects. That's how one set of game rules can run in two front ends.
*Where:* Step 4.2.

### Target frameworks
Each .NET version has different features. `netstandard2.1` is the version Unity understands, so your game rules target it.
*Where:* Step 4.2.

### Unity's loop
Unity runs the game loop for you and calls your script's `Update()` every frame. Your code reacts, then returns. It never waits.
*Where:* Step 4.3.

### Components and composition
In Unity, a GameObject gets its behavior from small components, like a health bar, a sprite, or a sound. Building things from parts often works better than deep inheritance.
*Where:* Step 4.6.

### Game feel
Small effects, like shake, flashes, sound, and damage numbers, make a game feel alive. They belong in the front end, not in the game rules.
*Where:* Step 4.5.
