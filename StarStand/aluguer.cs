//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarStand
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aluguer
    {
        public int IdAluguer { get; set; }
        public System.DateTime DataInicio { get; set; }
        public Nullable<System.DateTime> DataFim { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Kms { get; set; }
        public int UtilizadoresIdUtilizador { get; set; }
        public int CarroAluguerId { get; set; }
    
        public virtual Utilizadores Utilizadores { get; set; }
        public virtual CarroAluguer CarroAluguer { get; set; }
    }
}
