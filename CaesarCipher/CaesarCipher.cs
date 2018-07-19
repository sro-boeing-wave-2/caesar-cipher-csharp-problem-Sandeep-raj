using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string encrypt = "";
            //throw new NotImplementedException("You need to implement this function.");
            Regex regex = new Regex("[A-Za-z]");
            foreach(Char t in text)
            {
                if (regex.Match(t.ToString()).Success)
                {
                    char Start_Alpha = char.IsUpper(t) ? 'A' : 'a';
                    encrypt += (char)((((t + shiftKey) - Start_Alpha) % 26) + Start_Alpha);
                }
                else
                    encrypt += t;
            }
            return encrypt;
        }
    }
}
