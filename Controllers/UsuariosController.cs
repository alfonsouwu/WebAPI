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

        [HttpGet(Name = "GetUsuarios")]
        public dynamic GetUsuarios(int id = 0)
        {

            List<Parametro> parametros = new List<Parametro>{
                new Parametro("id", id.ToString())
            };

            DataTable dt = DataBase.Listar("sp_se_usuarios",parametros);
            string jsonUsuarios = JsonConvert.SerializeObject(dt);

            return new            
            {
                success = true,
                message = "exito",
                result = new
                {
                    usuarios = JsonConvert.DeserializeObject<List<usuarios>>(jsonUsuarios) 
                }
            };                
        }

        [HttpPost(Name = "PutUsuario")]
        public dynamic PutUsuario(string usuario , string password , int id_persona , string nombre, int id_entidad, int usuario_ultima_modificacion,int id = 0,string comentarios = "", bool activo_sn = true){
            
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("id", id.ToString()),
                new Parametro("usuario", usuario),
                new Parametro("password", password),
                new Parametro("id_persona", id_persona.ToString()),
                new Parametro("nombre", nombre),
                new Parametro("comentarios", comentarios),
                new Parametro("activo_sn", activo_sn.ToString()),
                new Parametro("id_entidad", id_entidad.ToString()),
                new Parametro("usuario_ultima_modificacion", usuario_ultima_modificacion.ToString())
            };

            DataTable dt = DataBase.Listar("sp_ui_usuario",parametros);
            string jsonUsuarios = JsonConvert.SerializeObject(dt);

            return new            
            {
                success = true,
                message = "exito",
                result = new
                {
                    usuarios = JsonConvert.DeserializeObject<List<usuarios>>(jsonUsuarios) 
                }
            };
        }
        #endregion
    }
}