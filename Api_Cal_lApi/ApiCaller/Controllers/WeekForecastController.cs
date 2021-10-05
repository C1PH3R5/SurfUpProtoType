using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using ApiCaller.Models;
using System.Text.Json;

namespace ApiCaller.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeekForecastController : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();
        
        [HttpGet]
        public async Task<IActionResult> GetWeekForecast()
        {
            var response = await client.GetAsync("https://api.openweathermap.org/data/2.5/forecast?q=Kolding&units=metric&appid=6bffa8dec9dc4800d583b41bddcdf65a");
            response.EnsureSuccessStatusCode();
            string rawData = await response.Content.ReadAsStringAsync();

            ForecastRoot JSonObject = JsonSerializer.Deserialize<ForecastRoot>(rawData);

            return Ok(JSonObject);
        }

    }
}
