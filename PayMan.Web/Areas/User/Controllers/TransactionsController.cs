using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PayMan.Web.Areas.User.Controllers
{
    [Area("User")]
    //[Authorize(Roles = "User")]
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}