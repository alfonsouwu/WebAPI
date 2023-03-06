using WebAPI.Resources;
using System.Data;
using Newtonsoft.Json;

namespace WebAPI.Class.Sys
{
    public class UsuariosModel
    {
        public static DataTable Usuarios_Get(int id = 0)
        {

            List<Parametro> parametros = new List<Parametro>{
                new Parametro("id", id.ToString())
            };

            DataTable dt = DataBase.Listar("sp_se_usuarios",parametros);
            return dt;               
        }

        public static DataTable Usuarios_IU(usuarios_class Usuarios)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("id",Usuarios.id.ToString()),
                new Parametro("id_perfil",Usuarios.id_perfil.ToString()),                            
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

        public static DataTable Usuario_Delete(int id, int id_persona)
        {
             List<Parametro> parametros = new List<Parametro>{
                new Parametro("id", id.ToString()),
                new Parametro("id_persona", id_persona.ToString())
            };

            DataTable dt = DataBase.Listar("sp_del_usuarios",parametros);
            return dt;
        }
    }
}