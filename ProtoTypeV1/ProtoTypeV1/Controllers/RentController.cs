using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProtoTypeV1.Controllers
{
    public class RentController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
