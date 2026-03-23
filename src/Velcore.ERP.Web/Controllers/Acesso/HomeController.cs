using Microsoft.AspNetCore.Mvc;

namespace Velcore.ERP.Web.Controllers.Acesso
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
