using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using n00033054app.Models;
using n00033054app.Repositorios;

namespace n00033054app.Controllers
{
    public class CuentaController : Controller
    {
        private readonly ICuentaRepositorio contextoCuenta;

        public  CuentaController(ICuentaRepositorio contextoCuenta)
        {
            this.contextoCuenta = contextoCuenta;
        }

        // GET: CuentaController
        public ActionResult Index()
        {
            ViewBag.listacuentas = contextoCuenta.listaCuentas();
            return View();
        }

        // GET: CuentaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentaController/Create
        public ActionResult Create()
        {
            
            return View(new Cuenta());
        }

        // POST: CuentaController/Create
        [HttpPost]
        public ActionResult Create(Cuenta cuenta)
        {
            if (cuenta.nombre == "")
            {
                ModelState.AddModelError("nombre", "El nombre es obligatorio");
            }
            if (cuenta.categoria == "")
            {
                ModelState.AddModelError("categoria", "La categoria es obligatorio");
            }
            if (cuenta.saldoini == null)
            {
                ModelState.AddModelError("saldoini", "El saldo inicial es obligatorio");
            }
            if (cuenta.moneda == null)
            {
                ModelState.AddModelError("moneda", "El moneda es obligatorio");
            }

            if (ModelState.IsValid)
            {
                contextoCuenta.crear(cuenta);
                return RedirectToAction(nameof(Index));
            }
                
            return View(cuenta);
        }

        // GET: CuentaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
