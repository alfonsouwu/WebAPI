using Microsoft.AspNetCore.Mvc;
using WebAPI.Resources;
using System.Data;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        #region Logger
        private readonly ILogger<UsuariosController> _logger;

        public UsuariosController(ILogger<UsuariosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        #endregion

        #region CRUD         
        [HttpGet(Name = "GetUsuarios")]
        public dynamic ListaUsuarios()
        {

            List<Parametro> parametros = new List<Parametro>{
                new Parametro("id", "0")
            };

            DataTable dt = DataBase.Listar("sp_se_usuarios",parametros);
            string json = JsonConvert.SerializeObject(dt);

            return new            
            {
                success = true,
                message = "exito",
                result = new
                {
                    usuarios = json 
                }
            };
                
        }

        #endregion
    }
}