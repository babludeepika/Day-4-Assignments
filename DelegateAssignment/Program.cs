using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
   
    class Program
    {
        public delegate void Print(int n);
        static void Main(string[] args)
        {
            Printable p = new Printable();
            Print p1 = p.PrintNumber;
            p1 += p.PrintMoney;
            p1 += p.PrintHexaDecimal;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            p1(num);



        }
    }
}
