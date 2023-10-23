using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class ReverseString
    {
        public void ReverseWholeSentense()
        {
            string str = "Hello Welocome to Micah Tech";
            char[] chr = str.ToCharArray();
            string FinalString = string.Empty;
            for(int i = chr.Length-1;i>=0;i--)
            {
                FinalString = FinalString + chr[i];
            }
        }
        public void ReverseEachWordInSentense()
        {
            string str = "Hello Welocome to Micah Tech";  
            string[] strArray = str.Split(' ');
            string FinalString = string.Empty;
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                FinalString = FinalString + strArray[i];
                if(i>0)
                {
                    FinalString = FinalString + " ";
                }
            }
        }

        public void ReverseEachWordCharacterInSentense()
        {
            string str = "Hello Welocome to Micah Tech";
            string[] strArray = str.Split(' ');
            string FinalString = string.Empty;
            for (int i = 0; i <= strArray.Length - 1; i++)
            {
                char[] temp = strArray[i].ToCharArray();
                string WordReverse = string.Empty;
                for (int j = temp.Length - 1; j >= 0; j--)
                {
                    WordReverse = WordReverse + temp[j];
                }
                FinalString = FinalString + WordReverse;
                if (i < strArray.Length)
                {
                    FinalString = FinalString + " ";
                }
            }
        }
    }
}
