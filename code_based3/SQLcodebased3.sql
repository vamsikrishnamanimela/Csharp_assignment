use MyFirstDB
 create table Code_Employee ( empno int primary key, 
empname varchar(50) not null, 
empsal numeric(10,2) check(empsal >= 25000) , 
emptype varchar(1) check(emptype in('C','P')) ) 
select * from Code_Employee 
insert into Code_Employee  values(100,'vamsi',26000,'C')




CREATE OR ALTER PROCEDURE CO_EMPLOYEES(@EMPNAME VARCHAR(50),@EMPSAL NUMERIC(10,2),@EMPTYPE VARCHAR(1))
AS
BEGIN
DECLARE @ENO INT =(SELECT MAX(EMPNO) FROM CODE_EMPLOYEE)
BEGIN
DECLARE @EMPID INT = @ENO+ 1;
INSERT INTO CODE_EMPLOYEE VALUES(@EMPID,@EMPNAME,@EMPSAL,@EMPTYPE)
END
END

