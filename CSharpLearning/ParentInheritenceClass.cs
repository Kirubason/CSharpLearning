using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class ParentInheritenceClass
    {
        public ParentInheritenceClass()
        {
            Console.WriteLine("Parent- Constructor");
        }
        public virtual void BankName()
        {
            Console.WriteLine("Default bank");

        }
    }

    public class ChildInheritenceClass : ParentInheritenceClass
    {
        public ChildInheritenceClass()
        {
            Console.WriteLine(" Chile- Constructor");
        }
        public override void BankName()
        {
            Console.WriteLine("Commonwealth Bank");

        }
    }
}
