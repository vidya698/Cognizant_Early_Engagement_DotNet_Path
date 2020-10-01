Hotels that took order based on month



Write a query to display distinct hotel id, hotel name, and rating of hotels that have taken order in the month of July. Sort the result based on hotel id in ascending order.
(HINT: Use Hotel_details and  Orders tables to retrieve records.Order date='2019-07-14')
NOTE: Maintain the same sequence of column order, as specified in the question description




SELECT DISTINCT(hotel_id), hotel_name, rating FROM hotel_details
WHERE hotel_id IN (SELECT hotel_id FROM orders WHERE order_date BETWEEN '2019-07-01' AND '2019-07-31' )
ORDER BY hotel_id;