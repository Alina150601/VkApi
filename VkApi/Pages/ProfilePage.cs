using OpenQA.Selenium;
using VkApi.Extension;

namespace VkApi.Pages;

public class ProfilePage
{
    private readonly IWebDriver _driver;

    private By _profileImage = By.XPath("//*[@class='page_square_photo crisp_image ']");
    private By _likeIcon = By.XPath("//*[@class='like_wrap _like_photo200456640_456239646 ']//a[@title='Одобряю']");

    public ProfilePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void ProfileImageClick() => _driver.ElementClick(_profileImage);

    public string ImageHeartAttribute() => _driver.GetElement(_likeIcon).GetAttribute("class");
}
