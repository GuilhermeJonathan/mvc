using GCN.Aplicacao.GestaoDeClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCN.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicoDeGestaoDeClientes _servicoDeGestaoDeClientes;

        public ClienteController(IServicoDeGestaoDeClientes servicoDeGestaoDeClientes)
        {
            this._servicoDeGestaoDeClientes = servicoDeGestaoDeClientes;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}