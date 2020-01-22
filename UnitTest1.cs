using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\bmulovanyi\\source\\repos\\BohdanTest\\BohdanTest");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            driver.Manage().Window.Maximize();

            
            IWebElement LaptopNavigation = driver.FindElement(By.ClassName("menu-categories__link"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            LaptopNavigation.Click();
            //Actions builder = new Actions(driver);
            //Actions hoverClick = builder.MoveToElement(LaptopNavigation).Click();
           


             //searchfield.SendKeys("Anamals");
             //searchfield.Submit();
             //IWebElement page = driver.FindElement(By.ClassName("LC20lb"));
             //page.Click();
            driver.Close();
            driver.Quit();
            //Assert.Pass();
        }
    }
}
