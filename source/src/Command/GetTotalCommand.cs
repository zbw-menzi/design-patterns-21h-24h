using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Command
{
    public class GetTotalCommand : ICommand
    {

        // The command object involves three things. First, the Command Object has the Request (i.e. what to do?).
        // Second, it also has the Receiver Object Reference. The Receiver Object is nothing but the object which will handle the request.
        // Third, the command object also has the Execute method. The Execute method will call the receiver object method and the receiver object method will handle the request.

        private readonly Sale _receiver;
        public decimal Result { get; private set; }
        public GetTotalCommand(Sale receiver) 
        {
            _receiver = receiver;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           Result = _receiver.GetTotal();
        }
    }
}
