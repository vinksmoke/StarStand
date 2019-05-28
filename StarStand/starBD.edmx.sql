
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/28/2019 11:34:26
-- Generated from EDMX file: C:\Users\yaros\Desktop\Trabalhos\1º ano\S2\Projeto DA MD\StarStand-yar32\StarStand\starBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [starBD];
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

-- Creating table 'UtilizadoresSet'
CREATE TABLE [dbo].[UtilizadoresSet] (
    [IdUtilizador] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] int  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VendaSet'
CREATE TABLE [dbo].[VendaSet] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [UtilizadoresIdUtilizador] int  NOT NULL,
    [CarroVenda_IdCarro] int  NOT NULL
);
GO

-- Creating table 'PecasSet'
CREATE TABLE [dbo].[PecasSet] (
    [IdPecas] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [Stock] int  NOT NULL,
    [ServicoIdServicos] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HistoricoServicosSet'
CREATE TABLE [dbo].[HistoricoServicosSet] (
    [IdHistoricoServicos] int IDENTITY(1,1) NOT NULL,
    [DataSaida] nvarchar(max)  NOT NULL,
    [CarroOficinaIdCarroOficina] nvarchar(max)  NOT NULL,
    [CarroOficina_IdCarro] int  NOT NULL,
    [Servicos_IdServicos] int  NOT NULL
);
GO

-- Creating table 'ServicosSet'
CREATE TABLE [dbo].[ServicosSet] (
    [IdServicos] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Pecas] bit  NOT NULL,
    [ValorHora] float  NOT NULL
);
GO

-- Creating table 'AluguerSet'
CREATE TABLE [dbo].[AluguerSet] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] datetime  NOT NULL,
    [Valor] float  NOT NULL,
    [Kms] float  NOT NULL,
    [UtilizadoresIdUtilizador] int  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarrosSet'
