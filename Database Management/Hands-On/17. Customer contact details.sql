Customer contact details


Write a query to display the customer id, customer name and contact details of customers. If address is missing, display the email id. If both address and email is missing then display ‘NA’. Give an alias name as CONTACT_DETAILS.Sort the results based on customer id in ascending order.
(HINT : Use Customers table to retrieve records.)











SELECT customer_id, customer_name,
IFNULL(address,IFNULL(email_id, 'NA')) AS CONTACT_DETAILS
FROM customers;