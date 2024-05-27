using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellaSchoolAssignmentFour
{
    //Subclass BankB
    internal class BankB : Bank
    {
        private string name = "MicroFinance Bank";

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override double getBalance()
        {
            return 150;
        }
    }
}
