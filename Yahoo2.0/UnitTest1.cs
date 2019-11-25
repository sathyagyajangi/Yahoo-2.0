using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace Yahoo2._0
{
    [TestClass]
    public class UnitTest1
    {
       


  


        [TestMethod]
        public void TestMethod1()
        {


            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://beta-cricket-yahoo.sportz.io/";

            driver.Manage().Window.Maximize();

            string handle = driver.CurrentWindowHandle;

            for(int i=2;i<=11;i++)
            {

                FunctionLibrary.clickAction(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a", "xpath");

                string title = driver.Title;

                Console.WriteLine(title);



            

                if(title.Contains("Series"))
                {

                    Yahoo yahoo = new Yahoo(driver);
                    yahoo.GetUrl();


                    driver.FindElement(By.CssSelector(".si-dv-row")).Click();

                    for (int j=2;j<=10;j++)
                    {


                      FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/a[" + j + "]", "xpath");

                    

                    }

                }

                driver.Navigate().Back();
            }




            


           
        }

        [TestMethod]

        public void Homepage()
        {


            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://beta-cricket-yahoo.sportz.io/";

            driver.Manage().Window.Maximize();

            string handle = driver.CurrentWindowHandle;

            string title = driver.FindElement(By.XPath("//*[@id='app']/div[1]/div")).Text;
       
            Console.WriteLine(title);

            if(title.Contains("All"))
            {
                for(int i=1;i<=3;i++)
                {
                    FunctionLibrary.clickAction(driver, "//*[@id='app']/div[1]/div", "xpath");


                    FunctionLibrary.clickAction(driver, "//*[@id='app']/div[1]/div/div[2]/span[" + i + "]", "xpath");

                    Thread.Sleep(2000);

                }

            }

        }


    }
}
