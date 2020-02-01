-- SQL

-- Using Wilson's theorem 
SELECT * FROM GENERATE_SERIES(2, 100) AS prime WHERE (((prime - 1)!) + 1) % prime = 0;
