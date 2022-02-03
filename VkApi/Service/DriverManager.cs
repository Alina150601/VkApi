using OpenQA.Selenium;
using VkApi.Pages;

namespace VkApi.Service;

public class DriverManager
{
    private const string Phone = "375293567152";
    private const string Password = "Privetik_Zhene:)";

    private readonly IWebDriver _driver;

    public DriverManager(IWebDriver driver)
    {
        _driver = driver;
    }

    public bool CheckIsLiked()
    {
        var profilPage = new ProfilePage(_driver);
        return profilPage.ImageHeartAttribute().Contains("active");
    }

    public void SignUp()
    {
        var mainPage = new LoginPage(_driver);
        mainPage.EmailInputEnterData(Phone);
        mainPage.PasswordInputEnterData(Password);
        mainPage.EnterButtonClick();
    }

    public void OpenPhoto()
    {
        var feedPage = new FeedPage(_driver);
        feedPage.ProfileButtonClick();
        var profilePage = new ProfilePage(_driver);
        profilePage.ProfileImageClick();
    }
}
