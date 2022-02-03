using OpenQA.Selenium;
using VkApi.Extension;

namespace VkApi.Pages;

public class LoginPage
{
    private readonly IWebDriver _driver;

    private By _loginInput = By.Id("index_email");
    private By _passwordInput = By.Id("index_pass");
    private By _enterButton = By.Id("index_login_button");

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void EmailInputEnterData(string login) => _driver.GetElement(_loginInput).SendKeys(login);

    public void PasswordInputEnterData(string password) => _driver.GetElement(_passwordInput).SendKeys(password);

    public void EnterButtonClick() => _driver.ElementClick(_enterButton);
}
