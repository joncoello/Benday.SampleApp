/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF (EXISTS(select * from sysusers where name = 'app-user'))
BEGIN
	DROP USER [app-user]	
END

CREATE USER [app-user] FOR LOGIN [app-user]
GO
EXEC sp_addrolemember N'db_datareader', N'app-user'
GO
EXEC sp_addrolemember N'db_datawriter', N'app-user'