using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Mediator
{
    public interface IMediator
    {
        public void Notify(object sender);
    }
}
