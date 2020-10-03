SELECT movie_id, movie_name, director_name, language FROM movie_master
WHERE duration > 130 AND certification = 'U'
ORDER BY movie_id;