CREATE TABLE [dbo].[Person]
(
[Id] [int] NOT NULL IDENTITY(1, 1) PRIMARY KEY,
[FirstName] [nvarchar] (255) NOT NULL,
[LastName] [nvarchar] (255) NOT NULL,
[PhoneNumber] [nvarchar] (255) NOT NULL,
[EmailAddress] [nvarchar] (255) NOT NULL,
[Status] [nvarchar] (255) NOT NULL
) ON [PRIMARY]


