using Microsoft.JSInterop.WebAssembly;
using System.Net;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorRenderModes.Client.Api
{
    public class CounterClientService
    {
        public HttpClient httpClient { get; set; }
        public CounterClientService(HttpClient httpClient)
        {
                this.httpClient = httpClient;
        }

     
        public async Task<int> Increment(int counter)
        {
            try
            {
                var address = httpClient.BaseAddress + $"api/counter/increment?counter={counter}";
                HttpResponseMessage? response = await httpClient.GetAsync(address);

                if (response.IsSuccessStatusCode)
                {
                    var result = int.TryParse(await response.Content.ReadAsStringAsync(), out int number) ? number : -1;
                    return result;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
