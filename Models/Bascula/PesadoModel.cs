using WebAPI.Resources;
using System.Data;
using WebAPI.Class.Bascula;

namespace WebAPI.Class.Bascula
{
    public class PesadoModel
    {
        public static DataTable Pesados_Get(string folio, int id = 0)
        {

            List<Parametro> parametros = new List<Parametro>{
                new Parametro("id", id.ToString()),
                new Parametro("folio", folio)
            };

            DataTable dt = DataBase.Listar("sp_se_pesado",parametros);
            return dt;               
        }

        public static DataTable Pesado_IU(pesado_class Pesado)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("id", Pesado.id.ToString()),
                new Parametro("folio", Pesado.folio.ToString()),
                new Parametro("id_producto_servicio", Pesado.id_producto_servicio.ToString()),
                new Parametro("id_proveedor", Pesado.id_proveedor.ToString()),
                new Parametro("id_transporte", Pesado.id_transporte.ToString()),
                new Parametro("id_tipo_peso", Pesado.id_tipo_peso.ToString()),
                new Parametro("cantidad", Pesado.cantidad.ToString()),
                new Parametro("comentarios", Pesado.comentarios.ToString()),
                new Parametro("activo_sn", Pesado.activo_sn.ToString()),
                new Parametro("id_entidad", Pesado.id_entidad.ToString()),
                new Parametro("usuario_ultima_modificacion", Pesado.usuario_ultima_modificacion.ToString())

            };

            DataTable dt = DataBase.Listar("sp_ui_pesado",parametros);
            return dt;
        }

        public static DataTable Pesado_Delete(int id, int id_persona)
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