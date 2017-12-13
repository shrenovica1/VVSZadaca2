CREATE TABLE [dbo].[BachelorStudent] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [ime]            VARCHAR (50) NULL,
    [prezime]        VARCHAR (50) NULL,
    [datumRodjenja]  DATE         NULL,
    [maticniBroj]    VARCHAR (50) NULL,
    [prethodnoObraz] VARCHAR (50) NULL,
    [korisnickoIme]  VARCHAR (50) NULL,
    [lozinka]        VARCHAR (50) NULL,
    CONSTRAINT [PK_BachelorStudent] PRIMARY KEY CLUSTERED ([id] ASC)
);

