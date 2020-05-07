
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2020 18:02:55
-- Generated from EDMX file: D:\Git\ProjetoFinalDevApps\ProjetoFinalDevApps\ProjetoFinalDevApps\RetrosariaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BD-DevApps];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Codigo_Postal] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Telefone_Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PedidoSet'
CREATE TABLE [dbo].[PedidoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataPedido] datetime  NOT NULL,
    [Pago] nvarchar(max)  NOT NULL,
    [Levantado] nvarchar(max)  NOT NULL,
    [TipoPedido] nvarchar(max)  NOT NULL,
    [Observacoes] nvarchar(max)  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- Creating table 'TrabalhoSet'
CREATE TABLE [dbo].[TrabalhoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DescricaoPeca] nvarchar(max)  NOT NULL,
    [CorPeca] nvarchar(max)  NOT NULL,
    [ValorPago] nvarchar(max)  NOT NULL,
    [Pago] nvarchar(max)  NOT NULL,
    [Levantado] nvarchar(max)  NOT NULL,
    [DataLevantamento] datetime  NOT NULL,
    [Observacoes] nvarchar(max)  NOT NULL,
    [PedidoTabeladoId] int  NOT NULL,
    [DevolucaoId] int  NOT NULL,
    [PedidoTabelado_Id] int  NOT NULL,
    [PecaArranjo_ArranjoId] int  NOT NULL,
    [PecaArranjo_PecaId] int  NOT NULL
);
GO

-- Creating table 'DevolucaoSet'
CREATE TABLE [dbo].[DevolucaoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataDevolucao] datetime  NOT NULL,
    [ValorDevolvido] float  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [PedidoId] int  NOT NULL
);
GO

-- Creating table 'PecaArranjoSet'
CREATE TABLE [dbo].[PecaArranjoSet] (
    [Preco] float  NOT NULL,
    [ArranjoId] int  NOT NULL,
    [PecaId] int  NOT NULL
);
GO

-- Creating table 'ArranjoSet'
CREATE TABLE [dbo].[ArranjoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoArranjo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PecaSet'
CREATE TABLE [dbo].[PecaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoPeca] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConsumoSet'
CREATE TABLE [dbo].[ConsumoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QuantidadeMedia] float  NOT NULL,
    [ArranjoId] int  NOT NULL,
    [StockMateriais_Id] int  NOT NULL
);
GO

-- Creating table 'StockMateriaisSet'
CREATE TABLE [dbo].[StockMateriaisSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QuantAtual] float  NOT NULL,
    [ConsumoMedioDiario] float  NOT NULL,
    [StockMinimo] float  NOT NULL
);
GO

-- Creating table 'ForneceSet'
CREATE TABLE [dbo].[ForneceSet] (
    [Preco] float  NOT NULL,
    [PrazoEntrega] datetime  NOT NULL,
    [StockMateriaisId] int  NOT NULL,
    [FornecedorId] int  NOT NULL
);
GO

