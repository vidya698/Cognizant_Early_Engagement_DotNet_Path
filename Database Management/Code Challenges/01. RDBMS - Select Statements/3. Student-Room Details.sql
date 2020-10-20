SELECT student_details.student_id, student_id, student_name, department, doj, admission_details.room_id, room_type
FROM student_details 
JOIN admission_details ON student_details.student_id = admission_details.student_id
JOIN room_details ON admission_details.room_id = room_details.room_id
ORDER BY student_details.student_id;
