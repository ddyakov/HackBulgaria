SELECT [FirstName] 
	  ,[LastName] 
	  ,[City]
FROM [Person].[Person], [Person].[Address]
WHERE [City] != 'Payson'
ORDER BY [Address].[City]