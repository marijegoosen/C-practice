using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrabler
{
    public class ChallengeInlineArray
    {
        public static string Inline(string[] arrayOfStrings)
        {
            arrayOfStrings = new string[] { "here is some text", "here is some more text", "then some more text" };
            string result = "";

            foreach (string text in arrayOfStrings)
            {
                result = result + text;
            }

            return result;
        }
    }
}
