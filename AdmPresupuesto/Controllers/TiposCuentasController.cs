using AdmPresupuesto.Models;
using AdmPresupuesto.Servicios;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AdmPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        { 
            this.repositorioTiposCuentas = repositorioTiposCuentas;
        }
        public IActionResult Crear()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }

            tipoCuenta.UsuarioId = 1;
            repositorioTiposCuentas.Crear(tipoCuenta);

            return View();
        }
    }
}
