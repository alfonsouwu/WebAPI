namespace WebAPI.Class
{
    public class usuarios
    {
        public int id { get; set; }
        public string usuario { get; set; } = "";
        public string password { get; set; } = "";
        public string nombre { get; set; } = "";
        public string comentarios { get; set; } = "";
        public bool activo_sn { get; set; }
        public int id_entidad { get; set; }
        public DateTime fecha_ultima_modificacion { get; set; }
        public int usuario_ultima_modificacion { get; set; }
        public DateTime fecha_alta_registro { get; set; }
        public int usuario_alta_registro { get; set; }
        public int id_persona { get; set; }
    }
}