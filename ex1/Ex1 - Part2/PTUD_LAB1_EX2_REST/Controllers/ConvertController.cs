using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PTUD_LAB1_EX2_REST.Controllers
{
    public class ConvertController : ApiController
    {
        public const int R_EARTH = 6371;
        [HttpGet]
        public double Distance(double Latitude1, double Longitude1, double Latitude2, double Longitude2)
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
