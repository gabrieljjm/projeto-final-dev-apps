﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RetrosariaModelContainer : DbContext
    {
        public RetrosariaModelContainer()
            : base("name=RetrosariaModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> ClienteSet { get; set; }
        public virtual DbSet<Pedido> PedidoSet { get; set; }
        public virtual DbSet<Trabalho> TrabalhoSet { get; set; }
        public virtual DbSet<Devolucao> DevolucaoSet { get; set; }
        public virtual DbSet<PecaArranjo> PecaArranjoSet { get; set; }
        public virtual DbSet<Arranjo> ArranjoSet { get; set; }
        public virtual DbSet<Peca> PecaSet { get; set; }
        public virtual DbSet<Consumo> ConsumoSet { get; set; }
        public virtual DbSet<StockMateriais> StockMateriaisSet { get; set; }
        public virtual DbSet<Fornece> ForneceSet { get; set; }
        public virtual DbSet<Fornecedor> FornecedorSet { get; set; }
    }
}
