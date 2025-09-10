use society

select * from books
select * from orders
select * from users

/* find top 2 most expensive books for each user*/

select * from orders B
inner join books A on B.product_sku = A.product_sku
inner join users C on C.users_id = B.users_id
