﻿using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSandbox
{
    public class CalcObjectModel : IDisposable
    {
        private IWebDriver _webDriver;
        private IDictionary<string, IWebElement> _controlCache;

        public CalcObjectModel(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _controlCache = new Dictionary<string, IWebElement>();
        }

        public IWebElement ZeroButton { get { return GetByName("Zero"); } }
        public IWebElement OneButton { get { return GetByName("One"); } }
        public IWebElement TwoButton { get { return GetByName("Two"); } }
        public IWebElement ThreeButton { get { return GetByName("Three"); } }
        public IWebElement FourButton { get { return GetByName("Four"); } }
        public IWebElement FiveButton { get { return GetByName("Five"); } }
        public IWebElement SixButton { get { return GetByName("Six"); } }
        public IWebElement SevenButton { get { return GetByName("Seven"); } }
        public IWebElement EightButton { get { return GetByName("Eight"); } }
        public IWebElement NineButton { get { return GetByName("Nine"); } }
        public IWebElement PlusButton { get { return GetByName("Plus"); } }
        public IWebElement MinusButton { get { return GetByName("Minus"); } }
        public IWebElement DivideButton { get { return GetByName("Divide by"); } }
        public IWebElement MultiplyButton { get { return GetByName("Multiply by"); } }
        public IWebElement EqualsButton { get { return GetByName("Equals"); } }

        public IWebElement GetDisplay(int value)
        {
            string controlName = $"Display is  {value} ";
            return GetByName(controlName, true);
        }

        private IWebElement GetByName(string name, bool noCache = false)
        {
            if (_controlCache.ContainsKey(name) && !noCache) {
                return _controlCache[name];
            }
            else
            {
                var control = (_webDriver as IFindsByName).FindElementByName(name);
                if (!noCache) _controlCache.Add(name, control);

                return control;
            }
        }

        public void Dispose()
        {
            _webDriver.Dispose();
            _webDriver = null;
        }
    }
}
