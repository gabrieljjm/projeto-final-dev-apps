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
    
    public partial class Trabalho
    {
        public int Id { get; set; }
        public string DescricaoPeca { get; set; }
        public string CorPeca { get; set; }
        public double ValorPago { get; set; }
        public bool Pago { get; set; }
        public bool Levantado { get; set; }
        public System.DateTime DataLevantamento { get; set; }
        public string Observacoes { get; set; }
        public int PedidoTabeladoId { get; set; }
        public Nullable<int> DevolucaoId { get; set; }
    
        public virtual PedidoTabelado PedidoTabelado { get; set; }
        public virtual Devolucao Devolucao { get; set; }
        public virtual PecaArranjo PecaArranjo { get; set; }
    }
}
