-- SQL
SELECT created_at::date AS day, description, COUNT(description) 
FROM events
GROUP BY created_at::date, description, name
HAVING name = 'trained'
ORDER BY created_at::date;
