using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PTUD_LAB1_EX2_REST
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public const int R_EARTH = 6371;
        [WebMethod]
        public double DistanceBetween2Point(double Latitude1, double Longitude1, double Latitude2, double Longitude2)
        {
            double dLat = (Latitude2 - Latitude1) * (Math.PI / 180);
            double dLon = (Longitude2 - Longitude1) * (Math.PI / 180);
            double la1ToRad = Latitude1 * (Math.PI / 180);
            double la2ToRad = Latitude2 * (Math.PI / 180);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(la1ToRad)
            * Math.Cos(la2ToRad) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R_EARTH * c;
            return d;
        }
    }
}
