using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumTraining;

public class Tests
{
    IWebDriver drv;

    [SetUp]
    public void Setup()
    {
        drv = new ChromeDriver();
        //drv = new FirefoxDriver();
        //drv = new EdgeDriver();

    }

    [TearDown]
    public void TearDown()
    {
        drv.Quit();
    }

    [Test]
    public void Test1()
    {
        drv.Navigate().GoToUrl("https://google.com");
        drv.FindElement(By.CssSelector("[name=q]")).SendKeys("Sergey Sizov");
    }
}
