using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Areas.Usuario.Controllers
{
    [Area("Usuario")]
    public class UsuarioController : Controller
    {

        public IActionResult Usuario(){
            return View();
        }
        
    }
}