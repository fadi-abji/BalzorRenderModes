using System.Runtime.CompilerServices;

namespace BalzorRenderModes.Services
{

    public class CounterService : ICounterService
    {
        public int Increment(int counter)
        {
            return ++counter; 
        }
    }
}
