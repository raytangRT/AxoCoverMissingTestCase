using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AxoCoverMissingTestCase
{
    public class XUnitTestCase
    {
        [Theory, InlineData(true), InlineData(false)]
        public void TestCreateInstance(bool input)
        {
            Assert.True(input);
        }

        [Theory, InlineData(System.Windows.Input.Key.F3), InlineData(System.Windows.Input.Key.F4)]
        public void TestCreateInstance2(System.Windows.Input.Key key)
        {
            Assert.Equal(System.Windows.Input.Key.F3, key);
        }

        [Theory, InlineData(System.Windows.Input.ModifierKeys.Alt), InlineData(System.Windows.Input.ModifierKeys.Windows)]
        public void TestCreateInstance3(System.Windows.Input.ModifierKeys key)
        {
            Assert.Equal(System.Windows.Input.ModifierKeys.None, key);
        }
    }
}
