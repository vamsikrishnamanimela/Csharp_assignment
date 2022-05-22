USE MyFirstDB

--1.Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
--a)	HRA  as 10% Of sal
--b)	DA as  20% of sal
--c)	PF as 8% of sal
--d)	IT as 5% of sal
--e)	Deductions as sum of PF and IT
--f)	Gross Salary as sum of SAL,HRA,DA and Deductions
--g)	Net salary as  Gross salary- Deduction */

begin
declare @Salary float =65000;
declare @Salary1 float,
@Hra float,
@Da float,
@Pf float,
@It float
declare @Deductions float,
@Gross_Salary float,
@Net_Salary float
set @Hra =((@salary)*10/100)
print 'Total Hra Salary .....:'+cast(@Hra as varchar(10))
set @Da =((@salary)*20/100)
print 'Total Da Salary ....... :'+cast(@Da as varchar(10))
set @Pf =((@salary)*8/100)
print ' Total Pf Salary .......:'+cast(@Pf as varchar(10))
set @It =((@salary)*5/100)
print 'Total It Salary .....:'+cast(@It as varchar(10))
set @Deductions = @Pf+@It
print 'Deductions ...... :'+cast(@Deductions as varchar(10))
set @Salary1 = @salary -(@Hra+@Da+@Deductions)
set @Gross_Salary = @Salary1+(@Hra+@Da+@Deductions)
print 'Gross_Salary.....:'+cast(@Gross_SAlary as varchar(10))
set @Net_Salary = @Gross_Salary-@Deductions
print 'Total Net Salary......: '+cast(@Net_Salary as varchar(10))
end

--2.Write a T-SQL Program to find the factorial of a given number.

begin
	declare @number int
	declare @Find_fact int
	set @number=7
	set @Find_fact=1
while @number>0
	begin
		set @Find_fact=@Find_fact*@number
		set @number=@number-1
	end
	print 'Factorial of a given number......: '+cast(@Find_fact as varchar )
	
end

--3.Create a stored procedure to generate multiplication tables up to a given number.
CREATE or ALTER PROCEDURE Multi(@Table_number int)


as
begin
 declare @Multi_number int = 1, @Final_Result int
  
  while(@Multi_number<=10)
  begin
    set @Final_Result = @Table_number * @Multi_number
	PRINT CONCAT( @Table_number,'*',@Multi_number,'=',@Final_Result)
	
	
	

  set @Multi_number = @Multi_number+1
 end
  end

exec Multi @Table_number=10