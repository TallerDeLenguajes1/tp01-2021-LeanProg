using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using NLog;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
     
        public int Division(int a, int b)
        {
            int division;
            
            try
            {
               division=a/b;
               return division;

            }
            catch (Exception ex)
            {
                //string error = ex.Message;
                logger.Error(ex.Message);
               throw ex;
                // Console.Write("Error: " + error);

            }
          
           
        }

        public int CalcularCuadrado(int a)
        {
            try
            {
                a=a*a;
                return a;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                throw ex;
            }
            
        }

        public float Problema4(int a,int b)
        {
            try
            {
                float kilometros=b*a;
                return kilometros;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                throw ex;
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
