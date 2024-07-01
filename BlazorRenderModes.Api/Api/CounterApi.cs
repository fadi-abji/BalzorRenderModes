
namespace BalzorRenderModes.Api
{
    public class CounterApi : ICounterApi
    {

        public HttpClient HttpClient { get; set; }

        public CounterApi(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<int> Increment(int counter)
        {
            try
            {
                var address = HttpClient.BaseAddress + $"api/counter/increment?counter={counter}";

                HttpResponseMessage? response = await HttpClient.GetAsync(address);

                if (response.IsSuccessStatusCode)
                {
                    counter = int.TryParse(await response.Content.ReadAsStringAsync(), out int number) ? number : -1;

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
