CREATE PROCEDURE [dbo].[GetRatingsReport]
	
AS
SELECT 
		R.Id,
		R.Name,
		[Address],
		[City],
		[State],
		Count(Rating) as [Total Ratings],
		ROUND(AVG(CAST(Rating AS FLOAT)), 2)as [Average Rating]
	FROM Restaurants R INNER JOIN Ratings Ra on R.Id=Ra.Restaurant 
						LEFT JOIN RestaurantType RT on R.RestaurantType = RT.ID

	GROUP by R.ID, R.Name, [Address], [City], [State]
	ORDER BY [Average Rating] DESC


