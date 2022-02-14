using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("")]
    public IActionResult Index()
    {
      if (HttpContext.Session.GetInt32("count") == null)
      {
        HttpContext.Session.SetInt32("count", 1);
      }
      else
      {
        int? temp = HttpContext.Session.GetInt32("count");
        temp += 1;
        HttpContext.Session.SetInt32("count", (int)temp);
      }

      PasscodeGen passcode = new PasscodeGen();
      passcode.Passcode();

      return View("Index", passcode);
    }

  }
}
