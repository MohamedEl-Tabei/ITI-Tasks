--1.Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 
--and increases it by 20% if Salary >=3000. Use company DB

DECLARE C_EMP_SALARY CURSOR
FOR
	SELECT Salary
	FROM Employee
DECLARE @S INT 
OPEN C_EMP_SALARY
FETCH C_EMP_SALARY INTO @S
WHILE @@FETCH_STATUS=0
	BEGIN
		IF @S<3000
			UPDATE Employee
			SET Salary=@S+((@S*10)/100)
			WHERE CURRENT OF C_EMP_SALARY
		ELSE
			UPDATE Employee
			SET Salary=@S+((@S*20)/100)
			WHERE CURRENT OF C_EMP_SALARY
		FETCH C_EMP_SALARY INTO @S
	END
CLOSE C_EMP_SALARY 
DEALLOCATE C_EMP_SALARY 


--2.Display Department name with its manager name using cursor. Use ITI DB

DECLARE C_DEPT_MANAGER CURSOR
FOR 
	SELECT D.Dept_Name , M.Ins_Name 
	FROM Department D , Instructor M
	WHERE D.Dept_Manager=M.Ins_Id
DECLARE @D NVARCHAR(50) , @M NVARCHAR(50)
OPEN C_DEPT_MANAGER
FETCH C_DEPT_MANAGER INTO @D,@M
	WHILE @@FETCH_STATUS=0
	BEGIN
		SELECT @D , @M
		FETCH C_DEPT_MANAGER INTO @D , @M
	END
CLOSE C_DEPT_MANAGER
DEALLOCATE C_DEPT_MANAGER


--3.Try to display all students first name in one cell separated by comma. Using Cursor 

DECLARE C_ALL_FNAME CURSOR
FOR
	SELECT St_Fname
	FROM Student
	WHERE St_Fname IS NOT NULL
DECLARE @FN VARCHAR(50), @AN VARCHAR(500) = ''
OPEN C_ALL_FNAME
FETCH C_ALL_FNAME INTO @FN
WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @AN=@AN+' , '+@FN
		FETCH C_ALL_FNAME INTO @FN
	END
SELECT @AN 
CLOSE C_ALL_FNAME
DEALLOCATE C_ALL_FNAME

--4.Create full, differential Backup for SD DB.
--5.Use import export wizard to display students data (ITI DB) in excel sheet
--6.Try to generate script from DB ITI that describes all tables and views in this DB
--7.Create a sequence object that allow values from 1 to 10 without cycling in a specific column and test it.
CREATE SEQUENCE S
AS INT
	START WITH 1
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 10
	NO CYCLE

CREATE TABLE SEQ
(
ID INT,
NAME VARCHAR(50)
)

INSERT INTO SEQ VALUES(NEXT VALUE FOR S,'ALI')

SELECT* FROM SEQ