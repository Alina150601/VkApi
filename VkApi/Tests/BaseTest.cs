using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using VkApi.Extension;

namespace VkApi.Tests;

public class BaseTest
{
    private const string BaseUrl = "https://vk.com";

    protected IWebDriver _driver;
    protected WebDriverWait _wait;
    protected Actions _actions;

    [SetUp]
    public void SetUp()
    {
        _driver = new ChromeDriver();
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
        _driver.GoToUrl(BaseUrl);
    }

    [TearDown]
    public void TearDown() =>_driver.Quit();
}
