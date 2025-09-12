
select * from Students2024
select * from Students2025
select * from Employees
select * from Projects
select * from Contacts

/* Task-1 */
---1
select Name from Students2024
union
select Name from Students2025

---2
select Name from Students2024
union all
select Name from Students2025

/* Task-2 */
---1
select upper(Name) as Uppercase, lower(Name) as Lowercase from Employees

---2
select len(Name) from Students2024
union all
select Name from Students2025





