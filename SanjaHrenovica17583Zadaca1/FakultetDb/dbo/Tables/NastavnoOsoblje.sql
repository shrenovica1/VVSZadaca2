CREATE TABLE [dbo].[NastavnoOsoblje] (
    [id]            INT          IDENTITY (1, 1) NOT NULL,
    [ime]           VARCHAR (50) NULL,
    [prezime]       VARCHAR (50) NULL,
    [datumRodjenja] DATE         NULL,
    [maticniBroj]   VARCHAR (50) NULL,
    [pozicija]      VARCHAR (50) NULL,
    [strucnaSprema] VARCHAR (50) NULL,
    [titula]        VARCHAR (50) NULL,
    [plata]         DECIMAL (18) NULL,
    [korisnickoIme] VARCHAR (50) NULL,
    [lozinka]       VARCHAR (50) NULL,
    CONSTRAINT [PK_NastavnoOsoblje] PRIMARY KEY CLUSTERED ([id] ASC)
);

