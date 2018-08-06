using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    class Printable
    {
        public void PrintNumber(int number)
        {
            Console.WriteLine(String.Format("Output Format For number is: {0:n0}", number));
        }
        public void PrintMoney(int number)
        {
            Console.WriteLine(String.Format("Output Format For currency  is: {0:c0}", number));
        }
        public void PrintHexaDecimal(int number)
        {
            Console.WriteLine(String.Format("Output Format For Hexadecimal  is: {0:X}", number));
        }
    }
}
