ALTER PROCEDURE usp_itemsinpricerange
@minprice decimal(10,2),
@maxprice decimal(10,2)
AS
BEGIN
	
SELECT company,  
COUNT(*) as "numberofitems"
from 
Laptop

WHERE 
price 
BETWEEN 
@minprice 
AND  
@maxprice
GROUP BY company;
    
END
GO

