using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /* Handler interface */
    public interface Chain
    {
        void setNextChain(Chain nextChain);/*successor*/
        void calculate(Numbers request);/*+handleRequest()*/
    }
}
