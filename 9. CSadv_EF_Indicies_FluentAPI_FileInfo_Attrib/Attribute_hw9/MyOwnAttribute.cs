using System;

namespace Attribute_hw9
{
    [AttributeUsage(AttributeTargets.Method)]
    class MyOwnAttribute : Attribute
    {
        private string MoreInfo;
        public int LegalAge { get; set; }

        public MyOwnAttribute(string moreInfo)
        {
            MoreInfo = moreInfo;
        }
    }
}
