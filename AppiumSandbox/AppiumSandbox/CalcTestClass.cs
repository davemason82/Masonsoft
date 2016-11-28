using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AppiumSandbox
{
    [TestFixture]
    public class CalcTestClass
    {
        private CalcObjectModel _calcWrapper;

        [OneTimeSetUp]
        public void SetUp()
        {
            _calcWrapper = CalcFactory.GetCalcObjectModel();
        }

        [Test]
        public void EightPlusTwoEqualsTen()
        {
            _calcWrapper.EightButton.Click();
            _calcWrapper.PlusButton.Click();
            _calcWrapper.TwoButton.Click();
            _calcWrapper.EqualsButton.Click();

            Assert.That(_calcWrapper.GetDisplay(10), Is.Not.Null);
        }

        [Test]
        public void NineTimesFourEqualsThirtySix()
        {
            _calcWrapper.NineButton.Click();
            _calcWrapper.MultiplyButton.Click();
            _calcWrapper.FourButton.Click();
            _calcWrapper.EqualsButton.Click();

            Assert.That(_calcWrapper.GetDisplay(36), Is.Not.Null);
        }

        [Test]
        public void SixDividedByThreeEqualsTwo()
        {
            _calcWrapper.SixButton.Click();
            _calcWrapper.DivideButton.Click();
            _calcWrapper.ThreeButton.Click();
            _calcWrapper.EqualsButton.Click();

            Assert.That(_calcWrapper.GetDisplay(2), Is.Not.Null);
        }

        [Test]
        public void SevenMinusOneEqualsSix()
        {
            _calcWrapper.SevenButton.Click();
            _calcWrapper.MinusButton.Click();
            _calcWrapper.OneButton.Click();
            _calcWrapper.EqualsButton.Click();

            Assert.That(_calcWrapper.GetDisplay(6), Is.Not.Null);
        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            _calcWrapper.Dispose();
        }
    }
}