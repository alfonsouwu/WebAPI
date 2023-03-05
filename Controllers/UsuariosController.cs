using Microsoft.AspNetCore.Mvc;
using WebAPI.Resources;
using System.Data;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
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