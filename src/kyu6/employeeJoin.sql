-- SQL
SELECT 
  j.job_title,
  ROUND((AVG(j.salary)),2)::float as average_salary,
  COUNT(p.id) as total_people,
  ROUND((SUM(j.salary)::numeric),2)::float as total_salary
  FROM people p
  JOIN job j ON j.id = p.id
  GROUP BY j.job_title
  ORDER BY average_salary DESC;
