using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreTwoZeroJS.Controllers
{
    public class AdminPersonsController : Controller
    {
        [Route("AdminPersons")]
        public IActionResult Index()
        {
            return View();
        }
    }
}