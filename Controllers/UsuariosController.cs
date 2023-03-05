using Microsoft.AspNetCore.Mvc;
using WebAPI.Resources;
using System.Data;
using Newtonsoft.Json;
using WebAPI.Class;
namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        #region CRUD         

        [HttpGet(Name = "Lista Usuarios")]
        public dynamic UsuariosGet(int id = 0)
        {
            DataTable dt = UsuariosModel.Usuarios_Get(id);
            string jsonUsuarios = JsonConvert.SerializeObject(dt);

            return new            
            {
                success = true,
                message = "exito",
                result = new
                {
                    usuarios = JsonConvert.DeserializeObject<List<usuarios_class>>(jsonUsuarios) 
                }
            };                
        }

        [HttpPost(Name = "Actualiza o inserta Usuarios")]
        public dynamic UsuarioUI(usuarios_class Usuarios) 
        {        
            DataTable dt = UsuariosModel.Usuarios_IU(Usuarios);
            string jsonUsuarios = JsonConvert.SerializeObject(dt);

            return new            
            {
                success = true,
                message = "exito",
                result = new
                {
                    usuarios = JsonConvert.DeserializeObject<List<usuarios_class>>(jsonUsuarios) 
                }
            };
        }
        #endregion
    }
}