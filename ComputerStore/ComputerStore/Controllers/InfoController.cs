using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_ComputerStore.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Contacts() => View("Contacts");
        public IActionResult Delivery() => View("Delivery");
        public IActionResult Guarantee() => View("Guarantee");
        public IActionResult Payment() => View("Payment");
    }
}
