
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
    
public partial class CarroOficina : Carros
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CarroOficina()
    {

        this.HistoricoServicos = new HashSet<HistoricoServicos>();

    }


    public int IdCarroOficina { get; set; }

    public double Kms { get; set; }

    public int UtilizadoresIdUtilizador { get; set; }



    public virtual Utilizadores Utilizadores { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HistoricoServicos> HistoricoServicos { get; set; }

}

}
