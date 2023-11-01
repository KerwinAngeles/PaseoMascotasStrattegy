using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoMascotas
{
    public class Contexto
    {
        IPaseo paseo;

        public Contexto(IPaseo objecto)
        {
            paseo = objecto;
        }

        public void EjecutaValorPaseo()
        {
            paseo.ValorPaseo();
        }
    }
}
