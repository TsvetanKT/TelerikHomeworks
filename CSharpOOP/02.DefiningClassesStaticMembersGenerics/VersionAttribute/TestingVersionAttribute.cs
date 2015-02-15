using System;

[VersionAttribute("3.14")]
class Program
{
    //11.Create a [Version] attribute that can be applied to structures, classes, interfaces, 
    //   enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
    //   Apply the version attribute to a sample class and display its version at runtime.
    static void Main()
    {
        object[] versionAttributes = typeof(Program).GetCustomAttributes(typeof(VersionAttribute), false);

        Console.WriteLine("Version: {0}", versionAttributes[0]);
    }
}