using BalzorRenderModes.Api;

namespace BlazorRenderModes.Client.Services
{
    public class CounterClientService
    {
        private readonly ICounterApi counterApi;
        public CounterClientService( ICounterApi counterApi)
        {
            this.counterApi = counterApi;
        }

        //private readonly HttpClient httpClient;
        //public CounterClientService(HttpClient httpClient, ICounterApi counterApi)
        //{
        //    this.counterApi = counterApi;
        //    this.httpClient = httpClient;
        //}

        public async  Task<int> Increment(int counter)
        {
            return await counterApi.Increment(counter);
        }
    }
}
