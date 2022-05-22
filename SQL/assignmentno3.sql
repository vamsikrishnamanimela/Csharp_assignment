use MyFirstDB

--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
SELECT ENAME,SAL
FROM EMP
WHERE SAL >1500 AND SAL<2850

--2. Display the name and job of all employees who do not have a MANAGER.
SELECT ENAME,JOB 
FROM EMP
WHERE JOB!='MANAGER' 
SELECT*FROM EMP
--3. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST 
--and their salary is not equal to 1000, 3000, or 5000. 
SELECT ENAME,JOB,SAL
FROM EMP
WHERE JOB IN ('MANAGER','ANALYST') AND SAL NOT IN(1000,3000,5000)

--4. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
SELECT ENAME,SAL+SAL*10/100 AS "Salary Increased By 10%",COMM
FROM EMP
WHERE COMM>SAL

--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
SELECT ENAME 
FROM EMP
WHERE ENAME LIKE '%LL%' AND DEPTNO=30 OR MGR=7782
SELECT * FROM EMP
--6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees.


SELECT ENAME

FROM EMP

WHERE DATEDIFF(YEAR, HIREDATE, GETDATE())<10 AND DATEDIFF(YEAR, HIREDATE, GETDATE())<20


 
--7. Retrieve the names of departments in ascending order and their employees in descending order.

SELECT DNAME ,ENAME
FROM EMP, DEPT 
WHERE EMP.DEPTNO=EMP.DEPTNO 
<<<<<<< HEAD
ORDER BY  DEPT.DNAME ,EMP.ENAME DESC 
=======
ORDER BY ENAME DESC,DNAME 
>>>>>>> 8dcaa9efdba6080929efe6bab693aca6a0bd79c3
--8. Find out experience of MILLER.
Declare @HIREDATE datetime  
Declare @currentdate datetime  
Declare @years varchar(4)  
set @HIREDATE = '1982-01-23'  
set @currentdate  = getdate()
select @years = datediff(YEAR,@HIREDATE,@currentdate)  
select @years   + ' YEAR,' AS YEARS 
SELECT * FROM EMP
--9. How many different departments are there in the employee table. 
SELECT COUNT(*) AS "COUNT",DEPTNO
FROM EMP
GROUP BY DEPTNO 
--10. Find out which employee either work in SALES or RESEARCH department. 
SELECT *
FROM EMP
WHERE DEPTNO IN (SELECT DEPTNO
FROM DEPT
WHERE  DNAME IN ('SALES','RESEARCH '))
SELECT * FROM DEPT
SELECT * FROM EMP
--11. Print the name and average salary of each department.
SELECT ENAME,AVG(SAL) AS AVERAGE_SALARY 
FROM EMP GROUP BY ENAME;
--12. Select the minimum and maximum salary from employee table. 
SELECT MAX(SAL) AS "MAX SAL" , MIN(SAL) AS "MINSAL"
FROM EMP
--13. Select the minimum and maximum salaries from each department in employee table.
SELECT MAX(SAL) AS "MAX SAL" , MIN(SAL) AS "MINSAL"
FROM EMP
GROUP BY DEPTNO
--14. Select the details of employees whose salary is below 1000 and job is CLERK.
SELECT *
FROM EMP
WHERE SAL<1000 AND JOB ='CLERK'
<<<<<<< HEAD

INSERT INTO EMP VALUES(8000,'VAMSI','PRESIDENT',NULL,'2000-11-17',50000,NULL,10
SELECT* FROM EMP
=======
>>>>>>> 8dcaa9efdba6080929efe6bab693aca6a0bd79c3
