use society

/* Task - 1*/
create table customers (CustomerId int primary key, Name varchar(20), Address varchar(50), Region varchar(20))

create table SmartMeterReadings (MeterID int primary key, CustomerID int, Location varchar(20), InstalledDate date, ReadingDateTime datetime, EnergyConsumed float, 
constraint S_C foreign key (CustomerID) references customers(CustomerID))

insert into customers values (101, 'Uday', 'Surat', 'Gujarat'), (102, 'Gaurav', 'Nagpur', 'Maharashtra'), (103, 'Milan', 'Roorkee', 'Uttarakhand'), (104, 'Shivansh', 'Badmer', 'Rajasthan')
insert into customers values (105, 'Anuj', 'Surat', 'North'), (106, 'Gaur', 'Nagpur', 'North'), (107, 'Milap', 'Roorkee', 'East')

insert into SmartMeterReadings values (301, 101, 'Rooftop', '01-01-2020', '2020-01-01 00:01.000', 20)
insert into SmartMeterReadings values (302, 101, 'Basement', '01-02-2020', '2020-02-01 00:15.000', 30)
insert into SmartMeterReadings values (303, 102, 'Basement', '01-02-2021', '2021-02-01 00:15.000', 12)
insert into SmartMeterReadings values (304, 103, 'Basement', '01-03-2021', '2021-03-01 00:15.000', 14)
insert into SmartMeterReadings values (305, 104, 'Basement', '01-03-2024', '2025-03-01 00:15.000', 19)
insert into SmartMeterReadings values (306, 105, 'Rooftop', '01-03-2023', '2023-03-01 00:15.000', 10)
insert into SmartMeterReadings values (307, 106, 'Basement', '01-03-2022', '2021-03-01 00:15.000', 13)



select * from customers
select * from SmartMeterReadings

update customers
set Region = 'East' where CustomerId = 103

/* Task-1

Write a query to
· Fetch all smart meter readings where:
. EnergyConsumed is between 10 and 50 kWh
· ReadingDateTime is between '2024-01-01' and '2024-12-31'
· Exclude meters installed after '2024-06-30'*/

/* 1-1*/
select MeterID, ReadingDateTime, EnergyConsumed from SmartMeterReadings where EnergyConsumed between 10 and 50;

/* 1-2*/
select MeterID, ReadingDateTime, EnergyConsumed from SmartMeterReadings where ReadingDateTime between '2020-01-01' and '2024-12-31'

/* 1-3*/
select MeterID, ReadingDateTime, EnergyConsumed from SmartMeterReadings where InstalledDate <= '2020-06-30'


/* Task-2
Task2 :
For each customer, calculate:
. Average energy consumed per reading
· Maximum energy consumed in a single reading.
. Only include readings from the current year.
*/

/*2-1,2*/
select CustomerID, AVG(Energyconsumed) as AvgEnergyConsumed, Max(EnergyConsumed) as MaxEnergyConsumed 
from SmartMeterReadings
where year(ReadingDateTime) = year(Getdate())
Group by CustomerID;

select CustomerID, AVG(Energyconsumed) as AvgEnergyConsumed, Max(EnergyConsumed) as MaxEnergyConsumed 
from SmartMeterReadings
Group by CustomerID
having AVG(Energyconsumed) > 15;


/* 2-3 */
select * from SmartMeterReadings where year(ReadingDateTime) = year(Getdate());






