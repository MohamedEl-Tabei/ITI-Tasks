--SQLServer Lab
--Note: Use ITI DB
--1.Create a scalar function that takes date and returns Month name of that date.

CREATE FUNCTION month_name (@D DATE)
RETURNS VARCHAR(15)
AS
BEGIN
	RETURN DATENAME(month,@D)
END
---------------------------------
SELECT DBO.month_name(GETDATE())--CALL
---------------------------------


--2.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

CREATE FUNCTION values_between(@S INT,@E INT)
RETURNS @T TABLE( VAL INT)
AS
BEGIN
	WHILE @S<@E-1
	BEGIN
		SET @S=@S+1
		INSERT INTO @T
		VALUES(@S)
	END
	RETURN
END
---------------------------------
SELECT*FROM values_between(1,10)--CALL
---------------------------------


--3.Create inline function that takes Student No and returns Department Name with Student full name.

CREATE FUNCTION get_student_by_id(@ID INT)
RETURNS TABLE
AS
RETURN
(
	SELECT D.Dept_Name,S.St_Fname+' '+S.St_Lname AS 'Full Name'
	FROM Department D, Student S
	WHERE D.Dept_Id=S.Dept_Id AND S.St_Id=@ID
)
--------------------------------------
SELECT * FROM DBO.get_student_by_id(1)--CALL
--------------------------------------


--4.Create a scalar function that takes Student ID and returns a message to user 

CREATE FUNCTION name_is_null(@ID INT)
RETURNS VARCHAR(50)
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
	RETURN @M
END
---------------------------
SELECT DBO.name_is_null(12)--CALL
SELECT DBO.name_is_null(13)--CALL
SELECT DBO.name_is_null(14)--CALL
SELECT DBO.name_is_null(15)--CALL
---------------------------

--5.Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 

CREATE FUNCTION get_manager(@ID INT)
RETURNS TABLE
AS
RETURN
(
	SELECT D.Dname,E.Fname,D.[MGRStart Date]
	FROM Employee E,Departments D
	WHERE @ID=E.SSN AND E.SSN=D.MGRSSN
)

---------------------------------
SELECT * FROM get_manager(102672)--CALL
SELECT * FROM get_manager(512463)--CALL
SELECT * FROM get_manager(669955)--CALL
---------------------------------
--6.Create multi-statements table-valued function that takes a string

CREATE FUNCTION get_col(@C VARCHAR(20))
RETURNS  @T TABLE( Name VARCHAR(50))
AS
BEGIN
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
	RETURN 
END

-----------------------------------
SELECT * FROM get_col('first name')--CALL
SELECT * FROM get_col('last name') --CALL
SELECT * FROM get_col('full name') --CALL
-----------------------------------
--7.Write a query that returns the Student No and Student first name without the last char

SELECT S.St_Id,SUBSTRING(S.St_Fname,1,LEN(S.St_Fname)-1)
FROM Student S


--8.Write query to delete all grades for the students Located in SD Department 

DELETE FROM Stud_Course 
FROM
Stud_Course SC
JOIN Student S
ON SC.St_Id=S.St_Id
JOIN Department D
ON D.Dept_Id=S.Dept_Id AND D.Dept_Name='SD'




/*
Bonus:
Give an example for hierarchyid Data type
Create a batch that inserts 3000 rows in the student table(ITI database). The values of the st_id column should be unique and between 3000 and 6000. All values of the columns st_fname, st_lname, should be set to 'Jane', ' Smith' respectively.
*/
