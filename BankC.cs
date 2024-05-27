using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellaSchoolAssignmentFour
{
    //Subclass BankC
    internal class BankC : Bank
    {
        private string name = "Mortgage Bank";

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override double getBalance()
        {
            return 200;
        }
    }
}
