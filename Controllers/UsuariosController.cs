using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Controllers
{
    //[Route("[controller]/[action]")]
    public class UsuariosController : Controller
    {

        //[HttpGet]
        //[Route("/Usuarios/Matias")]
        //[Route("[controller]/[action]/{data:double}")]
        public IActionResult Index(double data){
            var url= Url.Action("Metodo","Usuarios");
            //return View(data);
            //return Content(url);
            return Redirect(url);
        }

         public IActionResult Metodo(){
            return View();
        }
    }
}