using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PaseoMascotas
{
    public class Fabrica
    {
        public static IPaseo paseo(string opc)
        {
            switch (opc)
            {
                case "C":
                    return new Chihuahua();
                case "L":
                    return new Labrador(); 
                case "H":
                    return new HuskySiberiano();
                default:
                    return new Chihuahua();
            }
        }
    }
}
