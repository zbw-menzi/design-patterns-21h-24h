using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Mediator
{
    public class Store2
    {
        private readonly IMediator _mediator;
        public Store2(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SellItem()
        {
            // Sell Item
            _mediator.Notify(this);
            this.UpdateStorage();
        }
        public void UpdateStorage()
        {
            // Update Storage
        }
    }
}
