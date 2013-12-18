using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class TestCalcChain
    {
        static void Main(string[] args)
        {
            /* Each chain object points to a calculation object */
            Chain chaincalc1 = new AddNumbers();
            Chain chaincalc2 = new SubtractNumbers();
            Chain chaincalc3 = new MultiplyNumbers();
            Chain chaincalc4 = new DivideNumbers();

            /* set the next chain to the next Chain object */
            chaincalc1.setNextChain(chaincalc2);
            chaincalc2.setNextChain(chaincalc3);
            chaincalc3.setNextChain(chaincalc4);

            /* Try each of these */
            //Numbers request = new Numbers(5, 2, "add");
            //Numbers request = new Numbers(5, 2, "subtract");
            //Numbers request = new Numbers(5, 2, "multiply");
            //Numbers request = new Numbers(5, 2, "divide");
            Numbers request = new Numbers(5, 2, "exp");

            /* Begin the chain */
            chaincalc1.calculate(request);
        }
    }
}
