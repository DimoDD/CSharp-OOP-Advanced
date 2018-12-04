using System;
using System.Collections.Generic;
using System.Text;
using Problem4Telephony.Interfaces;
using System.Linq;

namespace Problem4Telephony
{
    public class Smartphone : ICaller, IBrowser
    {
        public string Browse(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }
    }
}
