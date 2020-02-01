-- SQL
SELECT player_name, games, RPAD(ROUND((hits/at_bats::NUMERIC),3)::TEXT,5,'0') AS batting_average
FROM yankees
WHERE at_bats >= 100
ORDER BY batting_average DESC;
