using Newtonsoft.Json;
using NinjaMobile.DtoModel;
using System.Text;
#nullable disable

namespace NinjaMobile.Services
{
    public class MobileFrontendService
    {
        private readonly HttpClient _httpClient;      
        public MobileFrontendService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }
        public async Task<FrontEndDto> GetFontEndData()
        {
            FrontEndDto data = new FrontEndDto();
          
            var response = await _httpClient.GetAsync("mobilefrontend/getfontenddata");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<FrontEndDto>(responseContent);
            }
            return data;
        }
    }   
}