-- Creating table 'FornecedorSet'
CREATE TABLE [dbo].[FornecedorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [CodigoPostal] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PedidoSet_PedidoTabelado'
CREATE TABLE [dbo].[PedidoSet_PedidoTabelado] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'PedidoSet_Orcamento'
CREATE TABLE [dbo].[PedidoSet_Orcamento] (
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [Aceite] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [PK_PedidoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TrabalhoSet'
ALTER TABLE [dbo].[TrabalhoSet]
ADD CONSTRAINT [PK_TrabalhoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DevolucaoSet'
ALTER TABLE [dbo].[DevolucaoSet]
ADD CONSTRAINT [PK_DevolucaoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ArranjoId], [PecaId] in table 'PecaArranjoSet'
ALTER TABLE [dbo].[PecaArranjoSet]
ADD CONSTRAINT [PK_PecaArranjoSet]
    PRIMARY KEY CLUSTERED ([ArranjoId], [PecaId] ASC);
GO

-- Creating primary key on [Id] in table 'ArranjoSet'
ALTER TABLE [dbo].[ArranjoSet]
ADD CONSTRAINT [PK_ArranjoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PecaSet'
ALTER TABLE [dbo].[PecaSet]
ADD CONSTRAINT [PK_PecaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsumoSet'
ALTER TABLE [dbo].[ConsumoSet]
ADD CONSTRAINT [PK_ConsumoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StockMateriaisSet'
ALTER TABLE [dbo].[StockMateriaisSet]
ADD CONSTRAINT [PK_StockMateriaisSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [StockMateriaisId], [FornecedorId] in table 'ForneceSet'
ALTER TABLE [dbo].[ForneceSet]
ADD CONSTRAINT [PK_ForneceSet]
    PRIMARY KEY CLUSTERED ([StockMateriaisId], [FornecedorId] ASC);
GO

-- Creating primary key on [Id] in table 'FornecedorSet'
ALTER TABLE [dbo].[FornecedorSet]
ADD CONSTRAINT [PK_FornecedorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet_PedidoTabelado'
ALTER TABLE [dbo].[PedidoSet_PedidoTabelado]
ADD CONSTRAINT [PK_PedidoSet_PedidoTabelado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet_Orcamento'
ALTER TABLE [dbo].[PedidoSet_Orcamento]
ADD CONSTRAINT [PK_PedidoSet_Orcamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[PedidoSet]
    ([ClienteId]);
GO

-- Creating foreign key on [PedidoTabelado_Id] in table 'TrabalhoSet'
ALTER TABLE [dbo].[TrabalhoSet]
ADD CONSTRAINT [FK_PedidoTabeladoTrabalho]
    FOREIGN KEY ([PedidoTabelado_Id])
    REFERENCES [dbo].[PedidoSet_PedidoTabelado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoTabeladoTrabalho'
CREATE INDEX [IX_FK_PedidoTabeladoTrabalho]
ON [dbo].[TrabalhoSet]
    ([PedidoTabelado_Id]);
GO

-- Creating foreign key on [PedidoId] in table 'DevolucaoSet'
ALTER TABLE [dbo].[DevolucaoSet]
ADD CONSTRAINT [FK_PedidoDevolucao]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoDevolucao'
CREATE INDEX [IX_FK_PedidoDevolucao]
ON [dbo].[DevolucaoSet]
    ([PedidoId]);
GO

-- Creating foreign key on [DevolucaoId] in table 'TrabalhoSet'
ALTER TABLE [dbo].[TrabalhoSet]
ADD CONSTRAINT [FK_DevolucaoTrabalho]
    FOREIGN KEY ([DevolucaoId])
    REFERENCES [dbo].[DevolucaoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DevolucaoTrabalho'
CREATE INDEX [IX_FK_DevolucaoTrabalho]
ON [dbo].[TrabalhoSet]
    ([DevolucaoId]);
GO

-- Creating foreign key on [PecaArranjo_ArranjoId], [PecaArranjo_PecaId] in table 'TrabalhoSet'
ALTER TABLE [dbo].[TrabalhoSet]
ADD CONSTRAINT [FK_TrabalhoPecaArranjo]
    FOREIGN KEY ([PecaArranjo_ArranjoId], [PecaArranjo_PecaId])
    REFERENCES [dbo].[PecaArranjoSet]
        ([ArranjoId], [PecaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhoPecaArranjo'
CREATE INDEX [IX_FK_TrabalhoPecaArranjo]
ON [dbo].[TrabalhoSet]
    ([PecaArranjo_ArranjoId], [PecaArranjo_PecaId]);
GO

-- Creating foreign key on [ArranjoId] in table 'PecaArranjoSet'
ALTER TABLE [dbo].[PecaArranjoSet]
ADD CONSTRAINT [FK_ArranjoPecaArranjo]
    FOREIGN KEY ([ArranjoId])
    REFERENCES [dbo].[ArranjoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PecaId] in table 'PecaArranjoSet'
ALTER TABLE [dbo].[PecaArranjoSet]
ADD CONSTRAINT [FK_PecaPecaArranjo]
    FOREIGN KEY ([PecaId])
    REFERENCES [dbo].[PecaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PecaPecaArranjo'
CREATE INDEX [IX_FK_PecaPecaArranjo]
ON [dbo].[PecaArranjoSet]
    ([PecaId]);
GO

-- Creating foreign key on [ArranjoId] in table 'ConsumoSet'
ALTER TABLE [dbo].[ConsumoSet]
ADD CONSTRAINT [FK_ArranjoConsumo]
    FOREIGN KEY ([ArranjoId])
    REFERENCES [dbo].[ArranjoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArranjoConsumo'
CREATE INDEX [IX_FK_ArranjoConsumo]
ON [dbo].[ConsumoSet]
    ([ArranjoId]);
GO

-- Creating foreign key on [StockMateriais_Id] in table 'ConsumoSet'
ALTER TABLE [dbo].[ConsumoSet]
ADD CONSTRAINT [FK_ConsumoStockMateriais]
    FOREIGN KEY ([StockMateriais_Id])
    REFERENCES [dbo].[StockMateriaisSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsumoStockMateriais'
CREATE INDEX [IX_FK_ConsumoStockMateriais]
ON [dbo].[ConsumoSet]
    ([StockMateriais_Id]);
GO

-- Creating foreign key on [StockMateriaisId] in table 'ForneceSet'
ALTER TABLE [dbo].[ForneceSet]
ADD CONSTRAINT [FK_StockMateriaisFornece]
    FOREIGN KEY ([StockMateriaisId])
    REFERENCES [dbo].[StockMateriaisSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FornecedorId] in table 'ForneceSet'
ALTER TABLE [dbo].[ForneceSet]
ADD CONSTRAINT [FK_FornecedorFornece]
    FOREIGN KEY ([FornecedorId])
    REFERENCES [dbo].[FornecedorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FornecedorFornece'
CREATE INDEX [IX_FK_FornecedorFornece]
ON [dbo].[ForneceSet]
    ([FornecedorId]);
GO

-- Creating foreign key on [Id] in table 'PedidoSet_PedidoTabelado'
ALTER TABLE [dbo].[PedidoSet_PedidoTabelado]
ADD CONSTRAINT [FK_PedidoTabelado_inherits_Pedido]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PedidoSet_Orcamento'
ALTER TABLE [dbo].[PedidoSet_Orcamento]
ADD CONSTRAINT [FK_Orcamento_inherits_Pedido]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------