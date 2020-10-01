Hotel_info 


Refer to the schema. Write a query to display the hotel name along with the type. Display the details in the below format.

Give an alias name as HOTEL_INFO. Sort the result in descending order.
For Example: 
          Hotel_name - 'A2B'
          Hotel_type - 'VEG'


Sample Output:
HOTEL_INFO
A2B is a VEG hotel

(HINT: Use Hotel_details table to retrieve records.)
NOTE: Maintain the same sequence of column order, as specified in the question description




SELECT CONCAT( hotel_name, " is a ",hotel_type, " hotel" ) AS HOTEL_INFO FROM hotel_details 
ORDER BY HOTEL_INFO DESC;