using System;
using System.Collections.Generic;
using System.Text;
using CSadv_collections.Interfaces;

namespace CSadv_collections.Classes
{
    class FakePhoneNumber : IPhoneNumber
    {
        public FakePhoneNumber(string howToCall)
        {
            HowToCall = howToCall;
        }

        private string HowToCall { get; }

        public override string ToString()
        {
            return $"{HowToCall}";
        }
    }
}
