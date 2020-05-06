-- The following queries utilize the "dvdstore" database.
use [dvdstore]
-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)

SELECT film.title
FROM film_actor
JOIN film ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name= 'nick' and actor.last_name = 'stallone'

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT film.title
FROM film_actor
JOIN film ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name= 'rita' and actor.last_name = 'reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT film.title
FROM film_actor
JOIN film ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name= 'judy' or actor.first_name='river' and actor.last_name = 'dean'


-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id =category.category_id
WHERE category.name = 'documentary'



-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id =category.category_id
WHERE category.name = 'comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id =category.category_id
WHERE category.name = 'children' and film.rating = 'g'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id =category.category_id
WHERE category.name = 'family' and film.rating = 'g' and film.length < 120


-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT film.title
FROM film_actor
JOIN film ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name='matthew' and actor.last_name = 'leigh' and film.rating = 'g'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

SELECT film.title
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id =category.category_id
WHERE category.name = 'sci-fi' and film.release_year = 2006

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)

SELECT film.title
FROM film_actor
JOIN film ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON film_category.category_id =category.category_id
WHERE actor.first_name= 'nick' and actor.last_name = 'stallone' and category.name = 'action'

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT store_id, address.address, city.city_id, country.country_id, address.district
FROM store
JOIN address ON store.store_id = address.address_id
JOIN city ON city.city_id = address.address_id
JOIN country ON country.country_id = city.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

SELECT store.store_id, address.address, staff.first_name, staff.last_name
FROM store
JOIN address ON store.store_id = address.address_id
JOIN city ON city.city_id = address.address_id
JOIN country ON country.country_id = city.country_id
JOIN staff ON staff.store_id = address.address_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT C.first_name, C.last_name, Top_Customers.rentals FROM
(SELECT TOP 10 customer_id, count(*) rentals from rental 
GROUP BY customer_id 
ORDER BY count(*) desc) Top_Customers
JOIN customer C ON c.customer_id = Top_Customers.customer_id




-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10 SUM(payment.amount) AS totalsales, (customer.first_name + ' ' + customer.last_name) as customerName
FROM customer
JOIN payment ON payment.customer_id = customer.customer_id
GROUP BY customer.first_name, customer.last_name
ORDER BY totalsales DESC


-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT store.store_id, address.address, count(payment.amount) as total_rentals, SUM(payment.amount) total_amt_sales, AVG(payment.amount) as avg_sales
FROM store
JOIN address ON address.address_id = store.store_id
JOIN inventory ON inventory.store_id = store.store_id
JOIN rental ON rental.rental_id = inventory.inventory_id
JOIN payment ON payment.payment_id = rental.rental_id
GROUP BY store.store_id


-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

SELECT TOP 10 film.title, COUNT(payment.amount) AS num_rentals
FROM film
JOIN inventory on inventory.film_id = film.film_id
JOIN rental on rental.inventory_id = inventory.inventory_id
JOIN payment on payment.rental_id = rental.rental_id
GROUP BY film.title
ORDER BY num_rentals DESC

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

SELECT TOP 5 COUNT(payment.rental_id) AS num_rentals, category.name
FROM film
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON payment.rental_id = rental.rental_id
JOIN film_category ON film_category.category_id = film_category.category_id
JOIN category ON category.category_id = film_category.category_id
GROUP BY category.name
ORDER BY num_rentals DESC



-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP 5 COUNT(payment.rental_id) AS num_rentals, film.title
FROM film
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON payment.rental_id = rental.rental_id
JOIN film_category ON film_category.category_id = film_category.category_id
JOIN category ON category.category_id = film_category.category_id
GROUP BY film.title
ORDER BY num_rentals DESC

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

SELECT TOP 10 COUNT(payment.rental_id) AS num_rentals, actor.first_name, actor.last_name
FROM film
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON payment.rental_id = rental.rental_id
JOIN film_category ON film_category.category_id = film_category.category_id
JOIN category ON category.category_id = film_category.category_id
JOIN customer ON customer.customer_id = rental.customer_id
GROUP BY actor.actor_id, actor.first_name, actor.last_name
ORDER BY num_rentals DESC




-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)

SELECT TOP 5 COUNT(payment.rental_id) AS num_rentals, actor.first_name, actor.last_name, category.name
FROM film
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON payment.rental_id = rental.rental_id
JOIN film_category ON film_category.category_id = film_category.category_id
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'comedy'
GROUP BY category.name, actor.first_name, actor.last_name
ORDER BY num_rentals DESC	