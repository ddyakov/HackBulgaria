SELECT [FirstName], [LastName], [BirthDate]
FROM [Person].[Person], [HumanResources].[Employee]
WHERE [FirstName] = 'Dirk' AND [LastName] = 'Bruno' AND [BirthDate] = cast (getdate() as date)
UPDATE [HumanResources].[Employee]
SET	[BirthDate] = DATEADD(YEAR, 1, [BirthDate])
WHERE [BirthDate] = '1963-03-02'
SELECT [FirstName], [LastName], [BirthDate]
FROM [Person].[Person], [HumanResources].[Employee]
WHERE [FirstName] = 'Dirk' AND [LastName] = 'Bruno'