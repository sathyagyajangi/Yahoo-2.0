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

            for(int i=2;i<=8;i++)
            {

                FunctionLibrary.clickAction(driver, "/html/body/div[1]/header/div/section/div/div[3]/div/nav/ul/li[" + i + "]/a", "xpath");

                string title = driver.Title;

                Console.WriteLine(title);



            

                if(title.Contains("Series"))
                {

                    FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[1]/div/section/div/div[3]/div[2]/a[1]", "xpath");
                 

                

                 for (int j=2;j<=10;j++)
                    {


                      FunctionLibrary.clickAction(driver, "/html/body/div[1]/div/myapp/section[1]/div/div/div/div/section/div/div/div[2]/div/a[" + j + "]", "xpath");

                    

                    }

                }

               
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

            for (int j = 1; j <= 2; j++)
            {

                FunctionLibrary.clickAction(driver, "//*[@id='486f760d-cf05-45bb-80db-7ebbafb323df']/div/div/div[1]/div[4]/span[" + j + "]", "xpath");






                for (int a = 2; a <= 3; a++)

                {
                    FunctionLibrary.MouseOver(driver, "//*[@id='486f760d-cf05-45bb-80db-7ebbafb323df']/div/div/div[1]/div[1]/div/article[" + a +"]/div/div[2]/div[3]/div/div[2]/span");

                    for (int b = 1; b <= 3; b++)
                    {

                        FunctionLibrary.CtrlClick(driver, "//*[@id='486f760d-cf05-45bb-80db-7ebbafb323df']/div/div/div[1]/div[1]/div/article[" + a +"]/div/div[2]/div[3]/div/div[2]/ul/li[" + b +"]/a");


                    }




                }


            }


            string tiltle = driver.FindElement(By.XPath("/html/body/div[1]/div/myapp/section[2]/div/div/div/div[3]/section[1]/div/div/div[1]/div/h3")).Text;

            if (tiltle.Contains("Trending"))
            {

                for (int c = 1; c <= 8; c++)
                {
                    FunctionLibrary.clickAction(driver, "//*[@id='26c2875c-302c-42c1-b188-2cd13a01fbcf']/div/div/div[2]/div/article[" + c + "]/div/div/a/h2", "xpath");

                    Thread.Sleep(1000);
                }


            }

         
            for(int d=1;d<=3;d++)
            {

                FunctionLibrary.CtrlClick(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[2]/section/div/div/div[2]/div/article[" + d + "]/div/div[2]/a/h3");

                FunctionLibrary.MouseOver(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[2]/section/div/div/div[2]/div/article[" + d + "]/div/div[2]/div[2]/div/div[2]/span");

                for (int f = 1; f <= 3; f++)
                {

                    FunctionLibrary.CtrlClick(driver, "/html/body/div[1]/div/myapp/section[2]/div/div/div/div[2]/section/div/div/div[2]/div/article[" + d + "]/div/div[2]/div[2]/div/div[2]/ul/li[" + f + "]/a");


                }
            }



            for(int e=1;e<=4;e++)
            {

                FunctionLibrary.MouseOver(driver, "/html/body/div[1]/div/myapp/section[7]/div/div/div/div/section/section[" + e + "]/div/div/div[1]/div/h3");

         string str= FunctionLibrary.ElementText(driver, "/html/body/div[1]/div/myapp/section[7]/div/div/div/div/section/section[" + e + "]/div/div/div[1]/div/h3");

                Console.WriteLine(str);


               








            }
           








        }





        [TestMethod]

        public void temp()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://beta-cricket-yahoo.sportz.io/";

            driver.Manage().Window.Maximize();


            for(int i=1;i<=3;i++)
            {


                FunctionLibrary.MouseOver(driver, "/html/body/div[1]/div/myapp/section[7]/div/div/div/div/section/section[1]/div/div/div[2]/section/div[1]/div[2]/article[" + i + "]/div/div[1]/a/div/img");

                bool status = FunctionLibrary.VisibleWidget(driver, "/html/body/div[1]/div/myapp/section[7]/div/div/div/div/section/section[1]/div/div/div[2]/section/div[1]/div[2]/article[" + i + "]/div/div[1]/a/div/img");

              //  Console.WriteLine(status);

             string src=   driver.FindElement(By.XPath("/html/body/div[1]/div/myapp/section[7]/div/div/div/div/section/section[1]/div/div/div[2]/section/div[1]/div[2]/article[" + i + "]/div/div[1]/a/div/img")).GetAttribute("src");

              //  Console.WriteLine(src);
                if (src.EndsWith("default-lazy.png"))
                {

                    Console.WriteLine(src +"widget thumbail image is default");


                }

               
             
            }
           




        }





    }
}
