using System;
using System.Reflection;

namespace AssemblyDll
{
    public class AssemblyLoad
    {
        var assembly = Assembly.GetAssembly(typeof(InformationAttribute));
        var a = (ClassWithAttrib)assembly.CreateInstance(assembly.GetTypes()[0].ToString());
    }
}
