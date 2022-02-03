using System.Threading.Tasks;
using NUnit.Framework;
using VkApi.Service;

namespace VkApi.Tests;

[TestFixture]
public class Tests : BaseTest
{
    [Test]
    public async Task SignUpAsync()
    {
        var driverManager = new DriverManager(_driver);
        driverManager.SignUp();
        driverManager.OpenPhoto();
        Assert.IsFalse(driverManager.CheckIsLiked());

        var apiManager = new ApiManager();
        await apiManager.LikePhotoAsync();

        _driver.Navigate().Refresh();
        Assert.IsTrue(driverManager.CheckIsLiked());
    }
}
