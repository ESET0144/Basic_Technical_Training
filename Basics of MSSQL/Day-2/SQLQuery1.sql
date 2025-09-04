create database Society
use society

create table employee (emp_id int, Names varchar(10), dept varchar(10), salary int)

select * from employee

insert into employee (emp_id, Names, dept, salary) values (1, 'Uday','sales', 12012012), 
															(2, 'Niyat', 'purchase',888888), 
															(3, 'Viyat', 'design',8889088), 
															(4, 'Nilay','UIUX', 15098), 
															(5, 'Virat', 'planning',858688)

select * from employee where salary > 1212121

delete from apt where flat_no=102
