Total sale daywise


Write a query to display order_date, total order amount in each day. Give an alias name for total order amount as ‘TOTAL_SALE’. Sort the result based on order_date.
(HINT : Use Orders table to retrieve records.)
NOTE: Maintain the same sequence of column order, as specified in the question description




SELECT order_date, SUM(order_amount) AS TOTAL_SALE FROM orders
GROUP BY order_date
ORDER BY order_date ASC;