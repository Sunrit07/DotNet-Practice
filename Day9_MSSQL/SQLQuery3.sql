create database Studentinfo
use Studentinfo

create table Student1
(
Id int primary key,
Name varchar(20),
Age int,
Courses varchar(20),
fees float
)
-- inserting data into table
insert into Student1(Id,Name,Age,Courses,Fees) values
(1,'Akash ',21,'JAVA',25000),
(2,'Palak ',25,'.Net',25000),
(3,'Tejas ',18,'Python',20000),
(4,'Priya ',22,'AWS',35000),
(5,'Ansh ',15,'Eng',125000)
select *from Student1

-- Aggregate functions
select Count(*) as TotalStudents from Student1
select Sum(Fees) as TotalFees from Student1
select Avg(Age) as AverageOfAge from  Student1
select Min(Fees) as MinFees from Student1
select Max(Fees) as MaxFees from Student1

--string functions

select id, Upper(name) As Uppercasename from Student1

select id,Age, Lower(Courses) As Lowercasecourses from Student1

select id, Concat(Trim(name), ' - ', trim(courses)) as NameCourses from Student1

update Student1 set  name='Akash Mane ' where id=1
update Student1 set  name='Palak Tiwari' where id=2
update Student1 set  name='Tejas Halkude' where id=3
update Student1 set  name='Priya Singh' where id=4
update Student1 set  name='Ansh Roy' where id=5


select *from Student1