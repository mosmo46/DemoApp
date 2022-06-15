using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Xunit;

namespace UnitTestProject1
{
    [TestFixture]
    public class CalculatorTests: Calculator
    {
        
        [Test]
        public void TestCanDoUnitTesting()
        {
            NUnit.Framework.Assert.True(true);
        }


       
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Ignore("Test failed to test if not uploaded to Gibhat")]
        public void TestCanDoUnitTesting2()
        {
            NUnit.Framework.Assert.True(false);
        }

        [Test]
        public void TestRes()
        {
            int n1 = 5;
            int n2 = 2;
         NUnit.Framework.Assert.AreEqual(n1 - n2, Calculator.Subtract(n1, n2));
        }
        [Test]

        public void TestSum()
        {            int n1 = 10;
            int n2 = 3;
           NUnit.Framework.Assert.AreEqual(n1 + n2, Calculator.Add(n1, n2));
        }

        [Test]
        public void TestDiv()
        {
            int n1 = 10;
            int n2 = 2;
            NUnit.Framework.Assert.AreEqual(n1 / n2, Calculator.Divide(n1, n2));
        }

        [Test]
        public void TestMul()
        {
            int n1 = 3;
            int n2 = 3;
            NUnit.Framework.Assert.AreEqual(n1 * n2, Calculator.Multiply(n1, n2));
        }


    }
}
