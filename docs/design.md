# Design

The ideas behind well-organized code, in the order you meet them. Each one has a short summary, the step where you use it, and a link to learn more.

## Classes and objects

### Classes
A class is a blueprint, and an object is one thing made from it. Each `new Character(...)` has its own health, like a Scratch sprite clone. *Step 2.2.*

[Classes (Brackeys video)](https://www.youtube.com/watch?v=WKjfCHxeEz4)

### Encapsulation
A class keeps its data private and offers safe ways to change it. Other code calls `TakeDamage(5)`, and can't set health to `-500`. *Step 2.2.*

[Encapsulation for beginners (Stackify)](https://stackify.com/oop-concept-for-beginners-what-is-encapsulation/) · [Encapsulation explained (CodeBeauty video)](https://www.youtube.com/watch?v=vQ6k1U6nADY)

### Value and reference types
A number is copied when you pass it around. An object is shared: if two variables point to the same monster, damage through one shows up in the other. *Step 2.3.*

[Value and reference types (Tarodev video)](https://www.youtube.com/watch?v=ldq7ZByB4p8)

### Inheritance and polymorphism
A `Troll` and a `Goblin` share code from `Monster`, and each changes only the parts that differ. The battle code treats them all as monsters. *Step 2.5.*

[Polymorphism](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism)

### Interfaces
A promise that a class has certain methods, without saying how they work. If every game state has `HandleInput`, the game can talk to any of them the same way. *Step 3.2.*

[Interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces) · [Interfaces vs abstract classes (Raw Coding video)](https://www.youtube.com/watch?v=PPZ_vZcF2AU)

### Composition
Building an object from smaller parts instead of a deep family tree of classes. It's how Unity works, and it often beats inheritance. *Step 4.6.*

[The Flaws of Inheritance (CodeAesthetic video)](https://www.youtube.com/watch?v=hxGOiiR9ZKg)

## Design principles

### Single responsibility
Each method or class does one job. If its name needs "and", like `AskAndCheckAndScore`, it's doing too much. *Step 1.5.*

[Single responsibility (Dreams of Code video)](https://www.youtube.com/watch?v=ywDxJbULcdM)

### Cohesion and coupling
High cohesion: everything in a class belongs to its one job. Low coupling: classes know little about each other's insides, so you can change one without breaking the rest. *Step 2.4, again in 3.4 and 4.2.*

[Coupling and cohesion (Gui Ferreira video)](https://www.youtube.com/watch?v=7pdrZDqEPIw) · [Cohesion and coupling: the difference](https://enterprisecraftsmanship.com/posts/cohesion-coupling-difference/)

### Dependency injection
Hand a class what it needs instead of letting it create its own. A class given a `Random` can be given a seeded one in tests. *Step 2.3.*

[Explicit dependencies (.NET architectural principles)](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles)

### Tell, don't ask
Don't ask an object for its data and decide for it. Tell it what you want, and let it decide. A door knows whether it's locked. *Step 3.3.*

[Tell, don't ask (Martin Fowler)](https://martinfowler.com/bliki/TellDontAsk.html)

### Separation of concerns
Keep code that decides what happens apart from code that shows it. Your game rules don't print, so they can be tested without a screen and reused in Unity. *Step 1.6, then 3.4.*

[Separation of concerns](https://en.wikipedia.org/wiki/Separation_of_concerns)

### Dependency inversion
Important code shouldn't depend on details like the console. The console code depends on the game rules instead, which is what lets Unity replace it. *Step 3.4.*

[Dependency inversion (Simple Programming video)](https://www.youtube.com/watch?v=Dl7D4_PiYp4)

## Refactoring

### Refactoring
Changing how code is organized without changing what it does. You do it at the start of every stage. *Step 1.5, then every stage.*

[Extract Method](https://refactoring.guru/extract-method)
