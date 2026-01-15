using System;

namespace CodeWithSenko.Module.BasicConcepts;

/// <summary>
/// This class contains a more detailed version of the post “Print in console” uploaded on September 16, 2023.
/// <list type="bullet">
///     <listheader>
///         <term>Content</term>
///         <description>Topics covered in this post:</description>
///     </listheader>
///     <item>
///         <description>Method <see cref="Console.WriteLine()"/></description>
///     </item>
///     <item>
///         <description>Method <see cref="Console.Write()"/></description>
///     </item>
/// </list>
/// </summary>
public class PrintInConsole : Module
{
    protected override void ModuleBody()
    {
        /*
            In C#, to write to the console, we use the Console class, which is included in the System namespace.
            We also need to use the WriteLine method, which allows us to print text or other values to the console.
            This method displays the content we provide and then inserts a line break.
        */

        Console.WriteLine("Senko Says: \"HELLO WORLD!!!!\"");
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
        Console.WriteLine("This sentence is " + true);

        // But what if I don't want a line break?
        // For example, what if I want to print “12345” only with numbers?
        // You might think we could simply add the + or perhaps separate them with a “,”

        // But this will print 15
        Console.WriteLine(1 + 2 + 3 + 4 + 5);
        // And this will cause a compilation error
        // Console.WriteLine(1, 2, 3, 4, 5);

        // One solution could be the following:
        Console.WriteLine("" + 1 + 2 + 3 + 4 + 5);

        // This works, but it relies on string concatenation, not pure numeric output

        // Well, for that we can use the Write method of the same Console class
        // Unlike WriteLine, this will print the content without a line break
        Console.Write(1);
        Console.Write(2);
        Console.Write(3);
        Console.Write(4);
        Console.Write(5);
        Console.Write('\n');
    }

    /// <summary>
    /// This class contains a more detailed version of the post “Print in console” uploaded on September 16, 2023.
    /// <list type="bullet">
    ///     <listheader>
    ///         <term>Content</term>
    ///         <description>Topics covered in this post:</description>
    ///     </listheader>
    ///     <item>
    ///         <description>Method <see cref="Console.WriteLine()"/></description>
    ///     </item>
    ///     <item>
    ///         <description>Method <see cref="Console.Write()"/></description>
    ///     </item>
    /// </list>
    /// </summary>
    public PrintInConsole()
    {
        ModuleName("Print In Console");
        IsSubModule(true);
        Execute();
    }
}
