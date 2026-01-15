using System;

namespace CodeWithSenko.Module.BasicConcepts;

/// <summary>
/// Contains the content of the first CodeWithSenko posts, covering the following topics:
/// <list type="bullet">
///     <item><description>Print in Console</description></item>
///     <item><description>Data Types</description></item>
///     <item><description>Operators &amp; Conditionals (Part 1 &amp; Part 2)</description></item>
///     <item><description>Read From Console</description></item>
///     <item><description>Loops (Part 1 &amp; Part 2)</description></item>
///     <item><description>Guess the Number</description></item>
///     <item><description>Methods (Part 1 &amp; Part 2)</description></item>
/// </list>
/// </summary>
public partial class BasicConcepts : Module
{
    protected override void ModuleBody()
    {
        new PrintInConsole();
        new DataTypes();
        new Strings();
        new Operators();
    }

    public BasicConcepts()
    {
        ModuleName("Basic Concepts");
        Execute();
    }
}
