using BalzorRenderModes.Services;

namespace BalzorRenderModes.Api
{
    public class CounterServerSide : ICounterApi
    {
        private readonly ICounterService counterService;
        public CounterServerSide(ICounterService counterService)
        {
            this.counterService = counterService;
        }

        public async Task<int> Increment(int counter)
        {
            return counterService.Increment(counter);
        }
    }
}
