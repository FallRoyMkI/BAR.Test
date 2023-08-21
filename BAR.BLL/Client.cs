using System.Net;
using RestSharp;

namespace BAR.BLL;

public class Client
{
    private const string Url = "https://localhost:7014/";
    private const string UrlTask1 = "GetSumResponse";
    private const string UrlTask2 = "GetPalindromeResponse";
    private const string UrlTask3 = "GetSortResponse";
    private readonly RestClient _client;

    public Client()
    {
        _client = new RestClient(Url);
    }

    public bool GetSumResponse(string json) => SendResult(UrlTask1, json);
    public bool GetPalindromeResponse(string json) => SendResult(UrlTask2, json);
    public bool GetSortResponse(string json) => SendResult(UrlTask3, json);

    private bool SendResult(string url, string json)
    {
        try
        {
            RestRequest request = new(url, Method.Post);
            request.AddJsonBody(json);
            RestResponse response = Task.Run(async () => await _client.ExecuteAsync(request)).Result;
            if (response.StatusCode == HttpStatusCode.OK) return true;
            Console.WriteLine(response.ErrorMessage);
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}