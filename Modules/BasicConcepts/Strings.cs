using System;

namespace CodeWithSenko.Module.BasicConcepts;

/// <summary>
/// This method contains a more detailed version of the posts:
/// <list type="table">
///     <item>
///         <term>Data Types</term>
///         <description>September 16, 2023</description>
///     </item>
///     <item>
///         <term>The Truth Behind Strings</term>
///         <description>November 13, 2023</description>
///     </item>
///     <item>
///         <term>Strings 2</term>
///         <description>November 15, 2023</description>
///     </item>
/// </list>
/// </summary>
/// <remarks>
/// <strong>Topics covered:</strong>
/// <list type="bullet">
///     <item><description>Definition and nature of Strings.</description></item>
///     <item><description>Attributes and Methods.</description></item>
///     <item><description>Concatenation and Interpolation techniques.</description></item>
///     <item><description>Formatting and Composite Formatting.</description></item>
/// </list>
/// </remarks>
public class Strings : Module
{
    protected override void ModuleBody()
    {
        /*---------*/
        /* Strings */
        /*---------*/

        // What are Strings???
        // Well, strings are a data structure that allows you to store a list of characters inside them.
        // You may be wondering, “I thought strings were primitive types?”

        // That's a good question.

        // Well, strings currently appear to be primitive because C# and other languages allow us to use them in a simple way, but technically they are not primitive data types.
        // This is because a variable can only store one value, for example:
        // - A number (ints or floats/doubles/decimals)
        // - True or false (booleans)
        // - Characters (chars)

        // All of these are only one value, but what about a string?
        // As I mentioned, strings do not contain a single value. You might say, “But it only stores text,” and that's where the confusion lies.
        // A text is made up of a number n of characters.

        // In the case of C#, strings are instances of the class with the same name. This class contains dozens of methods, some attributes, and even constructors.
        // The difference is that C# simplifies the process when creating a string.

        // Using the string reserved word
        string myName = "Senko San";

        // Using String class contructor
        String myEmployeeName = new String("Ellen Joe");

        Console.WriteLine("My name is " + myName);
        Console.WriteLine("My employee name is " + myEmployeeName);

        // [IMPORTANT] The following content is not part of the strings; you do not need to read it if you do not want to.
        // An interesting fact is that in older languages such as C or Assembly, strings do not exist. 
        // In C, for example, character arrays (char[]) are used.
        // [END OF IMPORTANT]

        // Once we know what Strings are, we can move on to their methods and attributes.

        /*-----------------------*/
        /* Attributes of Strings */
        /*-----------------------*/

        // Strings have two attributes: their length and an index.
        // To access these, we must use the name of the variable that contains our string, followed by a period and the name of the attribute.
        // For example:

        String employeeLog = "Employee 003: Senko San from CodeWithSenko account";

        // In C#, whenever you call the Length getters, you must use the value that is returned.
        // This is because C# considers that by not doing anything with the Length value, you are performing a useless calculation and asks you to either do something with it or not use it at all.
        // If you do not use it, it will give a compilation error.
        int logLength = employeeLog.Length;

        // employeeLog.Length;

        Console.WriteLine("Log to analize: " + employeeLog);
        Console.WriteLine("Log length: " + logLength);

        // The other attribute of Strings is the index, which allows us to obtain a character from its position in the String.

        // What do I mean by this?
        // Let's look at the previous example.
        // Previously, we declared the variable “logLength,” which tells us the length of our string. 
        // Therefore, the index will not return the character found in the position we provided.

        // Something to keep in mind is that the position of characters always starts at 0. 
        // What do I mean by this?
        // I mean that if we want to get the first character of the string, we must do the following:

        // If you run this code, you should see that it returned the character ‘E’, because that is the character found at position 0 of the string, or at the beginning of the string.
        Console.WriteLine("First character in the log: " + employeeLog[0]);

        // But what if I want to get a character from the middle?

        // Well, there are two ways to do that.
        // You can count the positions of each character until you reach the desired one, or use a method from the String class.

        /*--------------------*/
        /* Methods of Strings */
        /*--------------------*/

        // Strings contain approximately 145 methods (maybe even more), of which you will not use many in your day-to-day work, except for a few.

        /* IndexOf */

        // The IndexOf method searches for the pattern that matches what was provided as an argument and returns the index of the first occurrence.
        // If no value matching the search value is found, the method will return -1.

        // If you recall the previous exercise, we asked ourselves how we can obtain the index of the character we want to find.
        // Well, the IndexOf method helps us with that tedious task.

        int indexOfTheFirstS = employeeLog.IndexOf('S');

        Console.WriteLine("The index of the 'S' is: " + indexOfTheFirstS);

        // As seen in the previous example, the method returned index number 14, which represents the position within the string for the first character ‘S’.
        // But what if I wanted to find the position of the second letter ‘S’?

        // Well, that's what method overloading is for.
        // Overloading, in short, is like different variants of the same method, which can receive different parameters, but we'll talk about it in more detail in the Methods module.

        // In this case, the IndexOf method contains 11 overloads.
        // One of them is the one that contains the signature: IndexOf(char value)

        // This same method has an overload that receives a char and a starting index as arguments.
        // This is the one that contains the signature: IndexOf(char value, int startIndex)
        // This overload allows us to start the search from a predefined index, so instead of starting from index 0, it will start from the index we specify.

        int indexOfTheSecondS = employeeLog.IndexOf('S', indexOfTheFirstS + 1);

        Console.WriteLine("The index of the second 'S' is: " + indexOfTheSecondS);

        // As you can see, in the previous example, it returned the index of the next ‘S’ after the index of the first ‘S’, which is 20.

        // Now, how could I search for the index of the second word “Senko” within the string in "CodeWithSenko"?
        // This time, I'll leave that task to you, dear reader.
        // Your code:
        int indexOfEmployee003Name = 0;

        /* SubString */

        // Imagine that I now want to extract the name of employee 003 from the previous log. How could I do that?
        // The SubString method allows us to extract a section of a String through its index.
        // Well, for that there is the SubString method, which allows you to extract the content of a String from an index.

        // For this, we will use the previous examples.

        String employee003Name = employeeLog.Substring(indexOfTheFirstS);

        Console.WriteLine("SubString results: " + employee003Name);

        // Don't forget execute the program :D

        // As you can see, the new String contains the main text, but this is not what we are looking for.
        // Fortunately, like IndexOf, SubString also has overloads, with the difference that SubString only has two.
        // We have already seen the first overload.
        // The second overload has the signature: Substring(int startIndex, int length), which allows us to determine the length of our new String extract.

        // So how can we obtain the text “Senko”?
        // One solution would be to count how many letters the word “Senko” has, which is a valid option.

        employee003Name = employeeLog.Substring(indexOfTheFirstS, 5);

        Console.WriteLine("The limited SubString result is: " + employee003Name);

        // Although the previous solution is functional, there are better ways to do it, such as the following:

        int indexOfTheEndOfName = employeeLog.IndexOf(' ', indexOfTheFirstS);

        employee003Name = employeeLog.Substring(indexOfTheFirstS, indexOfTheEndOfName - indexOfTheFirstS);

        Console.WriteLine("The limited SubString result is (Only with IndexOf): " + employee003Name);

        // Now the expected result is “Senko,” so we have achieved the objective.

        // Now, to put what we have seen so far into practice, extract the complete name of employee 004 from the following text:

        String employeeLog2 = "Employee 004: Ellen Joe from NO_DATA_FOR_NEW_EMPLOYEES";

        // To do this, you must only use the methods we have seen so far.
        // Your code:

        String employee004Name = "_";

        /*--------------------*/
        /* ToUpper && ToLower */
        /*--------------------*/

        // The ToUpper and ToLower methods do something similar, modifying the content of the string.
        // ToUpper capitalizes everything, and ToLower lowercases everything.

        // Both methods have three overloads, of which we will only look at the main one.

        String logBeforeTheAccident = "At 3:30 p.m., an intruder is seen in the parking lot near the CEO's car.";
        String logAfterTheAccident = "At 7:44 p.m., behind the bushes, a silhouette can be seen watching the CEO while waiting for the ambulance.";

        Console.WriteLine("log in lowercase" + logBeforeTheAccident.ToLower());
        Console.WriteLine("LOG IN UPPERCASE" + logAfterTheAccident.ToUpper());

        /*----------*/
        /* Contains */
        /*----------*/

        // The Contains method verifies that a String or char is present within the main String and then returns a boolean.
        // This method has six variants, of which we will only look at two.
        // - Contains(string value)
        // - Contains(char value)

        Console.WriteLine("The log contains \"Intruder\"? " + logBeforeTheAccident.Contains("intruder"));
        Console.WriteLine("The log contains 'z'? " + logAfterTheAccident.Contains('z'));

        /*---------*/
        /* Replace */
        /*---------*/

        // Replace is a method that replaces one value with another.
        // This method has four variants, of which we will only look at two:
        // - Replace(char oldChar, char newChar)
        // - Replace(string oldValue, string? newValue)

        logBeforeTheAccident.Replace("intruder", "Employee 00#");
        logAfterTheAccident.Replace("silhouette", "2");

        Console.WriteLine("Log after Replace: " + logBeforeTheAccident);
        Console.WriteLine("Log after Replace: " + logAfterTheAccident);

        // If you run this code, you may notice something in the replace logs, but what could it be?
        // How could you make it output the correct result?

        /*---------------*/
        /* Concatenation */
        /*---------------*/

        // Before we begin, I have a question: were you able to find out why the previous text was not modified?
        // If you did, congratulations! If not, I hope that in this section you will be able to understand why.

        // What is string concatenation?
        // String concatenation is a way to combine two strings into a new one.
        // This is achieved using the “+” operator or the Concat method of Strings.

        // This allows us to generate new strings based on new or old information, and in turn is not limited to strings alone.
        String employee003Testimony = "The Ms. " + employee003Name + " says she was with his coworker all day in the cafeteria during the incident at 3:30 p.m.";

        employee003Testimony = employee003Testimony + "She also says that she ordered " + 2 + " cups of coffee with employee 004.";

        Console.WriteLine(employee003Testimony);

        // You may think that in the previous example, the value of “employee003Testimony” is being modified to add the new content.
        // But is that really what is happening?

        // In C#, strings are immutable data types, but what does that mean?
        // When a data type is said to be immutable, it means that its values cannot be modified at runtime under any circumstances.
        // Therefore, whenever we modify a string, we are not modifying the actual string, but rather creating a new one from scratch.

        // But why do that?

        // Imagine you have the path of a file saved in a String, something like this:
        String employeesDir = "C:\\documents\\employees\\002";

        // If you modify that string somewhere, the original path could be lost without anyone noticing
        // so it is better to create a new instance of this string that contains the new changes.

        // Furthermore, being designed this way allows C# to optimize memory better.
        // But of course, if you have a String that changes 1000 times...
        // You will create 1000 different instances of a String, especially if they are all different.

        /* Concat method */
        // The Concat method is a method of the String class that allows you to concatenate several Strings into a new String.
        // This method has 15 different variants, but for now we will focus on its most common use, which is not very common in itself.

        String employee004Testimony = String.Concat("Ms ", employee004Name, " confirms the story told by the lady interviewed earlier.");

        employee004Testimony = String.Concat(employee004Testimony, " The interviewee said that one of her coworkers was absent that day, namely employee 000010.");

        Console.WriteLine(employee004Testimony);

        /*---------------*/
        /* Interpolation */
        /*---------------*/

        // What is string interpolation?
        // String interpolation, like concatenation, allows us to combine values into a string or join several strings into one in a more readable way.
        // This is achieved by using curly brackets “{}” with which we can place anything from variable names to complete expressions.
        // In addition to the curly brackets “{}” at the beginning of the string, the “$” character must be included. This will allow us to interpolate the strings.

        String employee001 = "Freddy Fazbear";

        String employeesList = $"001: {employee001} - 002: P0##! - 003: {employee003Name} - 004 {employee004Name}";

        Console.WriteLine(employeesList);

        /*------------*/
        /* Formatting */
        /*------------*/

        // String formatting is a method that allows you to format a base string and inject values into it based on their positions in the list. 
        // Unlike concatenation or interpolation, string formatting can only be done using the Format method of the String class or the WriteLine method.
        // How does it work?
        // This method is a little more complex to understand, so let's take it step by step.

        // The Format method contains 15 different variants. For this occasion, I will discuss the most common one.

        // The Format method receives the base string as its first argument, which will be the string into which the new values will be injected.
        // At the moment, all of that is normal.
        // But... How do I inject the values?

        // Well, first of all, after passing the first argument to the method (the base string)
        // the values to be injected must be added as the rest of the method's arguments, and each one will be represented by an index within the string.

        String plaze = "The park";
        String hour = "09:26 p.m.";

        String suspect = "Pomni";

        // As you can see, values are represented by the position they use as an argument. 
        // This can be very helpful, especially when the same value is repeated multiple times in a string.
        String logbook = String.Format(
                "Two days after the {0} accident, temporary CEO {2} can be seen walking alone in {1} a the {3}",
                employee001,
                plaze,
                suspect,
                hour
            );

        String operationName = "Sad Clown";

        logbook = String.Format("{0}\nAfter about 10 minutes, the {1} operation began.", logbook, operationName);

        Console.WriteLine(logbook);
        Console.WriteLine("END...");

        _objects = [indexOfEmployee003Name, employeeLog2, employeesDir];

    }

    /// <summary>
    /// This method contains a more detailed version of the posts:
    /// <list type="table">
    ///     <item>
    ///         <term>Data Types</term>
    ///         <description>September 16, 2023</description>
    ///     </item>
    ///     <item>
    ///         <term>The Truth Behind Strings</term>
    ///         <description>November 13, 2023</description>
    ///     </item>
    ///     <item>
    ///         <term>Strings 2</term>
    ///         <description>November 15, 2023</description>
    ///     </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <strong>Topics covered:</strong>
    /// <list type="bullet">
    ///     <item><description>Definition and nature of Strings.</description></item>
    ///     <item><description>Attributes and Methods.</description></item>
    ///     <item><description>Concatenation and Interpolation techniques.</description></item>
    ///     <item><description>Formatting and Composite Formatting.</description></item>
    /// </list>
    /// </remarks>
    public Strings()
    {
        ModuleName("Strings");
        IsSubModule(true);
        Execute();
    }

    private object[] _objects = [];
}
