Student and their Department Based on City

Write a query to display list of students name and their department name who are all from 'Coimbatore'. Sort the result based on students name  



SELECT S.student_name, d.department_name FROM Student s 
INNER JOIN Department d ON s.department_id = d.department_id WHERE s.city = 'Coimbatore' ORDER BY s.student_name ASC;



