Customers having gmail id


Write a query to display customer id, customer name, address, and phone number of customers having Gmail id.  Sort the result based on customer id.
(HINT: Use Customers table to retrieve records. Email id='xxxxx@gmail.com'.Data is case sensitive.)
NOTE: Maintain the same sequence of column order, as specified in the question description


SELECT customer_id, customer_name, address, phone_no FROM customers WHERE email_id LIKE '%@gmail.com' ORDER BY customer_id ASC;