use society

select * from employees order by salary desc offset 3 rows fetch next 5 rows only


select * from books
select * from orders
select * from users

/* Fetch the record of customers who has ordered more than 1 book */
select * from users as C
inner join orders as B on C.users_id = B.users_id

select C.users_id, C.Names, count(C.users_id) as Count_books from users as C
inner join orders as B on C.users_id = B.users_id
group by C.users_id, C.Names
having count(C.users_id) > 1
