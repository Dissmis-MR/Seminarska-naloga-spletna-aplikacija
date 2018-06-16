CREATE TABLE [dbo].[Films] (
    [id]         INT             IDENTITY (1, 1) NOT NULL,
    [Naslov]     NVARCHAR (MAX)  NULL,
    [LetoIzdaje] DATETIME        NOT NULL,
    [Tip]        NVARCHAR (MAX)  NULL,
    [Cena]       DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_dbo.Films] PRIMARY KEY CLUSTERED ([id] ASC)
);

