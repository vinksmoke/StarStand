using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStand
{
    public partial class CarroOficina 
    {
        public override string ToString()
        {
            return Marca + " - " + Modelo + "(" + Matricula + ")";
        }
    }
}
