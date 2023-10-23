using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class PalindromeCheck
    {
        public void PalindromeCheckMethod()
        {
            string str = "amma";
            char[] chr = str.ToCharArray();
            string FinalString = string.Empty;
            for (int i = chr.Length - 1; i >= 0; i--)
            {
                FinalString = FinalString + chr[i];
            }
            if(str==FinalString)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }

        public void PalindromeCheckMethod2()
        {
            string str = "ayyyya";
            bool check = false;
            for(int i = 0,j = str.Length - 1; i <= str.Length/2; i++,j--)
            {
                if(str[i] != str[j])
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            if (check)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }
    }
}
