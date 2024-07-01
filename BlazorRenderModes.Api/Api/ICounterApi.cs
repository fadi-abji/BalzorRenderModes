namespace BalzorRenderModes.Api
{
    public interface ICounterApi
    {
        HttpClient HttpClient { get; set; }
        Task<int> Increment(int counter);
    }
}
