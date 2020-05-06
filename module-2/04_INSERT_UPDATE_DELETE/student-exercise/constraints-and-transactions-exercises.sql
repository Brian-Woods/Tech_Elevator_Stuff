
-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**
USE [dvdstore]
-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT into actor(first_name, last_name)
VALUES ('Hampton',  'Avenue'), 
		('Lisa', 'Byway')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO film (title, description, release_year, language_id, length)
VALUES('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 198)

select * from film where title= 'euclidean pi'

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor (actor_id, film_id)
values(201, 1001),
	(202,1001)






-- 4. Add Mathmagical to the category table.
INSERT INTO category(name)
VALUES('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

INSERT INTO film_category(film_id, category_id)
VALUES(1001, 17),(274, 17),(494,17), (714,17),(996,17)

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film set rating = 'G' FROM film
JOIN film_category ON film.film_id = film_category.film_id
JOIN category on category.category_id = film_category.film_id
WHERE category.category_id = 17

-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory (film_id, store_id)
values(1001,1),
	(1001,2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

BEGIN TRANSACTION

DELETE FROM film WHERE title = 'euclidean pi'
ROLLBACK
--No, there is a foregin key (language_id) that cannot be null, which prevents it from being deleted

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

--yes

BEGIN TRANSACTION
DELETE FROM category WHERE name = 'mathmegical'

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

BEGIN TRANSACTION
DELETE FROM film_category WHERE category_id = 17

--Yes, no foreign key

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".


-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>

-- no, it gives an error with FK_Film_actor
BEGIN TRANSACTION

DELETE FROM film WHERE title = 'euclidean pi'

BEGIN TRANSACTION 
DELETE FROM film_actor WHERE film_id = 1001

BEGIN TRANSACTION
DELETE FROM inventory WHERE film_id = 1001

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

select * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS 


