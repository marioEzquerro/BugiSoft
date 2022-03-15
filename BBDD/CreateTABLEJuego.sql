-- Create a new table called '[Juego]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Juego]', 'U') IS NOT NULL
DROP TABLE [dbo].[Juego]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Juego]
(
[id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
[nombre] [nvarchar](50) NOT NULL,
[descripcion] [nvarchar](max) NOT NULL,
[fecha_lanzamiento] [datetime2](7),
[genero] [nvarchar](100) NOT NULL,
[imagen] [nvarchar](100) NOT NULL
);