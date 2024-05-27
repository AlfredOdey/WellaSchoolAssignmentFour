using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellaSchoolAssignmentFour
{
    //Subclass BankA
    internal class BankA : Bank
    {
        private string name = "Commercial Bank";
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override double getBalance()
        {
            return 100;
        }
    }
}
