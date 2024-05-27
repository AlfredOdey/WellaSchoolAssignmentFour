using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   /*
   Create an abstract class 'Bank' with an abstract method 'getBalance'.
   $100, $150 and $200 are deposited in banks A, B and C respectively.
   'BankA', 'BankB' and 'BankC' are subclasses of class 'Bank',
   each having a method named 'getBalance'.
   Call this method by creating an object of each of the three classes.
   */

namespace WellaSchoolAssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bankA = new BankA();
            Console.WriteLine(bankA.Name);
            Console.WriteLine($"Amount deposited: ${bankA.getBalance()}");

            Console.WriteLine();

            Bank bankB = new BankB();
            Console.WriteLine(bankB.Name);
            Console.WriteLine($"Amount deposited: ${bankB.getBalance()}");

            Console.WriteLine();

            Bank bankC = new BankC();
            Console.WriteLine(bankC.Name);
            Console.WriteLine($"Amount deposited: ${bankC.getBalance()}");

            Console.WriteLine();
        }
    }
}
