Order details


Write a query to display order id, customer name, hotel name, and order amount of all orders. Sort the result based on order id in ascending order.
(HINT: Use Customers, Hotel_details and Orders tables to retrieve records.)
NOTE: Maintain the same sequence of column order, as specified in the question description






SELECT o.order_id, c.customer_name, h.hotel_name, o.order_amount FROM orders o
JOIN customers c ON c.customer_id = o.customer_id
JOIN hotel_details h ON o.hotel_id = h.hotel_id
GROUP BY o.order_id ASC;