using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStand
{
    public partial class Venda
    {
        public override string ToString()
        {
            return "("+Data+")"+CarroVenda.Marca+"-"+CarroVenda.Modelo;
        }
    }
}
