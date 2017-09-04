CREATE PROCEDURE [dbo].[Person_GetAll]
AS
	SELECT [Id], [FirstName], [LastName], [PhoneNumber], [EmailAddress], [Status] 
	FROM Person
	WHERE Id != -1
RETURN 0
