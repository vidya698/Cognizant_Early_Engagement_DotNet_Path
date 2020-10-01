Credential details



Refer to the schema. Write a query to display the username and password of all owners. Give an alias name as USERNAME and PASSWORD. Sort the result based on the username in ascending order.
Username and password is generated as mentioned below
USERNAME: concatenate the owner's name with owner id.
PASSWORD: concatenate first 3 character of owner name with owner id.

For Example: 

          Owner_id - 01
          Owner_name - jeeva

Sample Output:

USERNAME	PASSWORD
jeeva01		jee01




SELECT CONCAT(owner_name,owner_id) AS USERNAME, CONCAT(SUBSTRING(owner_name, 1,3),owner_id) AS PASSWORD
FROM owners ORDER BY USERNAME ASC;