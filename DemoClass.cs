using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class DemoClass
    {
        public void DividedbyZero()
        {
            Console.WriteLine("Divide your number by zero - ");
            Console.Write("Enter a number: ");
            int _result = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ouput = _result / 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I divided your number by zero");
            }
        }

        public void IOutBException()
        {
            int[] _result = new int[3] {1, 3, 5};

            foreach (int i in _result)
            {

            }

            Console.WriteLine("I want to add your number to this array - ");
            Console.Write("Enter a number: ");
            int _result = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ouput = _result / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I divided your number by zero");
            }
        }

    }
}
