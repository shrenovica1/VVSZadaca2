CREATE TABLE [dbo].[Predmeti] (
    [naziv]           VARCHAR (50) NULL,
    [brojVjezbi]      INT          NULL,
    [brojPredavanja]  INT          NULL,
    [brojStudenata]   INT          NULL,
    [brojEtcs]        INT          NULL,
    [opis]            VARCHAR (50) NULL,
    [studijskaGodina] VARCHAR (50) NULL,
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Predmeti] PRIMARY KEY CLUSTERED ([id] ASC)
);

