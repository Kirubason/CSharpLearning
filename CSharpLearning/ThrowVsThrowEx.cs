using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    public class ThrowVsThrowEx
    {
        public void ThrowMethod()
        {
            try
            {
                Funtion1();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void Funtion1()
        {
            try
            {
                Funtion2();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void Funtion2()
        {
            throw new Exception("Example for Throw, which maintain complete error history of stack trace");
        }

        public void ThrowExMethod()
        {
            try
            {
                Funtion3();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void Funtion3()
        {
            try
            {
                Funtion4();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void Funtion4()
        {
            throw new Exception("Example for Throw Ex, which reset error history of stack trace");
        }
    }
}
