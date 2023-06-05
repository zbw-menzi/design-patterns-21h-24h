using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Mediator
{
    public class SalesPerson
    {
        public void SellItemInStore1()
        {
            var mediator = new Mediator();
            var store1 = new Store1(mediator);

            store1.SellItem();
        }
    }
}
