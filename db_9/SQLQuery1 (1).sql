--1.Create a stored procedure without parameters to show the number of students per department name.[use ITI DB] 
CREATE PROCEDURE SP_NUM_STD_DEPT
AS
	SELECT COUNT(S.Dept_Id) AS [Number of student], D.Dept_Name
	FROM Department D,Student S
	WHERE D.Dept_Id=S.Dept_Id
	GROUP BY D.Dept_Name

------------------------
EXECUTE SP_NUM_STD_DEPT ----EXECUTE
------------------------


--2.Create a stored procedure that will check for the # of employees in the project p1 (PNUMBER=100) if they are more than 3 
----print --message to the user “'The number of employees in the project p1 is 3 or more'” if they are less 
----display a message to the user “'The following employees work for the project p1'” 
----in addition to the first name and last name of each one. [Company DB] 
----100
CREATE PROC SP_EMP_P1
AS
	DECLARE @C INT
	SET @C=(SELECT COUNT(W.ESSn)FROM Works_for W WHERE W.Pno=100)
	IF(@C>3)
		SELECT 'The number of employees in the project p1 is 3 or more'
	ELSE 
		SELECT E.Fname+' '+E.Lname AS 'The following employees work for the project p1'
		FROM Works_for W, Employee E
		WHERE W.ESSn=E.SSN AND W.Pno=100

---------------
EXEC SP_EMP_P1--EXECUTE
---------------


--3.Create a stored procedure that will be used in case there is an old employee has left the project and 
--a new one become instead of him. 
--The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number) 
--and it will be used to update works_on table. [Company DB]

CREATE PROCEDURE SP_REPLACE_EMP_PRO @OEN INT , @NEN INT, @PN INT
AS 
	IF(EXISTS(SELECT * FROM Works_for WHERE ESSn=@OEN AND Pno=@PN))
		UPDATE Works_for
		SET ESSn=@NEN
		WHERE ESSn=@OEN AND Pno=@PN
	ELSE
		SELECT 'NOT EXIST'

------------------------------------
SP_REPLACE_EMP_PRO 112233,669955,400--EXECUTE
------------------------------------


--4.add column budget in project table 

ALTER TABLE Project
ADD budget INT

--and insert any draft values in it then 

UPDATE Project SET budget=1001 WHERE Pnumber=100 
UPDATE Project SET budget=2002 WHERE Pnumber=200 
UPDATE Project SET budget=3003 WHERE Pnumber=300 
UPDATE Project SET budget=4004 WHERE Pnumber=400 
UPDATE Project SET budget=5005 WHERE Pnumber=500 
UPDATE Project SET budget=6006 WHERE Pnumber=600 
UPDATE Project SET budget=7007 WHERE Pnumber=700 

--then Create an Audit table with the following structure 
--This table will be used to audit the update trials on the Budget column (Project table, Company DB)
-----------------------------------------------------------------
--ProjectNo | UserName | ModifiedDate | Budget_Old | Budget_New |
-----------------------------------------------------------------
--	p2		|	Dbo	   |  2008-01-31  |   95000	   |   200000   |
-----------------------------------------------------------------

CREATE TABLE Audit_Budget 
(
	ProjectNo INT FOREIGN KEY REFERENCES Project(Pnumber),
	UserName VARCHAR(100),
	ModifiedDate DATE,
	Budget_Old INT,
	Budget_New 	INT,
)

--Example:
--If a user updated the budget column then the project number, user name that made that update, 
--the date of the modification and the value of the old and the new budget will be inserted into the Audit table
--Note: This process will take place only if the user updated the budget column
CREATE TRIGGER TR_UPDATE_BUDGET
ON Project
AFTER UPDATE
AS
	DECLARE @OLD INT , @NEW INT , @PRO INT
	SELECT @PRO=Pnumber FROM deleted
	SELECT @OLD=budget FROM deleted
	SELECT @NEW=budget FROM inserted
	IF(UPDATE(budget))
		BEGIN
			INSERT INTO Audit_Budget
			VALUES
			(
				@PRO,
				SUSER_NAME(),
				GETDATE(),
				@OLD,
				@NEW
			)
		END

--5.Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
----“Print a message for user to tell him that he can’t insert a new record in that table”

CREATE TRIGGER TR_PREV_INSERT_DEPT
ON Department 
INSTEAD OF INSERT
AS 
	SELECT 'You can’t insert a new record in Department table'

---------------------------------------------
INSERT INTO Department
VALUES(80,'DEPT5','DESC','LOC',16,GETDATE())
---------------------------------------------

--6.Create a trigger that prevents the insertion Process for Employee table in March [Company DB].

CREATE TRIGGER TR_PREV_INSERT_EMP_MARCH
ON Employee
INSTEAD OF INSERT
AS
	IF(FORMAT(GETDATE(),'MMMM')='March')
		SELECT 'INSERT NOT ALLOWED IN MARCH'
	ELSE
		INSERT INTO Employee
		SELECT * FROM inserted


--7.
--(Server User Name , Date, Note) where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”

CREATE TABLE Audit_Student
(
	[Server User Name] VARCHAR(100) ,
	Date DATE ,
	Note VARCHAR(100)
) 

--Create a trigger on student table after insert to add Row in Student Audit table 
--where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”
CREATE TRIGGER TR_Audit_Student
ON Student
AFTER INSERT
AS
	DECLARE @K INT
	SELECT @K = St_Id FROM inserted
	INSERT INTO Audit_Student
	VALUES(SUSER_SNAME(),GETDATE(),SUSER_SNAME()+' '+'Insert New Row with Key='+CONVERT(VARCHAR(10),@K)+' in table student')


