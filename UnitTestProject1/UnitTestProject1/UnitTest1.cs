using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b1b15e88fa797225412429c1c50c122a1/");
            //IWebElement lon = driver.FindElement(By.Id("/coord/lon"));
            //IWebElement lat = driver.FindElement(By.Id("/coord/lat"));

            //WebElement city = driver.findElement(By.id("city"));
            //assertEquals("MyCityName", city.getText());
            //longitude value to be -0.13 and latitude to be 51.51.

            //IWebElement lon = driver.FindElement(By.Id("/coord/lon"));
            //lon.GetAttribute("value").ToString();

            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("/coord/lon")).Displayed);
                Console.Write("longitude displayed. assertion pass");
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            Console.Read();

            driver.Close();
        }

    }
}