SELECT doctor_id, count(app_number) as APPOINTMENT_COUNT FROM appointment
GROUP BY doctor_id
ORDER BY doctor_id;