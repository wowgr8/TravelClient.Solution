using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5011/api");
      RestRequest request = new RestRequest($"destinations", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}