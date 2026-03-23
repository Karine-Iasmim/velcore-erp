using Microsoft.AspNetCore.Mvc;
using Velcore.ERP.Web.ViewModels.Acesso;

namespace Velcore.ERP.Web.Controllers.Acesso
{
    [Route("Acesso/[action]")]
    public class AutenticacaoController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // LOGIN FAKE (temporário)
            if (model.Email == "admin@velcore.com" && model.Senha == "123456")
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos.");
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
