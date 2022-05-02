using System;
using System.Threading.Tasks;

namespace Exceptions
{
    class DemoClass
    {
        // First Exception
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
                Console.WriteLine("The exception is " + ex.Message);
            }
            finally
            {
                Console.WriteLine("I divided your number by zero");
            }
        }
        
        // Second Exception
        public void IOutBException()
        {
            int[] _result = new int[] {1, 3, 5};

            Console.WriteLine("An array: ");
            foreach (int i in _result)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("I want to add your number to this array - ");
            Console.Write("Enter a number: ");
            int mynumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                _result[3] = mynumber;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The exception is " + ex.Message);
            }
            finally
            {
                Console.WriteLine("I can't add your number to the array");
            }
        }

        // Exception 3
        public void InvalidCasException()
        {
            object _result;

            Console.WriteLine("I want to add your number to this array - ");
            Console.Write("Enter a number: ");
            int mynumber = Convert.ToInt32(Console.ReadLine());
            _result = mynumber;
            try
            {
                int num = (short)_result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The exception is " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally...");
                Console.WriteLine("i can't cast your number");
            }
        }

        public void DataSub()
        {
            Console.Write("Enter your data balance: ");
            int dataBalance = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (dataBalance < 100)
                {
                    throw (new LowUserDefinedException1("Data low!"));
                }
                else if(dataBalance > 100 && dataBalance < 200)
                {
                    throw (new LowUserDefinedException2("Data is between 100 and 200"));
                }
                else
                {
                    throw (new LowUserDefinedException3("Data is high"));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Is your data balance above 100?");
            }
        }
    }


    // User defined exceptions
    class LowUserDefinedException1 : Exception
        {
            public LowUserDefinedException1(string message) : base(message)
            {
                
            }
        }

    class LowUserDefinedException2 : Exception
    {
        public LowUserDefinedException2(string message) : base(message)
        {

        }
    }

    class LowUserDefinedException3 : Exception
    {
        public LowUserDefinedException3(string message) : base(message)
        {

        }
    }
}

