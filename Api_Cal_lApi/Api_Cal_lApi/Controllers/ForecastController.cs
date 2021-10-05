using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Cal_lApi.Models;
using System.Net.Http;
using System.Text.Json;

namespace Api_Cal_lApi.Controllers
{
    public class ForecastController : Controller
    {
        static readonly HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {
            var response = await client.GetAsync("https://localhost:44334/WeekForecast");
            //response.EnsureSuccessStatusCode();
            string rawData = await response.Content.ReadAsStringAsync();

            WeekForecastRoot JSonObject = JsonSerializer.Deserialize<WeekForecastRoot>(rawData);
            ViewBag.WeekForecastRoot = JSonObject;
            return View(JSonObject);
        }
    }
}
