using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAMHS.UI.Models
{
    public class Deposito
    {
        public string confirmacion { get; set; }
        public Exception error { get; set; }
        public void SubirArchivo ( String ruta, HttpPostedFileBase file)
        {
            try
            {
                file.SaveAs(ruta);
                this.confirmacion = "Recibo del depósito enviado";
            }
            catch (Exception ex)
            {

                this.error = ex;
            }
        }
    }
}