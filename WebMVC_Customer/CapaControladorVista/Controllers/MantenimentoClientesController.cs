using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaControladorVista.Controllers
{
    public class MantenimentoClientesController : Controller
    {
        // GET: /MantenimentoClientes/
        readonly IOperacion _operacion;
        //IContexto contexto = new Contexto();
        public MantenimentoClientesController(IOperacion operacion)
        {

            this._operacion = operacion;
        }

        public ActionResult Index()
        {
            return View(_operacion.GetAll().ToList());
        }

        public ActionResult Create(Cliente cliente)
        {

            if(cliente.Nombre != null)
            {
                var cl = _operacion.Add(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);

        }

        public ActionResult Edit(int id)
        {
            Cliente cliente = _operacion.Get(id);
            if(cliente.Id != null)
            {
                return View(cliente);
            }

            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (cliente != null)
            {
                _operacion.Update(cliente);
                return RedirectToAction("Index");
            }

            return HttpNotFound();
        }

        public ActionResult Remove(Cliente cliente)
        {
            if (cliente != null)
            {
                _operacion.Delete(cliente);
                return RedirectToAction("Index");
            }

            return HttpNotFound();
        }

        public ActionResult Details(int id)
        {
            Cliente cliente = _operacion.Get(id);
            if (cliente.Id != null)
            {
                return View(cliente);
            }

            return HttpNotFound();
        }

        //public ActionResult GetClientes()
        //{
        //    var listClientes = _operacion;
        //}
    }
}
