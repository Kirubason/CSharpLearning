using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class YieldKeyword
    {
        public IEnumerable<int> YieldMethod(int a)
        {
            for(int i=0;i<a;i++)
            {
                yield return i;
                Console.WriteLine("Print");
            }
        }

        public void YieldMethodMain()
        {
            IEnumerable<int> Data = YieldMethod(10);
            foreach(int a in Data)
            {
                Console.WriteLine(a);
            }
            
        }
    }
}
