using Microsoft.AspNetCore.Mvc;

namespace Desenvolvimento.Controllers
{
    public class ProtocoloController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }
    }
}
