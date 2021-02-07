using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_anonType
{
    class PersonDescription
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StoryName { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName}, LastName: {LastName}, StoryName: {StoryName}";
        }
    }
}
