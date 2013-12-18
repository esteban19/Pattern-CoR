using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Numbers
    {
        private int number1;
        private int number2;
        private string calculationWanted;

        public Numbers(int newNumber1, int newNumber2, string calcWanted)
        {
            number1 = newNumber1;
            number2 = newNumber2;
            calculationWanted = calcWanted;
        }

        public int Number1
        {
            get { return number1; }
        }
        public int Number2
        {
            get { return number2; }
        }
        public string CalcWanted
        {
            get { return calculationWanted; }
        }
        
    }
}
