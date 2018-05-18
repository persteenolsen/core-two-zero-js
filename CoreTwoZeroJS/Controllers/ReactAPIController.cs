using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreTwoZeroJS.Controllers
{

    [Route("ReactAPI")]
    public class ReactAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}