--8.Create a trigger on student table instead of delete to add Row in Student Audit 
---table (Server User Name, Date, Note) where note will be“ try to delete Row with Key=[Key Value]”

CREATE TRIGGER TR_PREV_DEL_STD
ON Student
INSTEAD OF DELETE
AS
	DECLARE @K INT
	SELECT @K = St_Id FROM deleted
	INSERT INTO Audit_Student
	VALUES(SUSER_SNAME(),GETDATE(),'try to delete Row with Key'+CONVERT(VARCHAR(10),@K)+' in table student')
	
DELETE FROM Student
WHERE St_Id=1
-------------------------------------------------------------------------------

--Bonus:
--1.Transform all functions in lab1 to be stored procedures

--1.1.Create a scalar function that takes date and returns Month name of that date.
CREATE PROC SP_GET_MONTH @D DATE
AS
	SELECT FORMAT(@D,'MMMM')

--------------------------
SP_GET_MONTH '11-20-2024'--EXECUTE
--------------------------


--1.2.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

CREATE PROC SP_BETWEEN @S INT , @E INT
AS
	DECLARE @T TABLE (VAL INT)
	SET @S=@S+1
	WHILE @S<@E
	BEGIN
		INSERT INTO @T VALUES(@S)
		SET @S=@S+1
	END
	SELECT * FROM @T

-----------------
SP_BETWEEN 1,10--EXECUTE
-----------------


--1.3.Create inline function that takes Student No and returns Department Name with Student full name.

CREATE PROC SP_STD_DEPTNAME @ID INT 
AS
	SELECT D.Dept_Name,S.St_Fname+' '+S.St_Lname AS 'Full Name'
	FROM Department D, Student S
	WHERE D.Dept_Id=S.Dept_Id AND S.St_Id=@ID

--------------------------
SP_STD_DEPTNAME 1--EXECUTE
--------------------------


--1.4.Create a scalar function that takes Student ID and returns a message to user 

CREATE PROC SP_NAME_IS_NULL @ID INT
AS
BEGIN
	DECLARE @M VARCHAR(50)
----a.If first name and Last name are null then display 'First name & last name are null'

	IF EXISTS (SELECT * FROM Student S WHERE S.St_Fname IS NULL AND S.St_Lname IS NULL AND S.St_Id=@ID )
		SET @M= 'First name & last name are null'

----b.If First name is null then display 'first name is null'

	ELSE
	IF EXISTS (SELECT * FROM Student S WHERE S.St_Fname IS NULL  AND S.St_Id=@ID )
		SET @M= 'first name is null'

----c.If Last name is null then display 'last name is null'

	ELSE
	IF EXISTS (SELECT * FROM Student S WHERE S.St_Lname IS NULL  AND S.St_Id=@ID )
		SET @M= 'last name is null'

----d.Else display 'First name & last name are not null'

	ELSE
		SET @M= 'First name & last name are not null'
	SELECT @M
END
------------------
SP_NAME_IS_NULL 12--EXECUTE
GO
SP_NAME_IS_NULL 13--EXECUTE
GO
SP_NAME_IS_NULL 14--EXECUTE
GO
SP_NAME_IS_NULL 15--EXECUTE
-------------------

--1.5.Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 

CREATE PROC SP_GET_MANGER @ID INT
AS
	SELECT D.Dept_Name,I.Ins_Name,D.Manager_hiredate
	FROM Instructor I ,Department D
	WHERE @ID=I.Ins_Id AND I.Ins_Id=D.Dept_Manager

----------------
SP_GET_MANGER 1--EXECUTE
GO
SP_GET_MANGER 2--EXECUTE
GO
SP_GET_MANGER 3--EXECUTE
----------------


--1.6.Create multi-statements table-valued function that takes a string

CREATE PROC SP_GET_COL @C VARCHAR(20)
AS
BEGIN
	DECLARE @T TABLE( Name VARCHAR(50))
----If string='first name' returns student first name

	IF @C='first name'
		INSERT INTO @T SELECT ISNULL(S.St_Fname,'Fname') FROM Student S
----If string='last name' returns student last name 
	ELSE
	IF @C='last name'
		INSERT INTO @T SELECT ISNULL(S.St_Lname,'Lname') FROM Student S
----If string='full name' returns Full Name from student table
	ELSE
	IF @C='full name'
		INSERT INTO @T SELECT ISNULL(S.St_Fname,'')+' '+ISNULL(S.St_Lname,'') FROM Student S
----Note: Use “ISNULL” function
	SELECT * FROM @T 
END

--------------------------------------
EXECUTE SP_GET_COL 'first name'--EXECUTE
GO
EXEC SP_GET_COL 'last name' -----EXECUTE
GO
SP_GET_COL 'full name' ----------EXECUTE
--------------------------------------


-----------------------------------------------------------------------------------------
--2.Create a trigger that prevents users from altering any table in Company DB.

CREATE TRIGGER TR_NO_ALTER
ON DATABASE
FOR  ALTER_TABLE
AS 
	BEGIN
		PRINT 'ALTER NOT ALLOWED'
		ROLLBACK TRANSACTION
	END
--------------------
ALTER TABLE Project
ADD newCOL INT
--------------------