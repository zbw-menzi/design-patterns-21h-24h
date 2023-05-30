using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Zbw.DesignPatterns.Proxy.RealWorldExample;

namespace Zbw.DesignPatterns.Tests.Proxy
{
    public class MathProxyTests
    {
        [Fact]
        public void Summate_FourPlusTwo_ExpectingSix()
        {
            // Arrange
            IMath proxy = new MathProxy();

            // Act
            var result = proxy.Add(4, 2);

            // Assert
            result.Should().Be(6);
        }

        [Fact]
        public void Subtract_SixMinusTwo_ExpectingFour()
        {
            // Arrange
            IMath proxy = new MathProxy();

            // Act
            var result = proxy.Sub(6, 2);

            // Assert
            result.Should().Be(4);
        }

        [Fact]
        public void Multiply_EightByThree_ExpectingTwentyFour()
        {
            // Arrange
            IMath proxy = new MathProxy();

            // Act
            var result = proxy.Mul(8, 3);

            // Assert
            result.Should().Be(24);
        }

        [Fact]
        public void Divide_SixByTwo_ExpectingThree()
        {
            // Arrange
            IMath proxy = new MathProxy();

            // Act
            var result = proxy.Div(6, 2);

            // Assert
            result.Should().Be(3);
        }
    }
}
