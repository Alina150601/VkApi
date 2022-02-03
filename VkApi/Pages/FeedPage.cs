using OpenQA.Selenium;
using VkApi.Extension;

namespace VkApi.Pages;

public class FeedPage
{
    private readonly IWebDriver _driver;

    private By _profileButton = By.XPath("//*[text()='Моё досье']");

    public FeedPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void ProfileButtonClick() => _driver.ElementClick(_profileButton);
}
