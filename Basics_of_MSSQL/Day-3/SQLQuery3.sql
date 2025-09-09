use society
create table Employeetable
(ID int, emp_Name varchar(50), dept varchar(10), salary float)

select * from Friends

insert into Employeetable values (5, 'sowmya', 'IT', 100000)

update Employeetable set salary=(salary*1.4) where emp_name= 'sowmya'

delete from Employeetable where dept = 'HR'

exec sp_rename 'Bhai', 'Friends'

alter table Friends
drop column Addresses

exec sp_help Bhai

exec sp_rename 'Friends.phone_no', 'mobile_no'

update Friends set mobile_no = 123123123 where emp_name= 'sowmya'


