using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GradFIlmaProjekat.Controllers
{
    public class RezervacijaController : Controller
    {
        //
        // GET: /Account/Rezervacija
        [AllowAnonymous]
        public ActionResult Rezervacija()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Rezervacija(GradFilmaModel.Rezervacija model)
        {
            if (ModelState.IsValid)
            {
               // var rezervacija = new GradFilmaModel.Rezervacija();
               // var result = await UserManager.CreateAsync(user, model.Password);
               // if (result.Succeeded)
                {
                  
                    return RedirectToAction("Index", "Home");
                }
               // AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}