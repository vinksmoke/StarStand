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
    
    public partial class Servicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicos()
        {
            this.Pecas1 = new HashSet<Pecas>();
        }
    
        public int IdServicos { get; set; }
        public string Nome { get; set; }
        public bool Pecas { get; set; }
        public double ValorHora { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pecas> Pecas1 { get; set; }
    }
}
