//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoFinalDevApps
{
    using System;
    using System.Collections.Generic;
    
    public partial class Peca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Peca()
        {
            this.PecaArranjo = new HashSet<PecaArranjo>();
        }
    
        public int Id { get; set; }
        public string TipoPeca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PecaArranjo> PecaArranjo { get; set; }
    }
}
