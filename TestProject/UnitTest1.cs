using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Demo
{
    class Selenium_Demo
    {
        String test_url = "http://prelive.aptimea.com/form/questionnaire";

        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(100);

            

            // IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            // searchButton.Click();
            

            for(int i = 0; i < 3; i++)
            {
                IWebElement red = driver.FindElement(By.XPath("//*[@id='edit-je-suis-" + i + "']"));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", red);
                System.Threading.Thread.Sleep(100);
            }
            for (int i = 0; i < 65; i++)
            {
            SelectElement Select = new SelectElement(driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year")));
                Select.SelectByIndex(i);

                System.Threading.Thread.Sleep(2);
            }
            for(int i = 0; i < 4; i++)
            {
                IWebElement red = driver.FindElement(By.XPath("//*[@id='edit-je-fais-du-sport-chaque-semaine-" + i + "']"));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", red);
                System.Threading.Thread.Sleep(100);
            }
            for (int i = 0; i < 3; i++)
            {
                IWebElement red = driver.FindElement(By.XPath("//*[@id='edit-je-suis-2-" + i + "']"));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", red);
                System.Threading.Thread.Sleep(100);
            }
            IWebElement searchText = driver.FindElement(By.CssSelector("#edit-mes-traitements-medicaux-sont"));
            searchText.SendKeys("LambdaTest");

            IWebElement searchText1 = driver.FindElement(By.CssSelector("#edit-user-weight"));
            searchText1.SendKeys("61");

            IWebElement searchText2 = driver.FindElement(By.CssSelector("#edit-user-height"));  
            searchText2.SendKeys("61");

            for (int i = 0; i < 3; i++)
            {
                IWebElement red = driver.FindElement(By.XPath("//*[@id='edit-je-vis-" + i + "']"));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", red);
                System.Threading.Thread.Sleep(100);
            }

            IWebElement searchText3 = driver.FindElement(By.CssSelector("#edit-j-ai-enfants-nombre-"));
            searchText3.SendKeys("0");
            

                IWebElement red1 = driver.FindElement(By.XPath("//*[@id='edit-patient-goals-28']"));
                IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
                executor1.ExecuteScript("arguments[0].click();", red1);
                System.Threading.Thread.Sleep(1000);

            IWebElement searchButton = driver.FindElement(By.XPath("//button[@value='Suivant']"));
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("arguments[0].click();", searchButton);
            System.Threading.Thread.Sleep(3000);


            IWebElement searchButton1 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/div/section[2]/div/div[2]/form/div[3]/div[1]/fieldset[1]/div/div/div[1]/label/input"));
            IJavaScriptExecutor executor22 = (IJavaScriptExecutor)driver;
            executor22.ExecuteScript("arguments[0].click();", searchButton1);
            System.Threading.Thread.Sleep(1000);

            IWebElement searchButton11 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/div/section[2]/div/div[2]/form/div[3]/div[1]/fieldset[2]/div/div/div[2]/label/input"));
            IJavaScriptExecutor executor222 = (IJavaScriptExecutor)driver;
            executor222.ExecuteScript("arguments[0].click();", searchButton11);
            System.Threading.Thread.Sleep(1000);

            IWebElement searchButton111 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/div/section[2]/div/div[2]/form/div[3]/div[1]/fieldset[3]/div/div/div[3]/label/input"));
            IJavaScriptExecutor executor2222 = (IJavaScriptExecutor)driver;
            executor2222.ExecuteScript("arguments[0].click();", searchButton111);
            System.Threading.Thread.Sleep(1000);










            System.Threading.Thread.Sleep(600000);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}