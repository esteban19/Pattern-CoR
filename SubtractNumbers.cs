using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SubtractNumbers : Chain
    {
        //Holds value for next in chain. Must be accssible as Addnumbers
        private Chain nextInChain;

        //received from previous. Setup in runtime.(i.e. Main)
        public void setNextChain(Chain nextChain)
        {
            this.nextInChain = nextChain;
        }

        public void calculate(Numbers request)
        {
            if (request.CalcWanted == "subtract")
            {
                Console.WriteLine(request.Number1 + " - " + request.Number2 + " = " +
                    (request.Number1 - request.Number2));
            }
            else
                nextInChain.calculate(request);//calling next in chain's calculate method.
        }
    }
}
