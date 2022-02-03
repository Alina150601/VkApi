using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace VkApi.Service;

public class ApiManager
{
    private readonly HttpClient _client;

    public ApiManager()
    {
        _client = new HttpClient();
        _client.Timeout = TimeSpan.FromSeconds(15);
    }

    public async Task LikePhotoAsync()
    {
        var parameters = new Dictionary<string, string>
        {
            { "access_token", "0722333b7fcab198cb15d6923ae2136140acc619342df1201e987e97af6dddb097dd3f2d32d6fec99f84f" },
            { "type", "photo" },
            { "item_id", "456239646" },
            { "v", "5.131" }
        };
        await PostAsync("https://api.vk.com/method/likes.add", parameters);
    }

    private async Task PostAsync(string url, Dictionary<string, string> parameters)
    {
        var content = new FormUrlEncodedContent(parameters);
        var response = await _client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
}
