--DQL
--1.Display (Using Union Function)
--		a. The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--		b. And the male dependence that depends on Male Employee.

SELECT D.Dependent_name,D.Sex
FROM Dependent D, Employee E
WHERE D.ESSN=E.SSN AND D.Sex='F' AND E.Sex='F'
UNION
SELECT D.Dependent_name,D.Sex
FROM Dependent D, Employee E
WHERE D.ESSN=E.SSN AND D.Sex='M' AND E.Sex='M'


--2.For each project, list the project name and the total hours per week (for all employees) spent on that project.

SELECT P.Pname,SUM(W.Hours)
FROM Project P 
JOIN Works_for W
ON P.Pnumber=W.Pno
GROUP BY P.Pname


--3.Display the data of the department which has the smallest employee ID over all employees' ID.

SELECT D.*
FROM Departments D , Employee E
WHERE D.Dnum=E.Dno AND E.SSN IN (SELECT MIN(SSN) FROM Employee)



--4.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

SELECT D.Dname,MMA.maxSalary,MMA.minSalary,MMA.avgSalary
FROM Departments D 
JOIN(
SELECT MAX(E.Salary) AS maxSalary , MIN (E.Salary) AS minSalary , AVG(E.Salary) AS avgSalary,Dno
FROM Employee E
GROUP BY E.Dno) AS MMA
ON D.Dnum=MMA.Dno


--5.List the full name of all managers who have no dependents.

SELECT E.Fname+' '+E.Lname AS 'fullName'
FROM Departments D
JOIN Employee E
ON D.MGRSSN=E.SSN 
AND E.SSN NOT IN (
SELECT ESSN
FROM Dependent
GROUP BY ESSN
)


--6.For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.

SELECT D.Dnum,D.Dname,COUNT(E.Salary),AVG(E.Salary) 
FROM Employee E
JOIN Departments D
ON E.Dno=D.Dnum
GROUP BY D.Dnum,D.Dname
HAVING AVG(E.Salary)<(SELECT AVG(Salary) FROM Employee)


--7.Retrieve a list of employees names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.

SELECT E.Fname,E.Lname,P.Pname
FROM Employee E, Project P ,Departments D
WHERE D.Dnum=E.Dno AND D.Dnum=P.Dnum--EEPW
ORDER BY D.Dnum, E.Lname,E.Fname


--8.Try to get the max 2 salaries using subquery
SELECT S.maxSalary AS MAX1 ,MAX(E.Salary) AS MAX2 
FROM Employee E, (SELECT MAX(Salary) AS maxSalary FROM Employee ) S
WHERE E.Salary <  S.maxSalary
GROUP BY S.maxSalary

--9.Get the full name of employees that is similar to any dependent name

SELECT D.Dependent_name
FROM Dependent D, Employee E
WHERE D.Dependent_name=E.Fname+' '+E.Lname


--10.Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.

SELECT E.SSN, E.Fname
FROM Employee E
WHERE EXISTS (SELECT ESSN FROM Dependent WHERE ESSN=E.SSN)

--11.In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'

INSERT INTO Departments (Dname,Dnum,MGRSSN,[MGRStart Date]) VALUES('DEPT IT',100,112233,'1-11-2006')


--12.Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

--	A.First try to update her record in the department table
UPDATE Departments
SET MGRSSN=968574,[MGRStart Date]=GETDATE()
WHERE Dnum=100
--	B.Update your record to be department 20 manager.
UPDATE Departments
SET MGRSSN=102672,[MGRStart Date]=GETDATE()
WHERE Dnum=20
--	C.Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
UPDATE Employee
SET Superssn=102672
WHERE SSN=102660



--13.Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).
UPDATE Employee
SET Superssn=NULL
WHERE Superssn=223344
--
DELETE FROM Dependent WHERE ESSN=223344
--
UPDATE Departments
SET MGRSSN=NULL
WHERE MGRSSN=223344
--
DELETE FROM Works_for WHERE ESSn=223344
--
DELETE FROM Employee WHERE SSN=223344
--
--14.Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
UPDATE Employee
SET Salary=Salary+(Salary*30)/100
WHERE SSN  IN (
SELECT SSN  
FROM Employee E, Project P, Works_for W
WHERE E.SSN=W.ESSn
AND P.Pnumber=W.Pno
AND P.Pname='Al Rabwah'
)