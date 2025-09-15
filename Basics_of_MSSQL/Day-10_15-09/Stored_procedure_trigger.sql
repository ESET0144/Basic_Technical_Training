
create procedure checkEmployee 
@emp_id int
As
Begin
	declare @salary int;
	select @salary = Salary
	from Employee
	where emp_id = @emp_id;

	if @salary >= 50000000
		print 'High Salary';

	else if @salary >=30000
		print 'Medium Salary';

	else
		print 'Low Salary';

end

exec checkEmployee @emp_id = 3

select * from student
drop procedure checkEmployee

create trigger trg_afterinsert_students
on student
before insert, delete
as 
begin 
	print 'A new record inserted';
end

drop trigger trg_afterinsert_students

insert into student values (4, 'Gaurav', 354)

delete from student where id = 4


CREATE TABLE SalaryAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    emp_id INT,
    OldSalary INT,
    NewSalary INT,
    ChangeDate DATETIME DEFAULT GETDATE()
);

select * from SalaryAudit
select * from employee

CREATE TRIGGER trg_AuditSalaryChange
ON employee
AFTER UPDATE
AS
BEGIN
    IF UPDATE(salary) -- Run only if Salary column is updated
    BEGIN
        INSERT INTO SalaryAudit (emp_id, OldSalary, NewSalary)
        SELECT 
            d.emp_id,
            d.Salary AS OldSalary,
            i.Salary AS NewSalary
        FROM deleted d
        INNER JOIN inserted i ON d.emp_id = i.emp_id;
    END
END;

update employee
set salary = 50000 where emp_id = 2

drop trigger trg_AuditSalaryChange









