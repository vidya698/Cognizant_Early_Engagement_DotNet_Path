Refer to the given schema.

Write a query to create the Owners table with the specified columns and constraints.

Note: Letters in bold represents the table name
NOTE: Maintain the same sequence of column order, as specified in the question description




CREATE TABLE owners (
	owner_id VARCHAR(10), 
	owner_name VARCHAR(20),
	address VARCHAR(20),
	phone_no BIGINT,
	email_id VARCHAR(20),
	PRIMARY KEY (owner_id)
);