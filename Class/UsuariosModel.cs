using WebAPI.Resources;
using System.Data;
using Newtonsoft.Json;

namespace WebAPI.Class
{
    public class UsuariosModel
    {
        public static DataTable listaUsuarios(int id = 0)
        {

            List<Parametro> parametros = new List<Parametro>{
                new Parametro("id", id.ToString())
            };

            DataTable dt = DataBase.Listar("sp_se_usuarios",parametros);
            string jsonUsuarios = JsonConvert.SerializeObject(dt);

            return dt;               
        }

        public static DataTable UIUsuarios(usuarios Usuarios)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("id",Usuarios.id.ToString()),
                new Parametro("usuario", Usuarios.usuario.ToString()),
                new Parametro("password", Usuarios.password.ToString()),
                new Parametro("id_persona", Usuarios.id_persona.ToString()),
                new Parametro("nombre", Usuarios.nombre.ToString()),
                new Parametro("comentarios", Usuarios.comentarios.ToString()),
                new Parametro("activo_sn", Usuarios.activo_sn.ToString()),
                new Parametro("id_entidad", Usuarios.id_entidad.ToString()),
                new Parametro("usuario_ultima_modificacion", Usuarios.usuario_ultima_modificacion.ToString())
            };

            DataTable dt = DataBase.Listar("sp_ui_usuario",parametros);

            return dt;
        }
    }
}