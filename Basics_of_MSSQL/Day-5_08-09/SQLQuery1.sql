select * from books
select * from orders
select * from users

select * from books A
inner join orders B on A.product_sku = B.product_sku

select * from users C
inner join orders B on C.users_id = B.users_id

select * from users C
inner join orders B on C.users_id = B.users_id
inner join books A on A.product_sku = B.product_sku where A.price = 1500

select * from books A
left join orders B on A.product_sku = B.product_sku

select * from books A
right join orders B on A.product_sku = B.product_sku

select * from books A
full outer join orders B on A.product_sku = B.product_sku

select * from books A
inner join orders B on A.product_sku = B.product_sku
full outer join users C on B.users_id = C.users_id

insert into books values (70, 'Bhagvad gita', 1500)

insert into orders values (104, 5, 50), (105, 6, 60), (106, 7, 70)

/*Task 1 */
select * from books A
full outer join orders B on A.product_sku = B.product_sku
full outer join users C on B.users_id = C.users_id

/*Task 2 */
select * from orders B
left join books A on B.product_sku = A.product_sku

/* Task 3 */
select A.title, A.price, C.Names from books A
full outer join orders B on A.product_sku = B.product_sku
full outer join users C on B.users_id = C.users_id
where A.title in('Bhagvad gita', 'How to quit smoking', 'how to read a book')

/* Task 4 */
select A.title, C.Names, B.order_no from books A
left join orders B on A.product_sku = B.product_sku
left join users C on B.users_id = C.users_id

/* Task 5 */

select A.price from users C
left join orders B on C.users_id = B.users_id
left join books A on B.product_sku = A.product_sku





