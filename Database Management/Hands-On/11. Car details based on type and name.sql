Car details based on type and name



Write a query to display car id, car name and car type of Maruthi company 'Sedan' type cars.  Sort the result based on car id.
(HINT : Use Cars table to retrieve records.car name='Maruthi Swift'.car type='Sedan'.Data is case sensitive.)
NOTE: Maintain the same sequence of column order, as specified in the question description




SELECT car_id, car_name, car_type FROM cars WHERE car_name LIKE 'Maruthi%' AND car_type='Sedan' ORDER BY car_id ASC;