using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zbw.DesignPatterns.Command
{
    public class SaleInvoker
    {

        //As per the Command Design Pattern, the Command Object will be passed to the Invoker Object.
        //The Invoker Object does not know how to handle the request. What the Invoker will do is, it will call the Execute method of the Command Object.
        //The Execute method of the command object will call the Receiver Object Method. The Receiver Object Method will perform the necessary action to handle the request.

        private ICommand _command;
        public void SetCommand(ICommand command) { _command = command; }
        public void Invoke() 
        {
            _command.Execute(null);
        }

    }
}
