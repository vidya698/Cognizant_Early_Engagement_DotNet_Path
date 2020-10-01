Rental details based on date




Write a query to display rental id, car id, customer id and km driven of rentals taken during 'AUGUST 2019'.  Sort the result based on rental id.
(HINT : Use Rentals table to retrieve records. Eg: return date: 2019-08-12 )
NOTE: Maintain the same sequence of column order, as specified in the question description



SELECT rental_id, car_id, customer_id, km_driven FROM rentals
WHERE pickup_date BETWEEN '2019-08-01' AND '2019-08-31'
ORDER BY rental_id ASC;










