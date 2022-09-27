using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
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
        public int CUADRADO(int Lado)
        {
            return Lado * Lado;
        }
        [WebMethod]
        public int TRIANGULO(int Base, int Altura)
        {
            return Base * Altura / 2;
        }
        
        [WebMethod]
        public double CIRCULO(double Radio)
        {
            const double PI = 3.14;
            return PI * Radio * Radio;
        }
    }
}
