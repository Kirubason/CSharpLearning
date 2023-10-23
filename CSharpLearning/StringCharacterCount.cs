using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class StringCharacterCount
    {
        public void StringCharacterCountMethod()
        {
            string str= "Please count occurence of each alphabet in given string zzzzzzzz".ToUpper();
            Dictionary<char, int> CharacterOccurence = new Dictionary<char, int>();
            foreach(char chr in str)
            {
                if(chr != ' ')
                {
                    if (!CharacterOccurence.ContainsKey(chr))
                    {
                        CharacterOccurence.Add(chr, 1);
                    }
                    else
                    {
                        CharacterOccurence[chr]++;
                    }
                }
            }
            
        }
    }
}
