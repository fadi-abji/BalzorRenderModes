namespace BalzorRenderModes.Api
{
    public interface ICounterApi
    {
        Task<int> Increment(int counter);
    }
}