CREATE TABLE [dbo].[CarrosSet] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CarrosSet_CarroAluguer'
CREATE TABLE [dbo].[CarrosSet_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarrosSet_CarroVenda'
CREATE TABLE [dbo].[CarrosSet_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarrosSet_CarroOficina'
CREATE TABLE [dbo].[CarrosSet_CarroOficina] (
    [Kms] float  NOT NULL,
    [UtilizadoresIdUtilizador] int  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'ServicosPecas'
CREATE TABLE [dbo].[ServicosPecas] (
    [Servicos_IdServicos] int  NOT NULL,
    [Pecas1_IdPecas] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUtilizador] in table 'UtilizadoresSet'
ALTER TABLE [dbo].[UtilizadoresSet]
ADD CONSTRAINT [PK_UtilizadoresSet]
    PRIMARY KEY CLUSTERED ([IdUtilizador] ASC);
GO

-- Creating primary key on [IdVenda] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [PK_VendaSet]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdPecas] in table 'PecasSet'
ALTER TABLE [dbo].[PecasSet]
ADD CONSTRAINT [PK_PecasSet]
    PRIMARY KEY CLUSTERED ([IdPecas] ASC);
GO

-- Creating primary key on [IdHistoricoServicos] in table 'HistoricoServicosSet'
ALTER TABLE [dbo].[HistoricoServicosSet]
ADD CONSTRAINT [PK_HistoricoServicosSet]
    PRIMARY KEY CLUSTERED ([IdHistoricoServicos] ASC);
GO

-- Creating primary key on [IdServicos] in table 'ServicosSet'
ALTER TABLE [dbo].[ServicosSet]
ADD CONSTRAINT [PK_ServicosSet]
    PRIMARY KEY CLUSTERED ([IdServicos] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [PK_AluguerSet]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarrosSet'
ALTER TABLE [dbo].[CarrosSet]
ADD CONSTRAINT [PK_CarrosSet]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarrosSet_CarroAluguer'
ALTER TABLE [dbo].[CarrosSet_CarroAluguer]
ADD CONSTRAINT [PK_CarrosSet_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarrosSet_CarroVenda'
ALTER TABLE [dbo].[CarrosSet_CarroVenda]
ADD CONSTRAINT [PK_CarrosSet_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarrosSet_CarroOficina'
ALTER TABLE [dbo].[CarrosSet_CarroOficina]
ADD CONSTRAINT [PK_CarrosSet_CarroOficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [Servicos_IdServicos], [Pecas1_IdPecas] in table 'ServicosPecas'
ALTER TABLE [dbo].[ServicosPecas]
ADD CONSTRAINT [PK_ServicosPecas]
    PRIMARY KEY CLUSTERED ([Servicos_IdServicos], [Pecas1_IdPecas] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UtilizadoresIdUtilizador] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_UtilizadoresVenda]
    FOREIGN KEY ([UtilizadoresIdUtilizador])
    REFERENCES [dbo].[UtilizadoresSet]
        ([IdUtilizador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtilizadoresVenda'
CREATE INDEX [IX_FK_UtilizadoresVenda]
ON [dbo].[VendaSet]
    ([UtilizadoresIdUtilizador]);
GO

-- Creating foreign key on [UtilizadoresIdUtilizador] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [FK_UtilizadoresAluguer]
    FOREIGN KEY ([UtilizadoresIdUtilizador])
    REFERENCES [dbo].[UtilizadoresSet]
        ([IdUtilizador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtilizadoresAluguer'
CREATE INDEX [IX_FK_UtilizadoresAluguer]
ON [dbo].[AluguerSet]
    ([UtilizadoresIdUtilizador]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [FK_CarroAluguerAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[CarrosSet_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroAluguerAluguer'
CREATE INDEX [IX_FK_CarroAluguerAluguer]
ON [dbo].[AluguerSet]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [CarroVenda_IdCarro] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_IdCarro])
    REFERENCES [dbo].[CarrosSet_CarroVenda]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[VendaSet]
    ([CarroVenda_IdCarro]);
GO

-- Creating foreign key on [Servicos_IdServicos] in table 'ServicosPecas'
ALTER TABLE [dbo].[ServicosPecas]
ADD CONSTRAINT [FK_ServicosPecas_Servicos]
    FOREIGN KEY ([Servicos_IdServicos])
    REFERENCES [dbo].[ServicosSet]
        ([IdServicos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pecas1_IdPecas] in table 'ServicosPecas'
ALTER TABLE [dbo].[ServicosPecas]
ADD CONSTRAINT [FK_ServicosPecas_Pecas]
    FOREIGN KEY ([Pecas1_IdPecas])
    REFERENCES [dbo].[PecasSet]
        ([IdPecas])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicosPecas_Pecas'
CREATE INDEX [IX_FK_ServicosPecas_Pecas]
ON [dbo].[ServicosPecas]
    ([Pecas1_IdPecas]);
GO

-- Creating foreign key on [CarroOficina_IdCarro] in table 'HistoricoServicosSet'
ALTER TABLE [dbo].[HistoricoServicosSet]
ADD CONSTRAINT [FK_CarroOficinaHistoricoServicos]
    FOREIGN KEY ([CarroOficina_IdCarro])
    REFERENCES [dbo].[CarrosSet_CarroOficina]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroOficinaHistoricoServicos'
CREATE INDEX [IX_FK_CarroOficinaHistoricoServicos]
ON [dbo].[HistoricoServicosSet]
    ([CarroOficina_IdCarro]);
GO

-- Creating foreign key on [UtilizadoresIdUtilizador] in table 'CarrosSet_CarroOficina'
ALTER TABLE [dbo].[CarrosSet_CarroOficina]
ADD CONSTRAINT [FK_UtilizadoresCarroOficina]
    FOREIGN KEY ([UtilizadoresIdUtilizador])
    REFERENCES [dbo].[UtilizadoresSet]
        ([IdUtilizador])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtilizadoresCarroOficina'
CREATE INDEX [IX_FK_UtilizadoresCarroOficina]
ON [dbo].[CarrosSet_CarroOficina]
    ([UtilizadoresIdUtilizador]);
GO

-- Creating foreign key on [Servicos_IdServicos] in table 'HistoricoServicosSet'
ALTER TABLE [dbo].[HistoricoServicosSet]
ADD CONSTRAINT [FK_ServicosHistoricoServicos]
    FOREIGN KEY ([Servicos_IdServicos])
    REFERENCES [dbo].[ServicosSet]
        ([IdServicos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicosHistoricoServicos'
CREATE INDEX [IX_FK_ServicosHistoricoServicos]
ON [dbo].[HistoricoServicosSet]
    ([Servicos_IdServicos]);
GO

-- Creating foreign key on [IdCarro] in table 'CarrosSet_CarroAluguer'
ALTER TABLE [dbo].[CarrosSet_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carros]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarrosSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'CarrosSet_CarroVenda'
ALTER TABLE [dbo].[CarrosSet_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carros]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarrosSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'CarrosSet_CarroOficina'
ALTER TABLE [dbo].[CarrosSet_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carros]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarrosSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------