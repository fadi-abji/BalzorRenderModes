using Microsoft.JSInterop.WebAssembly;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text;
using static System.Net.WebRequestMethods;
using BlazorRenderModes.Client.Models;
using Newtonsoft.Json;

namespace BlazorRenderModes.Client.Api
{
    public class CounterClientService
    {
        public HttpClient httpClient { get; set; }
        public CounterClientService(HttpClient httpClient)
        {
                this.httpClient = httpClient;
        }


        //public async Task<int> Increment(int counter)
        //{
        //    try
        //    {
        //        var address = httpClient.BaseAddress + $"api/counter/increment?counter={counter}";
        //        HttpResponseMessage? response = await httpClient.GetAsync(address);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var result = int.TryParse(await response.Content.ReadAsStringAsync(), out int number) ? number : -1;
        //            return result;
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //}

        public async Task<Counter> Increment(Counter counter)
        {
            try
            {
                //Counter updatedCounter = await httpClient.GetFromJsonAsync<Counter>($"api/counter/increment{counter.Value}");

                //if (updatedCounter != null)
                //{
                //    return updatedCounter ?? new Counter { Value = -1, Name = string.Empty }; 
                //}
                //else
                //{
                //    return new Counter { Value = -1, Name = string.Empty }; 
                //}

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
