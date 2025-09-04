use society

select * from societytable

exec sp_help societytable

exec sp_rename 'societytable.mobile_no', 'phone_no', 'column';

exec sp_rename 'apt', 'societytable';