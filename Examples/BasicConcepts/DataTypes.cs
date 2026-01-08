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
    ///         <description>Textual data: <see cref="char"/>.</description>
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

        // In the previous example, we are generating a variable that points to a space in memory that is currently empty and has no value
        // The variable is declared but not initialized.
        // It does not contain a usable value yet.
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

        urMomWeight = 18_446_744_073_709_551_615;

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

        // when we say that float or double numbers have an approximate precision, it is because when these numbers are saved, they are converted to binary using some unusual algorithms.
        // Therefore, this precision can be lost in long numbers, with 6 digits (for floats) being the maximum number of digits that cannot be lost and 9 digits (also for floats) being the maximum number of digits needed to correctly differentiate between two different floats.
        // Floats have an approximate range of ±1.5×10^-45 to ±3.4×10^38.

        // Getting back to the main point, to declare a float we must use the reserved word “float” and also add an “f” at the end.

        float wideOfSenkoBread = 15.5f;

        // But...
        // Why we have to use the “f” at the end?

        // Well, this is because C# alone cannot differentiate between floats and doubles on its own, but what does this have to do with anything?
        // Well, a float is a 32-bit number, while a double is a 64-bit number.
        // When you try to save any decimal number, C# will take it as a double by default, in other words as a 64-bit number, so when you try to save a 64-bit number in a 32-bit space, it will throw a compilation error.
        // To avoid this, the character “f” is used at the end of the number to tell C# that the number we are giving it is actually a float and not a double.

        // Try hovering your mouse over the variable names, and your IDE will tell you what type each one is. 
        var decimalNumber = 15.0f;
        var decimalNumber2 = 15.0;

        /* Doubles */
        // Doubles are similar to floats, but with the difference that they are 64-bit numbers and also have greater precision than floats.
        // Unlike floats, doubles have a precision of 15 to 16 digits.
        // For this reason, its numerical range is approximately ±5.0×10^-324 to ±1.7×10^308

        // To declare these, we use the reserved word double and assign the value in the normal way.
        double PIPI = 3.14159265359;

        /* Decimals */
        // Unlike their two siblings, decimals are extremely precise numbers.
        // This is because, unlike the others, they store their numbers in base 10, while floats and doubles use binary.
        // This difference can give decimals much greater precision, from 28 to 29 digits.
        // But this comes at a cost.
        // Decimals are the heaviest numeric data type of all, because they are 128-bit numbers, and it is better to use them for very specific cases in which very good precision is required.
        // Decimals have a numerical range of approximately ±1.0×10^-28 to ±7.9×10^28.

        // To declare these numbers, you must use the reserved word “decimal” and use ‘M’ at the end of the number so that C# does not treat it as a double.

        decimal earthMassInKg = 5972000000000000000000000m;

        /* Scientific connotation */
        // Float, double, and decimal literals support scientific notation
        // For example, if we wanted to represent the largest number that each one can store, we could do the following:
        float biggestFloatNumber = 3.4e38f; // == 3.4×10^38
        double biggestDoubleNumber = 1.7e308; // == 1.7×10^308
        decimal biggestDecimalNumber = 7.8e28m; // == 7.9×10^28

        /************/
        /* Booleans */
        /************/

        // What are Booleans?
        // Boolean values are those types that can only have two possible values, true or false.
        // These are the most primitive type of value of all, as they only represent a 1 or a 0, with 1 being true and 0 being false.
        // In addition to being the lightest of all, using only 1 byte in memory.

        // To declare these values, you must use the reserved word bool and assign it one of the possible values “true” or “false.”
        bool isHL3ComingOutThisYear = false;
        bool isCodeWithSenkoTheBestAccount = true;

        // But when will we want to use these values?
        // Well, booleans are used almost everywhere, if not everywhere.
        // They are often used to declare flags in some structures, such as whether a person has a job or not.

        /* Senko data */
        short senkoAge = 800;
        bool senkoHasTail = true;

        // In the previous example, the variable “senkoHasTail” allows us to verify that Senko does indeed have a tail.

        // But Booleans are not limited to that.
        // They are also widely used in program flow control.
        // For example, when we use logical operators, they return Booleans.
        // Example:

        // Write your age here
        short yourAge = 0;

        // Depending on the value of “yourAge,” the conditional will return a different value. Try it yourself.
        Console.WriteLine(senkoAge > yourAge);

        /*---------*/
        /*  Chars  */
        /*---------*/

        // What is a char?
        // Char variables are responsible for storing only one character within them. 
        // Unlike their older sibling (Strings), chars must be declared with single quotation marks (for example: ‘S’).
        // To declare these variables, we must use the reserved word “char.”

        char senkoInitial = 'S';

        // But what happens if I use double quotation marks?
        // This will cause a compilation error because, unlike other languages such as Python or JS, in C# quotation marks are used to differentiate and declare types.
        // In this case, the types are String and char.
        // char senkoInitial = "S";

        // C# characters, as simple as they may seem, are not so simple, because without them, strings would not exist.
        // But what sets them apart from other languages?
        // C# characters weigh 2 bytes in memory and store Unicode characters, due to Unicode's greater capacity than ASCII to represent special characters.

        // You may be wondering, “Why would I want to save only one character?”

        // Imagine you have a console application that at some point asks the user a question that the user can only answer with yes or no.
        // Is it really worth saving the entire “Yes” or “No” text to know what the user's response was?
        // The truth is, no, for several reasons.
        // Two of these are memory and comparison.

        // For example, the character ‘Y’ takes up much less memory than the text “Yes,” but also, the simple fact that it is a char type saves even more memory, because Strings are a heavier data type, which we will look at in depth later on.

        // Furthermore, comparing them is more tedious, 
        // since strings are more complex types and require their own methods to compare two of them, one of which is String.Equals, unlike chars, which can be compared using only the comparison operator “==”,
        // this is because a char is basically a 16-bit number, so C# can compare it as if it were two numbers.

        // For example, we can add numbers to chars.
        // This will print 66
        Console.WriteLine('A' + 1);
        // But what if we turn it into char?
        // Run the program and see what it returns.
        Console.WriteLine((char)('A' + 1));

        // The Strings will be in a specific module for them.
    }
}
