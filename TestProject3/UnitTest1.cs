using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TestProject1
{
    public class Tests
    {
        AppiumDriver<AndroidElement> driver;


        [Test]
        public void Test1()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            appiumOptions.AddAdditionalCapability("deviceName", "Android Emulator");
            appiumOptions.AddAdditionalCapability("udid", "2C261FDH3003CJ");
            appiumOptions.AddAdditionalCapability("platform Version", "12");
            appiumOptions.AddAdditionalCapability("app", ".\\TestProject2\\dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            //appiumOptions.AddAdditionalCapability("appActivity", "crc646f76f13f64c213ab.WelcomeScreenActivity");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions);
            Thread.Sleep(10000);
            AndroidElement demo = driver.FindElement(By.Id("dk.resound.smart3d:id/demo_button"));


            //By demo = By.Id("dk.resound.smart3d:id/demo_button");

            demo.Click();


            //driver.FindElement(elementId7).Click();


            Assert.Pass();
        }
    }
}
