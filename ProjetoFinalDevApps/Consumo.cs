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
    
    public partial class Consumo
    {
        public int Id { get; set; }
        public double QuantidadeMedia { get; set; }
        public int ArranjoId { get; set; }
    
        public virtual Arranjo Arranjo { get; set; }
        public virtual StockMateriais StockMateriais { get; set; }
    }
}