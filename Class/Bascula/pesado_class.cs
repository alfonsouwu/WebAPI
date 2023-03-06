using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Class.Bascula
{
    public class pesado_class
    {        
        public int id { get; set; }        
        public string folio { get; set; } = "";
        public int id_producto_servicio { get; set; }
        public int id_proveedor { get; set; }
        public int id_transporte { get; set; }        
        public int id_tipo_peso { get; set; }        
        public decimal cantidad { get; set; }
        public string comentarios { get; set; } = "";
        public bool activo_sn { get; set; }
        public int id_entidad { get; set; }
        public DateTime fecha_ultima_modificacion { get; set; }
        public int usuario_ultima_modificacion { get; set; }
        public DateTime fecha_alta_registro { get; set; }
        public int usuario_alta_registro { get; set; }  
    }
}