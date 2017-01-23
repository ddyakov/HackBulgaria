SELECT [FirstName], [LastName]
FROM [Person].[Person] 
WHERE [FirstName] = 'Roberto' AND [LastName] = 'Tamburello'
UPDATE [Person].[Person]
SET [LastName] = 'HackBulgaria'
WHERE [FirstName] = 'Roberto'
SELECT [FirstName], [LastName]
FROM [Person].[Person]
WHERE [FirstName] = 'Roberto' AND [LastName] = 'HackBulgaria'