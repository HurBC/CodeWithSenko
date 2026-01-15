using System;

namespace CodeWithSenko.Module;

public abstract class Module
{
    protected abstract void ModuleBody();

    protected void ModuleName(String name)
    {
        _name = name;
    }

    protected void IsSubModule(bool isSubModule)
    {
        _isSubModule = isSubModule;
    }

    public void Execute()
    {
        String moduleName = _name + " Module";

        String separator = _isSubModule ? "" : $"/{new String('*', moduleName.Length + 4)}/";

        Console.WriteLine(separator);
        Console.WriteLine($"/* {_name ?? ""} Module */");
        Console.WriteLine(separator);

        ModuleBody();
    }

    String? _name;
    bool _isSubModule = false;
}
