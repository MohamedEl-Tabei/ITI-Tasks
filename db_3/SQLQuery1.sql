--1--Display the Department id, name and id and the name of its manager.
SELECT Dname,Dnum, Fname AS manager
FROM Departments,Employee
WHERE MGRSSN=SSN


--2--Display the name of the departments and the name of the projects under its control.
SELECT D.Dname, P.Pname
FROM Project P JOIN Departments D
ON P.Dnum=D.Dnum


--3--Display the full data about all the dependence associated with the name of the employee they depend on him/her.
SELECT D.*
FROM Dependent D,Employee E
WHERE E.SSN=D.ESSN

--4--Display the Id, name and location of the projects in Cairo or Alex city.
SELECT Pnumber , Pname,Plocation
FROM Project
WHERE City='Alex' OR City='Cairo'

--5--Display the Projects full data of the projects with a name starts with "a" letter.
SELECT * 
FROM Project
WHERE Pname LIKE 'a%'

--6--display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
SELECT * 
FROM Employee
WHERE Dno=30 AND Salary BETWEEN 1000 AND 2000 


--7--Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
SELECT  Fname
FROM Employee E,Project P,Works_for W
WHERE 
--E.Dno=P.Dnum
--AND 
E.SSN=W.ESSn
AND  W.Pno=P.Pnumber
AND	P.Pname='AL Rabwah'
AND Dno=10 

SELECT Fname
FROM Employee E JOIN Project P
ON E.Dno=P.Dnum AND P.Pname='AL Rabwah'
JOIN Works_for W ON E.SSN=W.ESSn AND W.Pno=P.Pnumber AND W.Hours >= 10

--8--Find the names of the employees who directly supervised with Kamel Mohamed.
SELECT E.Fname
FROM Employee E, Employee S
WHERE E.Superssn=S.SSN 
AND S.Fname='Kamel' 
AND S.Lname='Mohamed'

--9--Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
SELECT E.Fname, P.Pname
FROM Employee E, Project P ,Works_for W
WHERE E.SSN=W.ESSn AND P.Pnumber=W.Pno
ORDER BY P.Pname

--10--For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
SELECT P.Pnumber, D.Dname,E.Lname ,E.Address,E.Bdate
FROM Project P JOIN Departments D ON P.Dnum = D.Dnum AND P.City='Cairo'
JOIN Employee E ON D.MGRSSN=E.SSN

--11--Display All Data of the managers
SELECT E.* 
FROM Employee E ,Departments D
WHERE E.SSN=D.MGRSSN

--12--Display All Employees data and the data of their dependents even if they have no dependents
SELECT*
FROM Dependent D RIGHT JOIN Employee E
ON D.ESSN=E.SSN

--13--Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
INSERT INTO Employee (Fname,Lname,SSN,Dno,Superssn,Salary)
VALUES ('Mohamed','Eltabei',102672,30,112233,3000)

--14--Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
INSERT INTO Employee(Fname,Lname,SSN,Dno)
VALUES ('Mohamed','Ali',102660,30)
select * from Employee

--15--Upgrade your salary by 20 % of its last value.
UPDATE Employee
SET Salary=Salary+(Salary*20)/100
WHERE SSN = 102672

