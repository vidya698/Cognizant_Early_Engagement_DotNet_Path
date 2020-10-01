Cars not taken for rent




Write a query to display car id, car name, car type of cars which was not taken for rent.  Sort the result based on car id.
(HINT: Use Cars and Rentals tables to retrieve records.)
NOTE: Maintain the same sequence of column order, as specified in the question description




SELECT car_id, car_name, car_type FROM cars
WHERE car_id NOT IN ( SELECT car_id FROM rentals )
GROUP BY car_id
