﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStand
{
    public partial class Servicos
    {
        public override string ToString()
        {
            if (DataSaida == null )
                return Nome + "(" + DataEntrada + ")";
            else
                return Nome + "(Concluido)";
        }
    }
}