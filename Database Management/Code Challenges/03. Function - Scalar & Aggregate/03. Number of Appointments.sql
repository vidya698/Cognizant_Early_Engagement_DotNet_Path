SELECT doctor_id, COUNT(app_number) as APPOINTMENT_COUNT
FROM appointment
GROUP BY doctor_id
ORDER BY doctor_id;