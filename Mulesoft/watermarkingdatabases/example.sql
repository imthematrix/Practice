select film_id, title, description from film_text order by film_id desc

INSERT INTO `sakila`.`film_text`
(`film_id`,
`title`,
`description`)
VALUES
(1006,
'test movie after the program is running',
'this is a test during handmade watermarking another one, yes');
