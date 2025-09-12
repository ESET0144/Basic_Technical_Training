use society

select * from employees

insert into employee values (6, 'Virat', 'planning', 858688)

select Names, dept, salary from employee
union
select name, branch, salary from employees

select lower(name) from employees as Lowercase

select len('Uday V ') as Length_S

select replace(salary, 30000, 600000) from employees

select reverse(substring(name, 2, len(name))) from employees

alter table employees
add cnct varchar(50) 
update employees set cnct= concat(name, ' ', branch) 

select replace(cast(salary as varchar(20)), '0', '0000') from employees

select convert(varchar(20), GETDATE(), 130)

SELECT CAST(4932023 AS varbinary)
SELECT CAST(0x1D65ABD0 AS int)

SELECT CAST(salary AS varbinary) from employees

select GETDATE()







