using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoMascotas
{
    public class Labrador : IPaseo
    {
        
        public void ValorPaseo()
        {
            Console.WriteLine("Duracion del paseo: 40 minutos");
            Console.WriteLine("Costo 200$RD");
        }
    }
}
