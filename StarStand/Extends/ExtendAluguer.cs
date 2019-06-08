using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStand
{
    public partial class Aluguer
    {
        public override string ToString()
        {

            StarDBContainer bd = new StarDBContainer();
            Utilizadores user=bd.UtilizadoresSet.Where(id => id.IdUtilizador == UtilizadoresIdUtilizador).First();
            if (Kms==null)
            {
                return DataInicio + "" + user.Nome;
            }
            else
            {
                return "(Concluido)-" + user.Nome + "-" + Valor;
            }

        }
    }
}
