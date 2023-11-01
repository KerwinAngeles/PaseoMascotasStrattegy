using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoMascotas
{
    public class HuskySiberiano : IPaseo
    {
        public void ValorPaseo()
        {
            Console.WriteLine("Duracion del paseo: 60 minutos");
            Console.WriteLine("Costo del paseo: 300$RD");
        }
    }
}
