using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellaSchoolAssignmentFour
{
    //Abstract class Bank
    internal abstract class Bank
    {
        private string name = "Central Bank";

        //Abstract method getBalance
        public abstract double getBalance();

        
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
