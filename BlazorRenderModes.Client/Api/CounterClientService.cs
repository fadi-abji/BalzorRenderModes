using BlazorRenderModes.Client.Models;

namespace BlazorRenderModes.Client.Api
{
    public class CounterClientService
    {
        public HttpClient httpClient { get; set; }
        public CounterClientService(HttpClient httpClient)
        {
                this.httpClient = httpClient;
        }

        public async Task<Counter> Increment(Counter counter)
        {
            try
            {
                var address = httpClient.BaseAddress + $"api/counter/increment?counter={counter.Value}";

                HttpResponseMessage? response = await httpClient.GetAsync(address);

                if (response.IsSuccessStatusCode)
                {
                    counter.Value = int.TryParse(await response.Content.ReadAsStringAsync(), out int number) ? number : -1;

                    return counter;
                }
                else
                {
                    return counter;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
