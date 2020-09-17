using NUnit.Framework;
using PriceCalculation;

namespace NUnitTestPriceCalculationApp
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TotalCost()
        {

            Assert.That(Program.TotalCost(4, 20), Is.GreaterThan(0));
            
        }

        [Test]
        public void TotalCost1()
        {

            Assert.That(Program.TotalCost(0, 0), Is.EqualTo(0));
        }
    }
}