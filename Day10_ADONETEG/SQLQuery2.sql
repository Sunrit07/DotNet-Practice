create database Wipro
use Wipro
create table Students
(
SId int,
Sname varchar(20),
Age int,
Marks int,
Result bit
)
insert into Students values(01, 'Sunrit', 25,95,1)
insert into Students values(02,'Sam',24,90,1)
insert into Students values(03,'Shourya',22,80,1),(04,'Monalisa',23,87,1)

select * from Students
Delete from Students where sid=03

update Students set age=22 where sid=4

alter table students alter column sid int not null

alter table students add primary key(sid)

insert into students values(05,'Mihir',23,80,1)

update students set marks=98 where sid=5

create table Courses
(
CId int primary key,
Cname varchar(20),
Fees float
)
select * from courses
select * from students
alter table students add CourseId int references courses(CId)
update students set CourseId=3 where sid=2
update students set Courseid=2 where sid in(4,5)
insert into students values (6,'Honey',13,90,null,null)

insert into students(sid,sname,age,marks,courseid)values(7,'Vikram',23,96,3)

alter table students add City varchar(20)
update students set city='Pune' where sid in (1,4,5)

alter table students add constraint defCity default 'chennai' for city

insert into students(sid,sname,age,marks,courseid)values(8,'Praneeth',20,96,3)

alter table students add constraint ChkAge check(Age>0 and Age<110)

update students set age=41 where sid =5

delete from students where age>35

truncate table students
--drop- deletes the entire table
--truncate -deletes all values but structure remains unchanged
--Constraints - Pk,Fk,not null,default,check
--DDL - create,Alter,Drop
--DML - Insert,Update,Delete
--DRL - Select
--CRUD - Create Read Update and Delete
select 5+7;

drop table courses