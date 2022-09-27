using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CALCULA_AREAS_CTC
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

       
        [WebMethod]
        public int CUADRADO(int lado)
        {
            return lado * lado;
        }
        [WebMethod]
        public int TRIANGULO(int B, int A)
        {
            return B * A / 2;
        }
        [WebMethod]
        public double CIRCULO(double Radio)
        {
            return 3.1416 * Radio * Radio;
        }
    }
}
