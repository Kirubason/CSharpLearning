using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class ConstantReadOnlyStatic
    {
        const double pi = 3.14;
        readonly double phi;

        static double phis;
        public ConstantReadOnlyStatic(int a)
        {
            phi = a;
        }

        public ConstantReadOnlyStatic()
        {
            phis++;
            Console.WriteLine(phis);
        }

        public void ConstantReadOnlyStaticMethod()
        {
            Console.WriteLine(pi);
            Console.WriteLine(phi);
        }
    }
}
