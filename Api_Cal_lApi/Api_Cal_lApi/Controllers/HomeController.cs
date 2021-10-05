using Api_Cal_lApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;


namespace Api_Cal_lApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static readonly HttpClient client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await client.GetAsync("https://localhost:44334/OpenWeather");
            //response.EnsureSuccessStatusCode();
            string rawData = await response.Content.ReadAsStringAsync();

            ApiWeatherData JSonObject = JsonSerializer.Deserialize<ApiWeatherData>(rawData);
            ViewBag.ApiWeatherData = JSonObject;
            return View(JSonObject);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpGet]
        //public async Task<IActionResult> GetOwnApiData()
        //{
        //    var response = await client.GetAsync("https://localhost:44334/OpenWeather");
        //    //response.EnsureSuccessStatusCode();
        //    string rawData = await response.Content.ReadAsStringAsync();

        //    ApiWeatherData JSonObject = JsonSerializer.Deserialize<ApiWeatherData>(rawData);
        //    ViewBag.ApiWeatherData = JSonObject;
        //    return Ok(JSonObject);
        //}
    }
}
