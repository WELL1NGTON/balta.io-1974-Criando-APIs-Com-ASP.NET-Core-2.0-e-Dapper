-- WRONG! don't work

CREATE PROCEDURE spGetCustomerOrdersCount
	@Document CHAR(11)
AS
	SELECT 
        c.[ID],
        CONCAT(c.[FirstName],' ',c.[LastName]) AS [Name],
        c.[Document],
        COUNT(o.Id)
    FROM
        [Customer] c 
    INNER JOIN 
        [Order] o 
    ON 
        o.[CustomerId] = c.[Id]