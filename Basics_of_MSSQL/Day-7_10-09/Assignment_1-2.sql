use society


select * from books
select * from orders
select * from users

/* find top 2 most expensive books for each user*/


select A.product_sku, A.title, A.price, C.names, row_number() over (partition by C.names order by A.price desc) from orders B
inner join books A on B.product_sku = A.product_sku
inner join users C on C.users_id = B.users_id