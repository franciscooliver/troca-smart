CREATE TABLE [dbo].[Produtos] (
    [ProdutoId] INT             IDENTITY (1, 1) NOT NULL,
    [Nome]      NCHAR (100)     NULL,
    [Modelo]    NCHAR (15)      NULL,
    [Descricao] NCHAR (500)     NULL,
    [Preco]     DECIMAL (16, 2) NULL,
    [Estatus]   NCHAR (50)      NULL,
    [Categoria] NCHAR (50)      NULL,
    [Marca] NCHAR(30) NULL, 
    PRIMARY KEY CLUSTERED ([ProdutoId] ASC)
);

