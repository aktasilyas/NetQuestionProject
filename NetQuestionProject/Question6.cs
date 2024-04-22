using System;
using System.Net.Http;
using System.Threading.Tasks;

public class HtmlDownloader : IDisposable
{
    private readonly HttpClient httpClient;
    private readonly string url;

    public HtmlDownloader(string url)
    {
        this.url = url;
        this.httpClient = new HttpClient();
    }

    public async Task<string> DownloadHtmlAsync()
    {
        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not 200 OK
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error downloading HTML from {url}: {e.Message}");
            return null;
        }
    }

    public void Dispose()
    {
        httpClient.Dispose(); // Clean up the HttpClient
    }
}


