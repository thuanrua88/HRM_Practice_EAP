using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HRM_Practice.Models;

namespace HRM_Practice.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository repository;

        public IActionResult Index() => View(repository.Employees);
    }
}
