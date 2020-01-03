using Newtonsoft.Json;
using RELPREMEE.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RELPREMEE.Services
{
    public class DataService
    {
        private readonly static HttpClient Client = new HttpClient();
        private readonly string Uri = "http://relpremee.somee.com/api/Events";

        public async Task<List<Event>> GetAllEventsAsync()
        {
            try
            {
                Client.CancelPendingRequests();
                var result = await Client.GetAsync(Uri);
                List<Event> events = JsonConvert.DeserializeObject<List<Event>>(result.Content.ReadAsStringAsync().Result);
                return events;
            }
            catch
            {
                throw;
            }
        }


    }
}
