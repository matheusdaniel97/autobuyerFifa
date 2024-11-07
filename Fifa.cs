using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumWebDriver1
{
    public class TestaGoogle
    {
        string baseURL;
        IWebDriver driver;

        [SetUp]
        public void Iniciar()
        {
            baseURL = "https://www.ea.com/fifa/ultimate-team/web-app/";
            driver = new ChromeDriver();
            
        }

        [TearDown]
        public void Finalizar()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }


        [Test]
        public void Consultar()
        {
            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector(".call-to-action")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("email")).SendKeys("matheus_a7x1997@hotmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Matheus97@");
            //driver.FindElement(By.CssSelector(".btn-next")).Click();
            Thread.Sleep(2000);
            Thread.Sleep(200000);

            for (var x = 0; x < 700; x++)
            {
                for (var i = 0; i < 700; i++)
                {
                    driver.FindElement(By.CssSelector(".increment-value")).Click();
                    driver.FindElement(By.CssSelector(".call-to-action")).Click();
                    Thread.Sleep(549);
                    try
                    {    
                        driver.FindElement(By.CssSelector(".buyButton")).Click();
                        driver.FindElement(By.XPath("/html/body/div[4]/section/div/div/button[1]/span[1]")).Click();
                    }
                    catch
                    {
                        driver.FindElement(By.CssSelector(".ut-navigation-button-control")).Click();
                        Thread.Sleep(800);
                    }
                }
                driver.FindElement(By.CssSelector(".decrement-value")).SendKeys(Keys.Backspace);
            }
        }
    }
}