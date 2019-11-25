using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Yahoo2._0
{
    class IntializeApplication
    {
        public  static  void Intialize()

        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://beta-cricket-yahoo.sportz.io/";

            driver.Manage().Window.Maximize();



        }

    }
}
