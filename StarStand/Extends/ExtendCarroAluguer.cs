using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStand
{
   public partial class CarroAluguer
    {
        public override string ToString()
        {
            return Marca + "-" + Modelo + "(" + Estado + ")";
        }
    }
}
