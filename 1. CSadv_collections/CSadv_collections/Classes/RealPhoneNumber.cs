using System;
using System.Collections.Generic;
using System.Text;
using CSadv_collections.Interfaces;

namespace CSadv_collections.Classes
{
    class RealPhoneNumber : IPhoneNumber
    {
        public RealPhoneNumber(string countryCode, int localCode, int number)
        {
            CountryCode = countryCode;
            LocalCode = localCode;
            Number = number;
        }
        public string CountryCode { get; }
        public int LocalCode { get; }
        public int Number { get; }

        public override string ToString()
        {
            return $"{CountryCode}({LocalCode}){Number}";
        }
    }
}
