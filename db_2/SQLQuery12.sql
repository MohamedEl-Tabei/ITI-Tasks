--Display all the employees Data.
--1
SELECT * FROM Employee

--Display the employee First name, last name, Salary and Department number.
--2
SELECT Fname ,Lname ,Salary,Dno
FROM Employee


--Display all the projects names, locations and the department which is responsible about it.
--3
SELECT Pname, Plocation ,Dnum
FROM Project

--If you know that the company policy is to pay an annual commission for each employee with specific percent equals 10% of his/her annual salary .Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
--4
SELECT Fname+' '+Lname AS 'FULL NAME' , 'ANNUAL COMM'=(salary*12*10) /100
FROM Employee

--Display the employees Id, name who earns more than 1000 LE monthly.
--5
SELECT SSN ,Fname+' '+Lname AS 'FULL NAME'
FROM Employee
WHERE Salary>1000

--Display the employees Id, name who earns more than 10000 LE annually.
--6
SELECT SSN ,Fname+' '+Lname AS 'FULL NAME'
FROM Employee
WHERE (salary*12) > 10000

--Display the names and salaries of the female employees 
--7
SELECT Fname+' '+Lname AS 'FULL NAME',Salary
FROM Employee
WHERE SEX = 'F'

--Display each department id, name which managed by a manager with id equals 968574.
--8
SELECT Dnum, Dname
FROM Departments
WHERE MGRSSN = 968574

--Dispaly the ids, names and locations of  the pojects which controled with department 10.
--9
SELECT Pnumber ,Pname,Plocation 
FROM Project
WHERE Dnum = 10