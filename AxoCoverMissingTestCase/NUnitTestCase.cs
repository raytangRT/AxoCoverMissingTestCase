using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxoCoverMissingTestCase
{
    public class NUnitTestCase
    {
        [TestCase(true), TestCase(false)]
        public void TestCreateInstance(bool input)
        {
            Assert.True(input);
        }

        [TestCase(System.Windows.Input.Key.F3), TestCase(System.Windows.Input.Key.F4)]
        public void TestCreateInstance2(System.Windows.Input.Key key)
        {
            Assert.AreEqual(System.Windows.Input.Key.F3, key);
        }

        [TestCase(System.Windows.Input.ModifierKeys.Alt), TestCase(System.Windows.Input.ModifierKeys.Windows)]
        public void TestCreateInstance3(System.Windows.Input.ModifierKeys key)
        {
            Assert.AreEqual(System.Windows.Input.ModifierKeys.None, key);
        }
    }
}
