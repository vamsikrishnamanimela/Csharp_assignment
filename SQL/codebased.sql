use MyFirstDB
--2. Write a query to display your age in days
Declare @dateofbirth datetime  
Declare @currentdate datetime  
Declare @years varchar(4)  
set @dateofbirth = '1997-06-10'  
set @currentdate  = getdate()
select @years = datediff(day,@dateofbirth,@currentdate)  
select @years   + ' day,' as days
 

--3.    Create table EMP8 with the following columns and conditions. (Empid,Name,Salary,Deptno)
  --  a.    accept only 10,20,30 as deptno
    --b.    Every employee salary must be in the range of 5000 to 50000 only


create table Emp8(Empid int primary key,
Name varchar(30),
Salary float check(salary >5000 and salary<50000) ,
deptno int unique check(deptno<=30)
)
select * from emp8
insert into emp8 values (2,'vamsikrishna',34444,20)