using Olivas.Numeros.DAO;
using Olivas.Numeros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Olivas.Numeros.Controllers
{
    public class HomeController : Controller
    {
        private ClienteDAO clienteDAO;
        public HomeController(ClienteDAO clienteDAO)
        {
            this.clienteDAO = clienteDAO;
        }

        public ActionResult Index()
        {
            return View(clienteDAO.Lista());
        }
        
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Calcula(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var calculo = new Calculo();
                calculo.CalcularCliente(cliente);

                clienteDAO.Adiciona(cliente);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", cliente);
            }
        }
    }
}