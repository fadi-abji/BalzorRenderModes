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

        public async  Task<int> Increment(int counter)
        {
            return await counterApi.Increment(counter);
        }
    }
}
