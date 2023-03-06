using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json;
using WebAPI.Class.Bascula;
namespace WebAPI.Controllers.Bascula
{
    [Route("[controller]")]
    public class PesadoController : Controller
    {
        #region CRUD         

        [HttpGet(Name = "Lista Pesados")]
        public dynamic PesadosGet(string folio = "" , int id = 0)
        {
            try
            {
                DataTable dt = PesadoModel.Pesados_Get(folio,id);
                string jsonPesados = JsonConvert.SerializeObject(dt);

                return new            
                {
                    success = true,
                    message = "éxito",
                    result = new
                    {
                        usuarios = JsonConvert.DeserializeObject<List<pesado_class>>(jsonPesados) 
                    }
                };
            }
            catch (Exception ex){
                return new            
                {
                    success = false,
                    message = "Error",
                    result = new
                    {
                        error = ex.ToString() 
                    }
                };
            }
        }

        [HttpPost(Name = "Actualiza o inserta pesados")]
        public dynamic PesadoUI(pesado_class Pesados) 
        {
            try
            {
                DataTable dt = PesadoModel.Pesado_IU(Pesados);
                string jsonPesados = JsonConvert.SerializeObject(dt);
                
                return new            
                {
                    success = true,
                    message = "éxito",
                    result = new
                    {
                        usuarios = JsonConvert.DeserializeObject<List<pesado_class>>(jsonPesados) 
                    }
                };                
            }
            catch (Exception ex)
            {
                return new            
                {
                    success = false,
                    message = "Error",
                    result = new
                    {
                        error = ex.ToString() 
                    }
                };
            }        
            
        }

       
        #endregion
    }
}