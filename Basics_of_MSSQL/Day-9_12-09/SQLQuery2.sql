use society

select * from Employees

insert into employees values (7, 'Raj', 'IT', 50000);

select name, salary, 
row_number() over (order by salary asc) as salary_row_number,
RANK() over (order by salary desc) as salary_rank,
dense_RANK() over (order by salary asc) as salary_denseRank
from employees 

select name, salary, branch,
row_number() over (partition by branch order by salary desc) as salary_row_number
from employees 

