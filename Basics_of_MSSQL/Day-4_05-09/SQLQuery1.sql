use society

create table student (id int primary key, name varchar(50))

select * from student
select * from teachers

insert into student values (3, 'raj', 2)

alter table student
add constraint unique_constraint unique(number)

create table teachers (id int, subject varchar(50), 
FOREIGN KEY (id) references student(id))

insert into teachers values(1, 'English')

select * from teachers

delete from student where id=1

create table users (user_id int, email varchar(50), name varchar(50))

alter table users
add users_id int primary key


create table books (product_sku int primary key, title varchar(50), price int)

select * from books
select * from users
select * from orders

exec sp_rename 'users.name', 'Email'

insert into books values (40, 'Kaliyug', 300)

create table orders (order_no int primary key, 
users_id int, foreign key (users_id) references users(users_id),
product_sku int, foreign key (product_sku) references books(product_sku))

select * from orders

insert into orders values (103, 1, 40)






