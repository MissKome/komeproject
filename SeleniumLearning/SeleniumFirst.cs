using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class SeleniumFirst
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            //Methods -geturl, click-
            //add chrome driver using webdrivermanager
         new  WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Test1()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url); 
            driver.Close();
        }
       
    }
}
