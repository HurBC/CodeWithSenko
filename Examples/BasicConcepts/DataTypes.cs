using System;

namespace CodeWithSenko.Examples.BasicConcepts;

public partial class BasicConcepts
{
    /// <summary>
    /// This method contains a more detailed version of the post “Data Types” uploaded on September 16, 2023.
    /// <list type="bullet">
    ///     <listheader>
    ///         <term>Content</term>
    ///         <description>Topics covered in this post:</description>
    ///     </listheader>
    ///     <item>
    ///         <description>Variable declaration and initialization.</description>
    ///     </item>
    ///     <item>
    ///         <description>Whole numbers: <see cref="int"/>, <see cref="long"/>, etc.</description>
    ///     </item>
    ///     <item>
    ///         <description>Floating-point numbers: <see cref="float"/> and <see cref="double"/>.</description>
    ///     </item>
    ///     <item>
    ///         <description>High-precision values: <see cref="decimal"/>.</description>
    ///     </item>
    ///     <item>
    ///         <description>Logical values: <see cref="bool"/>.</description>
    ///     </item>
    ///     <item>
    ///         <description>Textual data: <see cref="char"/> and <see cref="string"/>.</description>
    ///     </item>
    /// </list>
    /// </summary>
    private void DataTypes()
    {
        /*************/
        /* Variables */
        /*************/

        // What is a variable??

        // A variable is a memory space that allows us to store values of different types, from numbers, texts, or object instances.
        // In C#, when we want to declare a variable, we must follow this pattern:
        // datatype variableName = value;
        // For example:
        int x = 10;

        // In this case, we declare a variable of type int, which stores the value 10 in that space in memory.

        // And What happens if I want to declare a variable without assigning a value to it immediately?
        // Well, in C#, as in several other languages, you can declare a variable without assigning it an initial value.
        // This can be done as follows:
        int y;

        // In the previous example, we are generating a variable that points to a space in memory that is currently empty and has no value, also known as null
        // For assign a value we need to use the assignation operator "="
        y = 10;

        // But what if I don't know what type the variable will be?
        // For example, when I receive an external value and don't know what it might return, how do I declare a variable?
        // Well, in that specific case, you can always use the reserved word “var”

        // This create a implicit variable without a data
        // This generates a variable without a specific data type, but this in turn limits you to having to assign an initial value.
        var z = "Hello";

        // This will throw a compilation error
        // var z;
        // Why does this happen with implicit variables?
        // Well, this happens because when we define the data type, we tell C# how much memory space to reserve for that variable.
        // Each data type uses a different amount of memory space.
        // When using “var,” C# does not know how much space to reserve until it sees the type of value we are storing.

        /************/
        /* Integers */
        /************/

        // Integer variables can only store whole numbers (which can be deduced from the name).
        // However, these integers are divided into different types, for example:
        // With or without a sign
        // 8 bits integers
        // 16 bits integers
        // 32 bits integers
        // 64 bits integers

        // When we need to store numbers, we must consider whether it is really worth using too much space for numbers that will never reach that range.
        // For example, a person's age—is it really worth reserving 4 bytes (32-bit numbers) for values that don't exceed 1 byte (8-bit numbers)?

        /* 8-bit integers */
        // 8-bit numbers can be declared with the reserved words “byte” and "sbytes"

        byte age = 20;

        // In the previous example, the variable “age” reserves 1 byte of memory to store a number that can only be in the range from 0 to 255.
        // But what if I need to store a negative number that doesn't take up much space?

        // In this case, we can use the “sbyte” data type, which allows us to store numbers from -128 to 127
        sbyte temperature = -18;

        /* 16-bit integers */
        // To declare 16-bit numbers, we can use the reserved words “short” and “ushort.”
        // Being “short” for signed numbers from -32,768 to 32,767
        // And “ushort” for unsigned numbers from 0 to 65,535

        short auraOfPythonDevs = -32768;
        ushort auraOfCSharpDevs = 65535;

        /* 32-bit Integers */
        // To declare 32-bit numbers, we will use the reserved words “int” and “uint.”
        // Being “int” for signed numbers from -2,147,483,648 to 2,147,483,647
        // And “uint” for unsigned numbers from 0 to 4,294,967,295

        int distanceFromEarthToTheMoon = 384400;
        int sunDiameter = 1391016;

        /* 64-bit Integers */
        // To declare 64-bit numbers, we will use the reserved words “long” and “ulong.”
        // Being “long” for signed numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        // And “ulong” for unsigned numbers from 0 to 18,446,744,073,709,551,615

        long ageOfTheEarth = 4540000000;
        ulong urMomWeight = 18446744073709551615;

        // Let's look at the last example. 
        // If you notice, it's a very long number and therefore difficult to read, right?
        // You may be wondering if there is a better way to write numbers so that they are a little more legible.
        // And the answer is yes, there is.

        // C# allows us to use “_” when writing numbers, which helps make them more readable for both us and other developers.
        // Let's try it with the previous example.

        urMomWeight = 18_446_744_073_709_551_515;

        // As you can see, C# does not give any error when doing this

        /**************************/
        /* Floating-point numbers */
        /**************************/

        // Floating point numbers are numbers that contain decimals
        // And these are divided into three groups depending on the precision of the decimals we need.

        // Floats
        // Doubles
        // Decimals

        /* Floats */
        // Floats are numbers that have an approximate precision of 6 to 9 decimal places.
        // But what do you mean by “approximately”?

        // Well, when we say that float or decimal numbers have an approximate precision of x digits, it is because when these numbers are saved, they are converted to binary using some unusual algorithms.
        // Therefore, this precision can be lost in long numbers, with 6 digits (for floats) being the maximum number of digits that cannot be lost and 9 digits (also for floats) being the maximum number of digits needed to correctly differentiate between two different floats.
        // Floats have an approximate range of ±1.5×10^45 to ±3.4×10^38.

        // Getting back to the main point, to declare a float we must use the reserved word “float” and also add an “f” at the end.

        float wideOfSenkoBread = 15.5f;

        // But...
        // Why we have to use the “f” at the end?

        // 
    }
}
