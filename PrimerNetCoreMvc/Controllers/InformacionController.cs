using Microsoft.AspNetCore.Mvc;
using PrimerNetCoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCoreMvc.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            //ViewData["Nombre"] = "Alumno";
            //ViewData["Edad"] = 28;

            Persona person = new Persona();
            person.Nombre = "Persona Model";
            person.Edad = 44;
            person.Email = "personamodel@gmail.com";
            return View(person);
        }

        public IActionResult VistaControllerGet
            (string app, int version)
        {
            ViewData["DATOS"] = app + ", Versión: " + version;
            return View();
        }

        //METODO GET
        public IActionResult VistaPost()
        {
            return View();
        }

        //METODO POST
        [HttpPost]
        public IActionResult VistaPost
            (Persona persona)
        {
            return View(persona);
        }

        //GET VistaNumeroDoble
        public IActionResult VistaNumeroDoble(int numero)
        {
            int doble = numero * 2;
            ViewBag.Doble = "El doble del número es: " + doble;
            return View();
        }
    }
}
