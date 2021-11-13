using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace PizzeriaApp
{
    class Manager
    {
        public static Frame StartFrame { get; set; }
        public static double sum;
        public static bool promocode;
        public static bool review;
        static public bool ValidFound(string str,string input)
        {
            bool valid = true;
            foreach(char c in str)
            {
                string bfr = c.ToString();
                if (Regex.IsMatch(bfr,input))
                {
                    valid = true;
                }
                else
                { valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
