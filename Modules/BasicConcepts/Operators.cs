using System;

namespace CodeWithSenko.Module.BasicConcepts;

/// <summary>
/// This module provides a comprehensive guide to C# operators, expanding on the concepts from the instagram post "Operators && Conditionals part 1" uploaded on September 19, 2023.
/// The conditionals part is not included in this module.
/// It covers the following categories:
/// <list type="bullet">
///     <item><description>Arithmetic Operators (Addition, Subtraction, Multiplication, Division, Modulus)</description></item>
///     <item><description>Logical Operators (AND, OR, NOT)</description></item>
///     <item><description>Comparative Operators (Equality, Relational)</description></item>
///     <item><description>Bitwise Operators (NOT, AND, OR, XOR, Shifts)</description></item>
///     <item><description>Assignment and Bitwise Assignment Operators</description></item>
/// </list>
/// Includes practical examples and detailed explanations for each operator type.
/// </summary>
public class Operators : Module
{
    protected override void ModuleBody()
    {

        /*-----------*/
        /* Operators */
        /*-----------*/

        // C# operators are symbols in the language that allow us to perform different types of operations within our program
        // Enabling us to manipulate data or even the program flow.

        // These are divided into different categories:
        // - Arithmetic
        // - Logical
        // - Assignment.
        // - Increment or Decrement.
        // - Special.

        /*----------------------*/
        /* Arithmetic Operators */
        /*----------------------*/

        // As the name suggests, arithmetic operators allow us to perform different mathematical operations on the numbers in our program.

        // Within this category, you will find the operators for addition, subtraction, multiplication, division, and one called modulus.

        /* Addition operator */
        int x = 1, y = 2;

        int z = x + y;

        Console.WriteLine($"The sum between {x} and {y} is: {z}");

        // Although it may seem simple, the addition operator allows you to do many more things.
        // It allows you to concatenate strings (see the Strings file in "Examples/BasicConcepts/Strings.cs line 246") and also join delegates (This will be explained in future).

        /* Substract operator */
        int nx = 1, ny = -2;

        int nz = nx - ny;

        Console.WriteLine($"The subtraction of {nx} and {ny} is: {nz}");

        // [EXTRA] You don't need to read this section; it's just extra content that's not relevant.
        // When using negative numbers, they go through a rather interesting process.
        // As you know, computers only really speak binary code (1 and 0), so how do we tell a computer that it is a negative number?
        // Let's take the number 2 from 8 bits as an example.
        // The binary representation of the number 2 is 10, and in 8 bits it would look something like this: 0000 0010

        // But how do we represent a negative number?
        // Well, to do that, we have to invert the bits of the number, in other words, change the 1s to 0s and vice versa.
        // Leaving it like this: 1111 1101
        // Once this is done, we must add 1 to our number, leaving our number as follows:
        // 1111 1110
        // For the computer, that binary is our -2

        // But why do we add a 1 at the end? Isn't it enough to just have it inverted?
        // This is quite easy to answer: the number 0.
        // What does 0 have to do with it?
        // Well, 0 cannot be negative or positive, so what happens?

        // This is quite easy to answer: the number 0.
        // What does 0 have to do with it?
        // 0 cannot be negative or positive, and the previous method without adding 1 gives us two types of 0, which can confuse our computer. 
        // Which would be this: 1111 1111.
        // So when adding 1, this binary looks like this: 1 0000 0000
        // Therefore, the remaining 1 is eliminated, leaving us with only the original 0000 0000
        // [EXTRA]

        /* Multiplication operator */
        int mx = 2, my = 4;

        int mz = mx * my;

        Console.WriteLine($"The multiplication of {mx} and {my} is: {mz}");

        // Like the “+” operator, the “*” operator has some secrets.
        // For example, pointers
        // Believe it or not, C#, like C++, contains memory pointers.
        // However, these are not considered safe and must be used within the “unsafe” block in C#.
        // This is a more advanced topic, so it will not be explained in this module.

        // [EXTRA]
        // In the past, the “*” operator was quite slow and costly for older CPUs, so instead of using the “*” operator, the “<<” operator was used, which serves to move the bits of a number.
        // But what is the difference between the two?
        // The operator “*” performs an algorithm called the Binary Multiplication Algorithm.
        // In short, this algorithm takes the binary representation of both numbers and multiplies the number on the left by each digit of the number on the right.
        // Example:
        // 101 * 010 (5 * 2)
        // Is like:
        // 101 * 0 = 000
        // 101 * 1 = 101
        // 101 * 0 = 000
        // And finally, the results are added up.
        //     000
        // +  1010
        // + 00000
        //________
        //   01010 = 10
        // While the operator “<<” only shifts the bit to the left
        // In other words, a 0 is added to the beginning of 101,
        // leaving it as 1010.
        // [EXTRA]

        /* Division operator */
        int dx = 2, dy = 10;

        int dz = dy / dx;

        Console.WriteLine($"The division of {dx} and {dy} is: {dz}");

        /* Modulus operator */
        // The “%” operator is quite similar to the “/” operator, but with the difference that it returns the remainder of the operation.

        int mox = 4, moy = 2;

        int moz = mox % moy;

        Console.WriteLine($"The remainder of {mox} divided by {moy} is {moz}");

        /* Increment and Decrement */
        // The “+” and “-” operators can also be used to increase/decrease a number when placed next to the value.

        int incrementX = 5;
        incrementX++;

        int decrementX = 5;
        decrementX--;

        Console.WriteLine($"The incrementX is {incrementX}");
        Console.WriteLine($"The decrementX is {decrementX}");

        // However, it is important to note that the order in which they are placed is important. Let's look at some examples.

        // It is not the same to do this:
        Console.WriteLine(incrementX++);
        Console.WriteLine(decrementX--);
        // As it is to do this:
        Console.WriteLine(++incrementX);
        Console.WriteLine(--decrementX);

        // Why does this happen?
        // Well, the C# compiler reads instructions from left to right, so when it reads the first examples, what it does is print the value of the variable and then increment/decrement it.
        // Whereas in the second case, the compiler first increments/decrements and then prints the value.
        // It may be a small thing, but it can still cause some critical errors in a C# program.

        /*-------------------*/
        /* Logical Operators */
        /*-------------------*/

        // What is a logical operator?
        // Logical operators allow us to execute Boolean logic to manage the flow of our program. 
        // They work in a similar way to logic gates, as they are their software counterpart.
        // These include the AND, OR, and NOT operators.

        /* AND Operator */
        // The AND operator compares two values. 
        // If both are true, this operator will return “true”
        Console.WriteLine("|---AND Operator---|");
        Console.WriteLine(true && true);
        Console.WriteLine(false && true);
        Console.WriteLine(true && false);
        Console.WriteLine(false && false);

        // If you run the previous example, you will see that of the four, only one returns true. 
        // This is because, as I mentioned earlier, this operator only returns true when both of its inputs are true.

        /* OR Operator */
        // Unlike AND, the OR operator returns “true” when at least one of the values is true.
        Console.WriteLine("|---OR Operator---|");
        Console.WriteLine(true || true);
        Console.WriteLine(false || true);
        Console.WriteLine(true || false);
        Console.WriteLine(false || false);

        /* NOT Operator */
        // This operator is somewhat different.
        // You may ask yourself, “Why?”
        // Unlike the previous operators, the NOT operator negates its input.
        // In short, it converts “true” to “false” and ‘false’ to “true.”
        Console.WriteLine("|---NOT Operator---|");
        Console.WriteLine(!true);
        Console.WriteLine(!false);

        // These operators can be combined to perform more complex logical operations.
        // Let's look at some examples:

        /* Senko data */
        bool hasFoxTail = true;
        bool is800YearsOld = true;
        bool isKitsune = true;
        bool knowHowToCook = true;

        bool isHuman = knowHowToCook || (!hasFoxTail && !is800YearsOld);
        Console.WriteLine($"Is senko a human? {isHuman}");

        bool isPerfectHelper = knowHowToCook || !isHuman;
        Console.WriteLine($"Is senko a perfect helper? {isPerfectHelper}");

        bool isAGoddess = isKitsune && is800YearsOld;
        Console.WriteLine($"Is senko a goddes? {isAGoddess}");

        // Negate the result
        bool isMortal = !(isKitsune && is800YearsOld);
        Console.WriteLine($"You are a mortal? {isMortal}");

        /*-----------------------*/
        /* Comparative Operators */
        /*-----------------------*/

        // Comparison operators allow us to compare two values to see if they meet a condition.
        // These operators can be combined with logical operators to generate complex comparisons.

        /* Greater than and less than */
        // The “<” and “>” operators allow us to compare sizes and determine whether A is greater than B or vice versa.
        // A example of this is in Examples/BasicConcepts/DataTypes.cs line 232

        // Examples:
        String name = "Senko";

        Console.WriteLine($"Does the name senko have more than 4 letters? {name.Length > 4}");
        Console.WriteLine($"Does the name senko have less than 5 letters? {name.Length < 5}");

        /* Equality operators */
        // These operators are responsible for verifying whether two values are equal or not.

        /* Equals */
        // Write your name
        String yourName = "";

        Console.WriteLine($"Is your name the same length as Senko's? {yourName.Length == name.Length}");

        /* Combined operators */
        // But what if I want to know if one value is greater than or equal to the other?
        // Should I do this?
        bool areMoreThanOrEqual = name.Length == yourName.Length || name.Length > yourName.Length;

        // Well, even though the above is valid, it is not the most recommended approach.
        // Besides, that's what the operators “>=” and “<=” are for.
        // These operators allow us to know if A is greater than or equal to B and vice versa. 

        Console.WriteLine($"Have your name more or the same characters than Senko's name? {yourName.Length >= name.Length}");
        Console.WriteLine($"Have your name less or the same characters than Senko's name? {yourName.Length <= name.Length}");

        // And what if you want two values to be different?
        // You may think that they can be done in the following way:
        int senkoAge = 800;

        bool areNotEquals = !(senkoAge == 800);

        // As before, this solution is validated in the same way, but for this purpose there is the “!=” operator, which checks whether A is different from B.
        bool areEqualsnt = senkoAge != 800;

        bool isPerfectKitsune = (senkoAge >= 500 || hasFoxTail) && knowHowToCook && !isHuman;
        bool isExactlySenko = senkoAge == 800 && isKitsune;

        Console.WriteLine($"Is she a perfect Kitsune? {isPerfectKitsune}");
        Console.WriteLine($"Is she exactly the Senko we know? {isExactlySenko}");

        /*-------------------*/
        /* Bitwise operators */
        /*-------------------*/

        // In addition to normal operators, C# contains operators that allow you to work at the bit level, basically with ones and zeros.

        /* Bitwise NOT */

        // The ~ operator allows us to perform a NOT operation at the bit level.
        // What does this mean?
        // Basically, it converts 1s to 0s and vice versa.

        // Example:
        // The 0b it tells the C# compiler that it is a binary number.
        byte binary = 0b10;

        System.Console.WriteLine($"Before bitwise not: {binary}, after bitwise not {~binary}");

        // If you run this code, you will see that the values 2 and -3 are printed.
        // Why does this happen?
        // If you recall, we previously discussed how negative numbers work (if you haven't read it, go to the extra section on Negative Numbers, lines 64 to 88).
        // When using the “~” operator, we perform part of the conversion from a positive number to a negative number. 
        // If we add 1 to our resulting number, we will get negative 2.

        System.Console.WriteLine($"Before bitwise not: {binary}, after bitwise not {~binary + 1}");

        // [NOTE]: If you want to see the number in its binary representation, you can use “:b” after the number.
        // Examples: “2:b”, “binary:b”, “(2 + 1):b”
        // Try it yourself with the prervious examples!!

        /* Logical/bitwise AND */

        // The “&” operator, also known as logical AND, evaluates the binary of two values by checking bit by bit.
        // What do I mean by this?
        // Imagine we have the following binaries: 101 and 110.
        // The “&” operator will check if each bit of both binaries is 1.
        // In this case, it would return 100.
        // Let's look at it in a table.
        // 0 & 0 = 0
        // 1 & 0 = 0
        // 0 & 1 = 0
        // 1 & 1 = 1

        byte binaryA = 0b101;
        byte binaryB = 0b110;

        System.Console.WriteLine($"Binary resulting from logical AND {(binaryA & binaryB):b}");

        /* Logical/bitwise OR */

        // Like logical AND, logical OR compares two values bit by bit but performs an OR operation.
        // This means that if one of the values is 1, it will return 1.
        // Let's look at it in a table.
        // 0 | 0 = 0
        // 1 | 0 = 1
        // 0 | 1 = 1
        // 1 | 1 = 1

        System.Console.WriteLine($"Binary resulting from logical OR {(binaryA | binaryB):b}");

        /* Logical/bitwise XOR */

        // The XOR operator works similarly to OR, with the difference that it will only return 1 when only one of its two inputs is 1.
        // Let's look at it in a table.
        // 0 ^ 0 = 0
        // 1 ^ 0 = 1
        // 0 ^ 1 = 1
        // 1 ^ 1 = 0

        System.Console.WriteLine($"Binary resulting from logical XOR {(binaryA | binaryB):b}");

        /* Shifts operators */
        // The shift operator, as its name suggests, allows bits to be shifted within a value.
        // These are divided into signed and unsigned, which in turn are divided into left and right.

        // For this examples we will use this variable:
        byte shiftLeftBinary = 0b001;
        byte rightShiftBinary = 0b100;

        System.Console.WriteLine($"Left shifted value {shiftLeftBinary << 1}; Binary value: {shiftLeftBinary << 1:b}");
        System.Console.WriteLine($"Left shifted value {shiftLeftBinary << 2}; Binary value: {shiftLeftBinary << 2:b}");

        System.Console.WriteLine($"Right shifted value {rightShiftBinary >> 1}; Binary value: {rightShiftBinary >> 1:b}");
        System.Console.WriteLine($"Right shifted value {rightShiftBinary >> 2}; Binary value: {rightShiftBinary >> 2:b}");

        // If you run the code, you may not understand what is happening here.

        // Let's take it step by step. First, we need to know how binary numbers work (if you already know how they work, skip this part. line 385).
        // Binary numbers are a representation of numbers that only contain two possible digits: 0 and 1.
        // So how do you convert a binary number to a decimal number?
        // In that case, we have to count the positions of the 1s.
        // You may be wondering, “What do you mean by that?”
        // Let's take the following numbers as an example:
        // - 1
        // - 10
        // - 101

        // The 1 has only one digit, and it is in position 1, so this is the representation of the common number 1.
        // The number 10 has two digits, so in this case we must add the positions occupied by the ones.
        // Think of each position as having a value, going from right to left.
        // Each position of a binary number contains a value that is double the previous value, so if the first is equal to one, the second is equal to two, the third to four, and so on.
        // So let's go back to the number 10.
        // As you can see, 10 contains a number 1 in position 2, and this position has a value of 2, so in binary, the number 2 is represented by the number 10.
        // And finally, 101.
        // 101 contains a 1 in the third and first positions.
        // As I said before, the value of each position is double that of the previous position.
        // So if the value of the second position is 2, the value of the third position will be 4.
        // Therefore, our sum would be 4 + 1, which would be 5.
        // So 101 is 5 in binary.

        // A more visual example:
        // 128 | 64 | 32 | 16 | 8 | 4 | 2 | 1  <- Value of position
        //  0  |  0 |  0 |  0 | 0 | 1 | 0 | 1  <- Our binary (101)
        // Result: 4 + 1 = 5

        // So, when we use the operators “<<” and “>>,” we are shifting all the bits to the left or to the right.
        // For example:
        // - 0101 << 1 becomes 1010.
        // - 0101 >> 1 becomes 0010 <- Since the starting number exceeds the limit, it is simply removed.

        /* Unsigned shift operator */
        // Like its counterpart “>>”, this operator shifts all bits in a binary to the right, but with one fundamental difference.

        sbyte usX = ~0b001; // -2

        System.Console.WriteLine($"{usX:b} {usX >> 1:b} {usX >> 1}");
        System.Console.WriteLine($"{usX:b} {usX >>> 1:b} {usX >>> 1}");

        // [NOTE] When using some of these operators, C# converts the result to int.
        // [NOTE] This is because bitwise operators are not overloaded for bytes or sbytes.

        // If you run this code, the console will display something like this:
        // 11111110 11111111111111111111111111111111 -1
        // 11111110 1111111111111111111111111111111 2147483647

        // Let's take it one step at a time.
        // The first results are the binary representation of our number (-2 in this case).
        // [NOTE] If you are curious about negative numbers in binary, you can read the [EXTRA] tag on line 64.

        // The second result is our number with one bit shifted to the right, and this is where the difference between the two operators lies.
        // The “>>” operator respects the sign of the number, so when shifting the bits to the right, it adds a 1 at the beginning to maintain the negative sign.
        // The “>>>” operator does not respect the signs of numbers, so when shifting the bits,
        // it will always add a 0 at the beginning, regardless of whether it is a negative number.

        // If you saw the console output, you might say, “But I don't see a 0 on the left.”
        // And yes, the problem is that C# (and several other languages) do not print the 0s on the left. 
        // If the 0s on the left were printed, the output would look something like this:
        // 11111110 11111111111111111111111111111111 -1
        // 11111110 01111111111111111111111111111111 2147483647

        /*----------------------*/
        /* Assignment operators */
        /*----------------------*/

        // You may ask yourself, “But why delve into these when you can just use the ‘=’ operator?”
        // Well, that's where you're wrong, dear reader.
        // Let's look at a case where I want to increase a number by 2 and then assign it to the same variable.
        // The following solutions may come to mind:

        int aoX = 2;

        aoX++;
        aoX++;

        // or

        aoX = aoX + 2;

        // Although both options are valid, they are not the most recommended.
        // The first one because what happens if now, instead of 2, I want to increase it by 20?
        // That's where the first one falls short, and the second one?
        // The second one is also fine, but it's better to use it when you want to store the result in another variable.
        // For example:

        // This is the best use
        int aoY = aoX + 2;

        // So how do you do it?
        // Well, that's what the “+=” operator is for.
        // This operator adds a value and then assigns the result to the variable.
        // Let's look at an example:

        // Instead of do this:
        aoX = aoX + 2;

        // Do this
        aoX += 2;

        // This is a cleaner way to do the same thing.
        // This same solution exists for all arithmetic operators.
        // Examples:
        aoX -= 2; // Substract
        aoX *= 4; // Multiplication
        aoX /= 2; // Division
        aoX %= 2; // Modulus 

        /* Bitwise Assignment operators */

        // Like arithmetic operators, bitwise operators have their assignment variant (except for the ~ operator).
        int baoX = 0b001;
        baoX <<= 1; // Duplicate his value
        baoX >>= 1; // Divide by 2
        baoX &= 0b010;
        baoX |= 0b001;

        // Now, you may be wondering, “But what good is it to use these operators?”
        // Imagine you are making a video game and want to represent a state of something in an efficient and lightweight way.
        // Well, for that, you can represent each state with a bit.
        // Let's look at an example:

        byte senkoStatus = 0b00000;

        byte coding = 0b10000;
        byte eating = 0b01000;
        byte cooking = 0b00100;
        byte working = 0b00010;
        byte sleeping = 0b00001;

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // In this example, each Senko state is represented by a specific bit.
        // In this case, Senko is not in any state.
        // Let's put Senko to sleep.
        // We can do this simply by adding 1, but this time we'll do it differently.

        // For this, we will use the “|=” operator.
        // This operator can be used to activate specific bits.
        // Let's look at an example:

        senkoStatus |= coding;

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // Now, Senko is coding.
        // If we want him to be coding and working, we can do the following:

        senkoStatus |= working;

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // If we run the program, we can see that Senko's states are working and rubbing shoulders, which can be translated as 10010.

        // Now we need Senko to go to sleep.

        senkoStatus |= sleeping;

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // But wait a minute, if you look at what the console says, you'll see that Senko's status is coding, working, and sleeping.
        // Which obviously doesn't make sense, so
        // How can we fix it???

        // To do that, we must first clear our state variable.
        // How do we do that?
        // Well, we can use the “&=” operator.

        senkoStatus &= 0b00000;

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // As you can see, Senko's status has returned to its default value, so we can now assign the status “Sleeping” without any problems.

        senkoStatus |= sleeping;

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // But what if I don't want to reset the statuses to 0?
        // For example, if I have the statuses “Working” and ‘Coding’ but I only want to remove the “Working” status?
        // Should I clear everything?

        senkoStatus &= 0b00000; // Reset
        senkoStatus |= coding; // Set coding
        senkoStatus |= working; // Set working

        // That's an excellent question.
        // And the answer is no.
        // For that, we can use the “&=” operator as follows:

        senkoStatus &= (byte)~working; // Cast to byte, the reason is explaned in the lines 408 and 409

        // Let's take this step by step:
        // senkoStatus -> 10010
        // Working -> 00010
        // What we are doing here is using the NOT operator (~) to reverse the value of “working.”
        // So this becomes:
        // ~Working -> 11101;
        // So when performing the AND (&) operation, the only active value that will be deactivated will be “working.”
        // senkoStatus -> 10010
        //       &             
        // ~Working    -> 11101
        // result      -> 10000

        // If we print the current status, you will see that the “Working” status has been correctly deactivated.
        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // But what if we now want to move from the “coding” state to the “working” state?
        // We can turn off the “Coding” status as we did before with “Working” and turn on ‘Working’ with “|=”
        // Well, of course you can do that, but for that we can use “>>=”
        // The shift operators will help us move between statuses (as long as there is an active one).

        senkoStatus >>= 1; // Set to working

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        senkoStatus <<= 1; // Set to coding

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        senkoStatus >>= 4; // Set to sleeping

        System.Console.WriteLine($"Current Senko status: {senkoStatus:b}");

        // Now that you understand this, my dear reader,
        // it's your turn to try it out. Create new states and play around with the operators.
        // You don't have to do it, but it might help you understand them better.
    }

    /// <summary>
    /// This module provides a comprehensive guide to C# operators, expanding on the concepts from the instagram post "Operators && Conditionals part 1" uploaded on September 19, 2023.
    /// The conditionals part is not included in this module.
    /// It covers the following categories:
    /// <list type="bullet">
    ///     <item><description>Arithmetic Operators (Addition, Subtraction, Multiplication, Division, Modulus)</description></item>
    ///     <item><description>Logical Operators (AND, OR, NOT)</description></item>
    ///     <item><description>Comparative Operators (Equality, Relational)</description></item>
    ///     <item><description>Bitwise Operators (NOT, AND, OR, XOR, Shifts)</description></item>
    ///     <item><description>Assignment and Bitwise Assignment Operators</description></item>
    /// </list>
    /// Includes practical examples and detailed explanations for each operator type.
    /// </summary>
    public Operators()
    {
        ModuleName("Operators");
        IsSubModule(true);
        Execute();
    }
}
