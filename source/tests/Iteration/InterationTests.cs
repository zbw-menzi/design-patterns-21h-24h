using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;

using Zbw.DesignPatterns.Factory;
using Zbw.DesignPatterns.Iterator;
using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Tests.Iteration
{
    public class IteratorPatternTests
    {
        [Fact]
        public void ConcreteAggregate_AddItem_ItemsInIterator()
        {
            // Arrange
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate.AddItem("Element 1");
            aggregate.AddItem("Element 2");
            aggregate.AddItem("Element 3");

            // Act
            IIterator iterator = aggregate.CreateIterator();

            // Assert
            Assert.True(iterator.HasNext());
            Assert.Equal("Element 1", iterator.Next());
            Assert.True(iterator.HasNext());
            Assert.Equal("Element 2", iterator.Next());
            Assert.True(iterator.HasNext());
            Assert.Equal("Element 3", iterator.Next());
            Assert.False(iterator.HasNext());
        }

        [Fact]
        public void ConcreteAggregate_NoItems_ExceptionOnNext()
        {
            // Arrange
            ConcreteAggregate aggregate = new ConcreteAggregate();

            // Act
            IIterator iterator = aggregate.CreateIterator();

            // Assert
            Assert.False(iterator.HasNext());
            Assert.Throws<InvalidOperationException>(() => iterator.Next());
        }
    }

}
