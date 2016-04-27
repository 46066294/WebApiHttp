using Servicio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;

namespace WebApiMVC4.Controllers
{
    public class ClientController : ApiController
    {
        readonly IOperacion _operacion;
        public ClientController(IOperacion operacion) 
        {
            this._operacion = operacion;
        }

        public IEnumerable<Cliente> Get()
        {
            return _operacion.GetAll().ToList();
        }

        public Cliente Get(int id)
        {
            var cliente = _operacion.Get(id);
            return cliente;
        }

        public void Post([FromBody]Cliente cliente) 
        {
            
        }
    }
}