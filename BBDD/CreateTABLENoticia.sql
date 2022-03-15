-- Create a new table called '[Noticia]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Noticia]', 'U') IS NOT NULL
DROP TABLE [dbo].[Noticia]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Noticia]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [nombre] NVARCHAR(50) NOT NULL,
    [descripcion_corta] NVARCHAR(200) NOT NULL,
    [descripcion] NVARCHAR(max) NOT NULL,
    [img] NVARCHAR(100) NOT NULL,
    [fecha] DATETIME2 NOT NULL
    -- Specify more columns here
);
GO