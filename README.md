# CodeWithSenko

<div align="center">
    <img width="500" height="500" alt="Senko-San Logo" src="https://github.com/user-attachments/assets/7352faba-ca25-4d9a-befa-d7741dbc6199" />
    <br/>
    <h3>The "Iceberg" of C# Programming</h3>
    <p><i>"What you see on the surface is just syntax. The real magic happens below."</i></p>
</div>

---

## ❄️ Why This Repository is Different? (The "Deep Dive")

This repository isn't just another generic C# tutorial. It serves as the **technical "Deep Dive"** companion to the **CodeWithSenko** series on Instagram.

This is a resource for both beginners who want to build a strong foundation and experienced developers looking to understand what happens under the hood of .NET.

---

## 🗺️ Module Roadmap

### 🟢 Module: Basic Concepts
*   **Print In Console**
    *   *Based on post: "Print in console" (Sep 16, 2023)*
    *   Covers the essential `Console` class methods:
        *   `WriteLine()`: Printing with line breaks.
        *   `Write()`: Continuous printing without line breaks.
*   **Data Types**
    *   *Based on post: "Data Types" (Sep 16, 2023)*
    *   Explores the primitive building blocks of C#:
        *   **Integrals**: From 8-bit `byte`/`sbyte` to 64-bit `long`/`ulong`.
        *   **Floating Point**: The precision differences between `float` (6-9 digits), `double` (15-16 digits), and `decimal` (28-29 digits).
        *   **Booleans & Chars**: Logic flags and Unicode character storage.
*   **Strings**
    *   *Based on posts: "The Truth Behind Strings" (Nov 13, 2023) & "Strings 2" (Nov 15, 2023)*
    *   A deep dive into the reference type that behaves like a primitive:
        *   **Immutability**: Why modifying a string actually creates a new one.
        *   **Manipulation**: `IndexOf`, `Substring`, `Replace`, `ToUpper`/`ToLower`.
        *   **Composition**: Concatenation vs. Interpolation (`$""`) vs. Formatting.
*   **Operators (The Crown Jewel)**
    *   *Based on post: "Operators && Conditionals part 1" (Sep 19, 2023)*
    *   Our most comprehensive module to date. It goes far beyond simple math:
        *   **Arithmetic**: Standard operations plus the nuances of `++` and `--` prefix/postfix execution order.
        *   **Logical & Comparative**: Boolean logic gates (AND `&&`, OR `||`, NOT `!`) and relationals.
        *   **Bitwise Engineering**: Direct memory manipulation using Bitwise AND `&`, OR `|`, XOR `^`, NOT `~`.
        *   **Bit Shifting**: Optimizing multiplication/division with Left Shift `<<` and Right Shift `>>` (including the unsigned shift `>>>`).
        *   **Binary Secrets**: Understanding Two's Complement for negative number representation.

---

## 🚀 How to Execute

To run the project and see the code in action:

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/YourUsername/CodeWithSenko.git
    cd CodeWithSenko
    ```

2.  **Run the project**:
    The project is a standard .NET Console Application.
    ```bash
    dotnet run
    ```
    *This will execute the `BasicConcepts` flow, running through the examples sequentially.*

---

## 🏗️ Internal Architecture

> *Note: This section is for contributors and curious developers who want to understand the framework behind the lessons.*

The project uses a custom **Module Pattern** to manage lessons efficiently.

### The `Module` Class
Located in `Modules/Module.cs`, this is the abstract base class for all lessons. It handles the lifecycle of the code execution:
1.  **Configuration**: Uses `ModuleName(string)` and `IsSubModule(bool)` to set up metadata.
2.  **Execution Flow**: The `public void Execute()` method handles the UI formatting (headers, separators) and then invokes the logic.
3.  **Encapsulation**: The actual lesson code resides in the `protected override void ModuleBody()` method, isolating the logic from the execution harness.

```csharp
public abstract class Module
{
    protected abstract void ModuleBody();
    public void Execute() { ... }
}
```
