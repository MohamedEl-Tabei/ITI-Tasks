--Part-1: Use ITI DB
--1.Retrieve number of students who have a value in their age. 

SELECT COUNT(St_Age)
FROM Student


--2.Get all instructors Names without repetition

SELECT DISTINCT Ins_Name
FROM Instructor


--3.Display student with the following Format (use isNull function)

SELECT S.St_Id AS [Student ID], 
ISNULL( S.St_Fname,'_')+' '+ ISNULL(S.St_Lname,'_') AS	[Student Full Name],
ISNULL(D.Dept_Name,'_') AS [Department name]
FROM Student S
LEFT JOIN Department D
ON S.Dept_Id=D.Dept_Id 


--4.Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not

SELECT I.Ins_Name , D.Dept_Name
FROM Instructor I
LEFT JOIN Department D
ON D.Dept_Id=I.Dept_Id


--5.Display student full name and the name of the course he is taking
--For only courses which have a grade 

SELECT S.St_Fname+' '+ S.St_Lname AS	[Student Full Name], C.Crs_Name,SC.Grade
FROM Student S, Course C, Stud_Course SC
WHERE S.St_Id=SC.St_Id AND C.Crs_Id=SC.Crs_Id

--6.Display number of courses for each topic name

SELECT COUNT(C.Top_Id) AS 'Number Of Courses',T.Top_Name
FROM Topic T,Course C
WHERE T.Top_Id=C.Top_Id
GROUP BY T.Top_Name


--7.Display max and min salary for instructors

SELECT MAX(Salary)
FROM Instructor I
UNION
SELECT MIN(Salary)
FROM Instructor


--8.Display instructors who have salaries less than the average salary of all instructors.

SELECT Salary
FROM Instructor
WHERE Salary<(SELECT AVG(Salary) FROM Instructor)


--9.Display the Department name that contains the instructor who receives the minimum salary.

SELECT TOP(1) D.Dept_Name
FROM Instructor I, Department D
WHERE I.Dept_Id=D.Dept_Id
ORDER BY I.Salary


--10.Select max two salaries in instructor table. 

SELECT TOP(2) Salary
FROM Instructor
ORDER BY  Salary DESC


--11.Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”

SELECT I.Ins_Name, COALESCE(CONVERT(VARCHAR,I.Salary),'bonus')
FROM Instructor I


--12.Select Average Salary for instructors 

SELECT AVG(Salary)
FROM Instructor


--13.Select Student first name and the data of his supervisor 

SELECT S.St_Fname,SP.*
FROM Student S ,Student SP
WHERE S.St_super=SP.St_Id


--14.Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
SELECT * FROM (
SELECT I.*,
DENSE_RANK() OVER(PARTITION BY I.Dept_Id ORDER BY I.Salary DESC ) AS DR
FROM Instructor I
) AS H2SD
WHERE (DR=1 OR DR=2) AND Dept_Id  IS NOT NULL 


--15.Write a query to select a random student from each department.  “using one of Ranking Functions”

SELECT TOP(1) *, NEWID() AS nwID 
FROM Student
ORDER BY nwID

--------------------------------------------------------------------------------------------------
--Part-2: Use AdventureWorks DB

--1.Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’

SELECT S.SalesOrderID, S.ShipDate
FROM Sales.SalesOrderHeader S
WHERE S.ShipDate BETWEEN '7/28/2002' and '7/29/2014'


--2.Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)

SELECT P.ProductID,P.Name
FROM Production.Product P
WHERE P.StandardCost<110


--3.Display ProductID, Name if its weight is unknown

SELECT P.ProductID,P.Name,P.Weight
FROM Production.Product P
WHERE P.Weight IS NULL


--4.Display all Products with a Silver, Black, or Red Color

SELECT *
FROM Production.Product P
WHERE P.Color IN ('Silver', 'Black', 'Red')


--5.Display any Product with a Name starting with the letter B

SELECT *
FROM Production.Product P
WHERE P.Name LIKE 'B%'


--6.Run the following Query
	UPDATE Production.ProductDescription
	SET Description = 'Chromoly steel_High of defects'
	WHERE ProductDescriptionID = 3
--Then write a query that displays any Product description with underscore value in its description.
SELECT *
FROM Production.ProductDescription P
WHERE P.Description LIKE '%[_]%'


--7.Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2014'

SELECT SUM(S.TotalDue),S.OrderDate 
FROM Sales.SalesOrderHeader S
WHERE S.OrderDate BETWEEN '7/1/2001' and '7/31/2014'
GROUP BY S.OrderDate


--8.Display the Employees HireDate (note no repeated values are allowed)

SELECT DISTINCT E.HireDate
FROM HumanResources.Employee E


--9.Calculate the average of the unique ListPrices in the Product table

SELECT AVG( DISTINCT P.ListPrice)
FROM Production.Product P


--10.Display the Product Name and its ListPrice within the values of 100 and 120 the list should has the following format 
-----"The [product name] is only! [List price]" (the list will be sorted according to its ListPrice value)

SELECT 'The '+P.Name +' is only! '+CONVERT(varchar,P.ListPrice)
FROM Production.Product P
WHERE P.ListPrice IN (100,120)
ORDER BY P.ListPrice


--11.A.Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table  in a newly created table named [store_Archive]
-----Note: Check your database to see the new table and how many rows in it?
SELECT S.rowguid,S.Name,S.SalesPersonID,S.Demographics
INTO store_Archive
FROM Sales.Store S

--11.B.Try the previous query but without transferring the data? 
SELECT S.rowguid,S.Name,S.SalesPersonID,S.Demographics
INTO store_Archive_
FROM Sales.Store S 
WHERE 1=2


--12.Using union statement, retrieve the today’s date in different styles using convert or format funtion.
SELECT CONVERT(varchar, GETDATE(), 101)
UNION
SELECT CONVERT(varchar, GETDATE(), 102)
UNION
SELECT CONVERT(varchar, GETDATE(), 103)
UNION
SELECT CONVERT(varchar, GETDATE(), 104)
