using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert space before each capital letter in a string
        /// </summary>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if(!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if(char.IsUpper(letter))
                    {
                        // Trim any space already there
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result;
        }
    }
}
