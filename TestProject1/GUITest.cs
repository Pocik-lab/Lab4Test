using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using System.Threading;

namespace TestProject1
{
    public class GUITest
    {
        private const string path = @"C:\Users\tegin\Desktop\Тестирование\TestLab4\TestLab4\bin\Debug\TestLab4.exe";

        public Window AppStart()
        {
            Application application = null;
            Window window = null;
            application = Application.Launch(path);
            var windows = application.GetWindows();
            window = windows.Find(x => x.Id == "CalculatorForm");
            return window;
        }

        [Theory]
        [InlineData("1", "2", "3")]
        [InlineData("0,1", "0,2", "0,3")]
        [InlineData("-1", "-2", "-3")]
        [InlineData("x", "y", "0")]
        [InlineData("x", "1", "1")]
        [InlineData("1", "y", "1")]
        public void TestOnPlusClicked(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button sumClick = window.Get<Button>(SearchCriteria.ByAutomationId("btSum"));
            Thread.Sleep(1000);
            sumClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "2", "-1")]
        [InlineData("-1", "-2", "1")]
        [InlineData("0,1", "0,2", "-0,1")]
        [InlineData("x", "y", "0")]
        [InlineData("x", "1", "-1")]
        [InlineData("1", "y", "1")]
        public void TestOnMinusClicked(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button minusClick = window.Get<Button>(SearchCriteria.ByAutomationId("BtSubstract"));
            Thread.Sleep(1000);
            minusClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "2", "2")]
        [InlineData("-1", "2", "-2")]
        [InlineData("-1", "-2", "2")]
        [InlineData("0,1", "0,2", "0,02")]
        [InlineData("x", "y", "0")]
        [InlineData("x", "1", "0")]
        [InlineData("1", "y", "0")]
        public void TestOnMultiplyClicked(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button mulClick = window.Get<Button>(SearchCriteria.ByAutomationId("btMultiply"));
            Thread.Sleep(1000);
            mulClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("2", "1", "2")]
        [InlineData("2", "-1", "-2")]
        [InlineData("0,02", "0,1", "0,2")]
        [InlineData("x", "y", "Division by zero")]
        [InlineData("x", "1", "0")]
        [InlineData("1", "y", "Division by zero")]
        public void TestOnDivideClicked(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button divClick = window.Get<Button>(SearchCriteria.ByAutomationId("btDevide"));
            Thread.Sleep(1000);
            divClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnPlusClickedThrowsException(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button sumClick = window.Get<Button>(SearchCriteria.ByAutomationId("btSum"));
            Thread.Sleep(1000);
            sumClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnMinusClickedThrowsException(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button minusClick = window.Get<Button>(SearchCriteria.ByAutomationId("BtSubstract"));
            Thread.Sleep(1000);
            minusClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnMultiplyClickedThrowsException(string a, string b, string res)
        {
            var window = AppStart();
            var firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button mulClick = window.Get<Button>(SearchCriteria.ByAutomationId("btMultiply"));
            Thread.Sleep(1000);
            mulClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "0", "Division by zero")]
        [InlineData("1", "0,00000001", "Division by zero")]
        [InlineData("1", "0,000000009", "Division by zero")]
        [InlineData("1", "-0,00000001", "Division by zero")]
        [InlineData("1", "-0,000000009", "Division by zero")]
        [InlineData("1", "", "Empty parameter")]
        [InlineData("", "1", "Empty parameter")]
        [InlineData("", "", "Empty parameter")]
        public void TestOnDivideClickedThrowsException(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button divClick = window.Get<Button>(SearchCriteria.ByAutomationId("btDevide"));
            Thread.Sleep(1000);
            divClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }

        [Theory]
        [InlineData("1", "0,000000011", "Division by zero")]
        [InlineData("1", "-0,000000011", "Division by zero")]
        public void TestOnDivideClickedNotThrowsException(string a, string b, string res)
        {
            var window = AppStart();
            TextBox firstArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbA"));
            Thread.Sleep(1000);
            firstArg.SetValue(a);
            TextBox secArg = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbB"));
            Thread.Sleep(1000);
            secArg.SetValue(b);
            Button divClick = window.Get<Button>(SearchCriteria.ByAutomationId("btDevide"));
            Thread.Sleep(1000);
            divClick.Click();
            TextBox Display = window.Get<TextBox>(SearchCriteria.ByAutomationId("tbMessage"));
            Assert.Equal(res, Display.Name);
            Thread.Sleep(2000);
            window.Close();
        }
    }
}
