using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
