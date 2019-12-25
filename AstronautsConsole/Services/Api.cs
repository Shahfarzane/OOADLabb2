using System;
using System.Collections.Generic;
using System.Net.Http;
using AstronautsConsole.Data.Repository;
using AstronautsConsole.Domain;
using AstronautsConsole.Domain.Entities;
using Newtonsoft.Json;

namespace AstronautsConsole.Services
{
    public class Api : IAstronautRepository
    {
        public List<Astronaut> GetAstronauts()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync("http://api.open-notify.org/astros.json").Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<AstronautRepository>(result).People;
            }

            return null;
        }
    }
}