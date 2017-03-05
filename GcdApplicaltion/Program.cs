using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcdApplicaltion
{
    class Program
    {
        static int Main(string[] args)
        {
            int fristNumber, secondNumber;
            Console.Write("Enter the First Number : ");
            fristNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            GcdOperationManager gcdOperationManagerObject = new GcdOperationManager();
            Console.Write("\nThe Greatest Common Divisor of ");
            Console.WriteLine("{0} and {1} is {2}", fristNumber, secondNumber, gcdOperationManagerObject.GCDLogic(fristNumber, secondNumber));
            Console.WriteLine("Thankyou\nPress any key to exit the application");
            Console.ReadLine();
            return 0;
        }
    }
}

