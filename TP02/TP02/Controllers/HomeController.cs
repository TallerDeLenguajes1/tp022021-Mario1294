using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP02.Models;
using System.IO;

namespace TP02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Hello, this is the index!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public string empleado(string nYa, int dni, DateTime fechaNac, string direccion, DateTime fechaIngr)
        {
            try
            {
                Empleados miEmpleados = new Empleados();
                miEmpleados.crearEmpleado(nYa, fechaNac, dni, direccion, fechaIngr);
                return "Apellido y Nombre: " + miEmpleados.ApellidoYnombre + "Edad: " + miEmpleados.Edad + "Antiguedad: " + miEmpleados.Antiguedad + "Salario: " + miEmpleados.Salario;
            }
            catch (Exception Error)
            {
                return Error.Message;
            }
         }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
