using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoMascotas
{
    public class Chihuahua : IPaseo
    {
        public void ValorPaseo()
        {
            Console.WriteLine("Duracion del paseo: 20 minutos");
            Console.WriteLine("Costo del paseo 100$RD");
        }
    }
}
