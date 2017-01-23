Declare @today Date = cast(getdate() as date)
SELECT * 
FROM  [HumanResources].[Employee]
WHERE DATEDIFF(YEAR, [BirthDate],@today) > 40
ORDER BY [BirthDate]

