using System;
using System.Linq;
using System.Reflection;

namespace AttributesDll
{
    [Information("This is class with attr")]
    public class ClassWithAttrib
    {
        [Information("privateIntProp")]
        private int privateIntProp { get; set; }
        [Information("publicIntProp")]
        [Information("OneMoreAttrForProp")]
        public int publicIntProp { get; set; }

        //[Information("privateIntField")]  // Can't assign attribute
        private int privateIntField;
        
        public int publicIntField;

        //[Information("publicIntProp")]  // Can't assign attribute
        private void privateMethod() { }

        public void publicMethod() { }

        public static void PrintPrivateMethods()
        {
            foreach (var meth in typeof(ClassWithAttrib).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
                Console.WriteLine(meth);
            
        }
        public static void PrintDeclaredMembers()
        {
            foreach (var member in typeof(ClassWithAttrib).GetMembers(BindingFlags.Instance 
                                                                    |BindingFlags.NonPublic 
                                                                    |BindingFlags.Public 
                                                                    |BindingFlags.DeclaredOnly
                                                                    |BindingFlags.Static))
                Console.WriteLine(member);

        }
    }
}
