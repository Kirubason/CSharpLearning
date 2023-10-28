using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class GenericsExample<T>
    {
        public void GenericMethod<T>(T Param1, T Param2)
        {
            bool IsEqual = false;
            IsEqual = Param1.Equals(Param2);
        }
    }
}
