using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt1_Podorozhnyi_50402.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }
    }
}
