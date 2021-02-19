using System;

namespace AttributesDll
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class InformationAttribute : Attribute
    {
        private string Info { get; set; }
        public InformationAttribute(string info)
        {
            Info = info;
        }
    }
}
