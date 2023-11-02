using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class LinQExample
    {
        public void LinQMethod()
        {
            int[] ArrayInt = new int[] { 1, 2, 6, 4, 2, 9, 6, 5, 0 };
            IEnumerable<int> ArrayIntLinq = from i in ArrayInt where i>5 select i;
        }

        public void LinQMethodLmbda()
        {
            List<int> ListInt = new List<int>{ 1, 2, 6, 4, 2, 9, 6, 5, 0 };
            ListInt = ListInt.FindAll(x => x % 2 == 0);
            IEnumerable<int> ListInt1 = from i in ListInt where i > 5 select i;
        }
    }
}
