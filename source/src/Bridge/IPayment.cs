using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Bridge
{

    public interface IPayment
    {
        void SubmitPayment(decimal amount);
    }
}



