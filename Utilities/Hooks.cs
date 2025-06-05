using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace ReqnrollProject2025.Utilities
{
    [Binding]
    internal class Hooks
    {
            

            private readonly DriverContext _context;

            public Hooks(DriverContext context)
            {
                _context = context;
            }

            [BeforeScenario]
            public void Setup()
            {

                Console.WriteLine("Running before every scenario");
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                // IWebDriver driver = new FirefoxDriver();
                // _context["WebDriver"] = driver;

                _context.Driver = new ChromeDriver();
                _context.Driver.Manage().Window.Maximize();

            }

            [AfterScenario]
            public void TearDown()
            {

                _context.Driver.Quit();
            }

            [BeforeTestRun]
            public static void BeforeTestRun()
            {

                Console.WriteLine("Running before TestRun for login functionality");

            }


            [AfterTestRun]
            public static void AfterTestRun()
            {


                Console.WriteLine("Running after TestRun for login functionality");


            }

            [BeforeStep]
            public void BeforeStep()
            {

                Console.WriteLine("Running before step");

            }


            [AfterStep]
            public void AfterStep()
            {

                Console.WriteLine("Running after step");

            }

            [BeforeScenario]
            public void BeforeScenario()
            {

                Console.WriteLine("Running before every scenario ");

            }


            [AfterScenario]
            public void AfterScenario()
            {

                Console.WriteLine("Running after every scenario");

            }


        }
}
