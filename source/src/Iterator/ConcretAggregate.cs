using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Iterator
{
   
        public class ConcreteAggregate : IAggregate
        {
            private ArrayList _items = new ArrayList();

            public void AddItem(object item)
            {
                _items.Add(item);
            }

            public IIterator CreateIterator()
            {
                return new ConcreteIterator(this);
            }

            // Konkreter Iterator, der den Zugriff auf die Elemente der Sammlung ermöglicht
            private class ConcreteIterator : IIterator
            {
                private ConcreteAggregate _aggregate;
                private int _currentIndex = 0;

                public ConcreteIterator(ConcreteAggregate aggregate)
                {
                    _aggregate = aggregate;
                }

                public bool HasNext()
                {
                    return _currentIndex < _aggregate._items.Count;
                }

                public object Next()
                {
                    if (HasNext())
                    {
                        object currentItem = _aggregate._items[_currentIndex];
                        _currentIndex++;
                        return currentItem;
                    }

                    throw new InvalidOperationException("No more elements in the collection.");
                }
            }
        }
    
}
