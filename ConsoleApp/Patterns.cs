using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /*
    *  The patterns only work to website StatusInvest
    */
    public static class Patterns
    {
        public static string GetPatternCompanyCNPJ()
        {
            return @"([0-9]{2}[\.][0-9]{3}[\.][0-9]{3}[\/][0-9]{4}[-][0-9]{2})";
        }
    }
}
