Hotels that took order more than five times



Write a query to display hotel id, hotel name, and number of orders taken by hotels that have taken orders more than 5 times. Give an alias name for number of orders as 'NO_OF_ORDERS'.sort the result based on hotel id in ascending order.
(HINT: Use Hotel_details and Orders tables to retrieve records.)
NOTE: Maintain the same sequence of column order, as specified in the question description





SELECT h.hotel_id, h.hotel_name, COUNT(o.order_id) AS NO_OF_ORDERS FROM hotel_details h
INNER JOIN orders o ON h.hotel_id = o.hotel_id
GROUP BY h.hotel_id, h.hotel_name
HAVING COUNT(o.order_id) > 5;