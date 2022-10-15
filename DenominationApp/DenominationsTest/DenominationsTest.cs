using DenominationApp;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace DenominationsTest
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1000,"1", "Your Change is")]
        public void DenominationsTestSuccess(int currency,string price,string result)
        {
            var denominations = new Denominations();
            StringBuilder output=denominations.CalculateDenominations(currency, price);
            var lines = output.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(result, lines[0]);
            
        }
        [Test]
        [TestCase(1000, "1001", "The amount is less than price of product")]
        public void DenominationsTestLessAmount(int currency, string price, string result)
        {
            var denominations = new Denominations();
            StringBuilder output = denominations.CalculateDenominations(currency, price);
            var lines = output.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(result, lines[0]);

        }
        [Test]
        [TestCase(1000, "1000", "Your Change is 0")]
        public void DenominationsTestZeroChange(int currency, string price, string result)
        {
            var denominations = new Denominations();
            StringBuilder output = denominations.CalculateDenominations(currency, price);
            var lines = output.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(result, lines[0]);

        }
    }
}