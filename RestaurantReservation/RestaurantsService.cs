using RestaurantReservation.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace RestaurantReservation
{
    public class RestaurantsService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Restaurants";

        public RestaurantsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Restaurant>> Get()
        {
            var response = await _client.GetAsync(BasePath);
            var dataString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<IEnumerable<Restaurant>>(dataString, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            });
            return result;
        }
    }
}
