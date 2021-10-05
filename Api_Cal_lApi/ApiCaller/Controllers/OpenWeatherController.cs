using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ApiCaller.Models;
using System.Text.Json;

namespace ApiCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenWeatherController : ControllerBase
    {

        static readonly HttpClient client = new HttpClient();

        [HttpGet]
        public async Task<IActionResult> GetOpenWeatherData()
        {

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/weather?q=Kolding&appid=6bffa8dec9dc4800d583b41bddcdf65a");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header


            //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "relativeAddress");
            //request.Content = new StringContent("openweather", Encoding.UTF8, "application/json");//CONTENT-TYPE header


            //await client.SendAsync(request).ContinueWith(responseTask => {
            //        return Ok(("Response: {0}", responseTask.Result));
            //        });



            var response = await client.GetAsync("https://api.openweathermap.org/data/2.5/onecall?lat=55.432247&lon=8.346690&units=metric&exclude=minutely,hourly,daily&appid=6bffa8dec9dc4800d583b41bddcdf65a");
            //response.EnsureSuccessStatusCode();
            string rawData = await response.Content.ReadAsStringAsync();

            WeatherData JSonObject = JsonSerializer.Deserialize<WeatherData>(rawData);
            
            return Ok(JSonObject);
        }
    }
}

