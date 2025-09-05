use society

create table employees (id int primary key, name varchar(50), branch varchar(50), salary float)

insert into employees values (5, 'Gaurav', 'HS', 1000000)

select * from employees where name like '%U%' and name not like 'U%'  

insert into employees (id, name, branch) values (6, 'Vikram', 'IT')

select * from employees where salary = (select max(salary) from employees)

select * from employees where salary in (select salary from employees where salary between 10000 and 50000)

select * from employees order by name desc
 