Maruthi car owner details



Write a query to display distinct owner id, owner name, address, and phone no of owners who owns 'Maruthi' company car.  Sort the result based on owner id.
Note: If car_name contains a string 'Maruthi' it is a Maruthi company car.
Example: 'Maruthi swift','Maruthi 800'
(HINT: Use Owners and Cars tables to retrieve records.)
NOTE: Maintain the same sequence of column order, as specified in the question description





SELECT DISTINCT(o.owner_id), o.owner_name, o.address, o.phone_no FROM owners o 
JOIN cars c ON o.owner_id = c.owner_id
WHERE c.car_name LIKE 'Maruthi%'
GROUP BY o.owner_id