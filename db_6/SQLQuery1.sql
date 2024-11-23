--1-Create Department by code

CREATE TABLE Department
(
	DeptNo VARCHAR(10) PRIMARY KEY,
	DeptName VARCHAR(20) NOT NULL,
	Location VARCHAR(2) 
)

--2-Create a new user data type named loc with the following Criteria:
-----nchar(2)

SP_ADDTYPE LOC ,'NCHAR(2)'

-----default:NY 

CREATE DEFAULT def_ny AS 'NY'
SP_BINDEFAULT def_ny,LOC

-----create a rule for this Datatype :values in (NY,DS,KW))

CREATE RULE r_loc AS @l in ('NY','DS','KW')
SP_BINDRULE r_loc, LOC

-----associate it to the location column  

ALTER TABLE Department
ALTER COLUMN Location LOC

----------------------------------------------------------------------------

--1-Create Employee by code

CREATE TABLE Employee
(
--2-PK constraint on EmpNo

EmpNo INT PRIMARY KEY,

--3-FK constraint on DeptNo

DeptNo VARCHAR(10) FOREIGN KEY REFERENCES Department(DeptNo),

--4-Unique constraint on Salary

Salary INT UNIQUE,

--5-EmpFname, EmpLname don’t accept null values

EmpFname VARCHAR(20) NOT NULL,
EmpLname VARCHAR(20) NOT NULL
)
--6-Create a rule on Salary column to ensure that it is less than 6000 

CREATE RULE r_salary AS @s<6000
SP_BINDRULE r_salary,'Employee.Salary'

----------------------------------------------------------------------------
--Testing Referential Integrity


--1-Add new employee with EmpNo =11111 In the works_on table [what will happen]

---------conflict with foreign key constraint "FK_WORKON_EMPLOYEE"

--2-Change the employee number 10102  to 11111  in the works on table [what will happen]

---------conflict with foreign key constraint "FK_WORKON_EMPLOYEE"

--3-Modify the employee number 10102 in the employee table to 22222. [what will happen]

---------conflict with refernce constraint "FK_WORKON_EMPLOYEE"

--4-Delete the employee with id 10102

---------conflict with refernce constraint "FK_WORKON_EMPLOYEE"

----------------------------------------------------------------------------

--Table modification

--1-Add  TelephoneNumber column to the employee table[programmatically]

ALTER TABLE Employee
ADD TelephoneNumber VARCHAR(15)

--2-drop this column[programmatically]

ALTER TABLE Employee
DROP COLUMN TelephoneNumber
----------------------------------------------------------------------------

--2-Create the following schema and transfer the following tables to it 
--Company Schema 

CREATE SCHEMA Company

--Department table (Programmatically)

ALTER SCHEMA Company TRANSFER Department

--Human Resource Schema

CREATE SCHEMA HR

--Employee table (Programmatically)

ALTER SCHEMA HR TRANSFER Employee 

-- Write query to display the constraints for the Employee table.
SP_HELPCONSTRAINT 'HR.Employee'

--Create Synonym for table Employee as Emp and then run the following queries and describe the results
CREATE SYNONYM EMP
FOR SD.HR.Employee

--Select * from Employee --> ERROR DBO.EMPLOYEE 
--Select * from HR.Employee --> VALID
--Select * from Emp --> VALID
--Select * from HR.Emp --> ERROR SCHEMA HR NOT HAVE EMP
----------------------------------------------------------------------
--5.Increase the budget of the project where the manager number is 10102 by 10%.

UPDATE Company.Project 
SET Budget=Budget+(Budget*10)/100
WHERE ProjectNo IN
(
SELECT W.ProjectNo
FROM Works_on W
WHERE W.EmpNo=10102 AND W.Job='Manager'
)


--6.Change the name of the department for which the employee named James works.The new department name is Sales.

UPDATE Company.Department
SET DeptName='Sales'
FROM Company.Department D
JOIN HR.Employee E
ON E.DeptNo =D.DeptNo AND E.EmpFname='James'


--7.Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. 
--The new date is 12.12.2007.

UPDATE Works_on
SET Enter_Date='12-12-2007'
FROM Works_on W 
JOIN HR.Employee E
ON W.EmpNo=E.EmpNo AND W.ProjectNo='p1'
JOIN Company.Department D
ON E.DeptNo=D.DeptNo AND D.DeptName='Sales'


--8.Delete the information in the works_on table for all employees who work for the department located in KW.

DELETE FROM Works_on 
WHERE EmpNo 
IN(
SELECT EmpNo
FROM Company.Department D, HR.Employee E
WHERE E.DeptNo=D.DeptNo AND D.Location='KW'
)

--9.Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB then allow him to select and insert data into tables and deny Delete and update .(Use ITI DB)
