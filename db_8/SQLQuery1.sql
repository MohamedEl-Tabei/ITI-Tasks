--1.Create a view that displays student full name, course name if the student has a grade more than 50. 
CREATE VIEW v_student_grade(name,course,grade)
AS 
	SELECT S.St_Fname+' '+S.St_Lname , C.Crs_Name ,SC.Grade
	FROM Student S,Course C,Stud_Course SC
	WHERE SC.St_Id=S.St_Id AND SC.Crs_Id=C.Crs_Id AND SC.Grade>50
------------------------------
SELECT * FROM v_student_grade--CALL
------------------------------


--2.Create an Encrypted view that displays manager names and the topics they teach. 

CREATE VIEW v_manger_topics 
WITH ENCRYPTION
AS
	SELECT I.Ins_Name, T.Top_Name
	FROM Instructor I
	JOIN Department D
	ON D.Dept_Manager=I.Ins_Id
	JOIN Ins_Course IC
	ON IC.Ins_Id=I.Ins_Id
	JOIN Course C
	ON C.Crs_Id=IC.Crs_Id
	JOIN Topic T
	ON T.Top_Id=C.Top_Id

SP_HELPTEXT 'v_manger_topics'
------------------------------
SELECT * FROM v_manger_topics--CALL
------------------------------


--3.Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 

CREATE VIEW V_INS_SD_JAVA
AS
	SELECT I.Ins_Name , D.Dept_Name  
	FROM Instructor I,Department D
	WHERE I.Dept_Id=D.Dept_Id AND D.Dept_Name IN ('SD','JAVA')

------------------------------
SELECT * FROM V_INS_SD_JAVA--CALL
------------------------------

--4.Create a view “V1” that displays student data for student who lives in Alex or Cairo. 

CREATE VIEW V1 
AS
	SELECT *
	FROM Student
	WHERE St_Address IN ('Alex','Cairo')
WITH CHECK OPTION

------------------------------
SELECT * FROM V1--CALL
------------------------------
---Note: Prevent the users to run the following query 
Update V1 set st_address='tanta'
Where st_address='alex'


--5.Create a view that will display the project name and the number of employees work on it. “Use SD database”

CREATE VIEW V_NUM_EMP_PRO
AS
	SELECT P.ProjectName , COUNT(W.EmpNo) AS C
	FROM Works_on W , Company.Project P
	WHERE P.ProjectNo=W.ProjectNo
	GROUP BY P.ProjectName

------------------------------
SELECT * FROM V_NUM_EMP_PRO--CALL
------------------------------


--6.Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?

CREATE CLUSTERED INDEX I_Hiredate
ON Department(Manager_hiredate)
-- ONE CLUSTERED INDEX

--7.Create index that allow u to enter unique ages in student table. What will happen? 

CREATE UNIQUE INDEX I_Unique_Ages
ON Student(St_Age)
--NOT VALID BECUASE A DUPLICATED KEY (AGE) WAS FOUND


--8.Using Merge statement between the following two tables [User ID, Transaction Amount]

MERGE INTO Last_Transaction AS TRGT
USING Daily_Transaction AS SRC
ON TRGT.id=SRC.id
WHEN MATCHED THEN
	UPDATE SET TRGT.amount=SRC.amount
WHEN NOT MATCHED THEN 
	INSERT VALUES(SRC.id,SRC.amount)
Output $action;
---------------------------------------------------------------------------------------------------
--Part2: use SD_DB
--1.Create view named   “v_clerk” that will display employee#,project#, the date of hiring of all the jobs of the type 'Clerk'.

CREATE VIEW v_clerk 
AS
	SELECT EmpNo , ProjectNo , Enter_Date
	FROM Works_on 
	WHERE  Job='Clerk'
----------------------
SELECT * FROM v_clerk--CALL
----------------------


--2.Create view named  “v_without_budget” that will display all the projects data without budget
CREATE VIEW v_without_budget 
AS
	SELECT ProjectNo,ProjectName
	FROM Company.Project

------------------------------
SELECT * FROM v_without_budget--CALL
-------------------------------


--3.Create view named  “v_count “ that will display the project name and the # of jobs in it

CREATE VIEW v_count
AS 
	SELECT P.ProjectName , COUNT(W.Job) AS [# of jobs]
	FROM Company.Project P , Works_on W
	WHERE P.ProjectNo=W.ProjectNo
	GROUP BY P.ProjectName

----------------------
SELECT * FROM v_count--CALL
----------------------


--4.Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’ use the previously created view  “v_clerk”

CREATE VIEW v_project_p2
AS
	SELECT  VC.EmpNo 
	FROM v_clerk VC
	WHERE VC.ProjectNo='P2'

--------------------------
SELECT * FROM v_project_p2--CALL
---------------------------

--5.modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2 
ALTER VIEW v_without_budget
AS
	SELECT *
	FROM Company.Project
	WHERE ProjectNo IN ('p1','p2') 
------------------------------
SELECT * FROM v_without_budget--CALL
-------------------------------


--6.Delete the views  “v_ clerk” and “v_count”

DROP VIEW v_clerk
DROP VIEW v_count

--7.Create view that will display the emp# and emp lastname who works on dept# is ‘d2’

CREATE VIEW V_EMP_D2
AS
	SELECT E.EmpNo , E.EmpLname
	FROM HR.Employee E
	WHERE E.DeptNo='d2'

--------------------
SELECT * FROM V_EMP_D2--CALL
-----------------------

--8.Display the employee  lastname that contains letter “J” Use the previous view created in Q#7

SELECT V.EmpLname
FROM V_EMP_D2 V
WHERE V.EmpLname LIKE '%J%'

--9.Create view named “v_dept” that will display the department# and department name.

CREATE VIEW v_dept
AS
	SELECT D.DeptNo ,D.DeptName
	FROM Company.Department D

--------------------
SELECT * FROM v_dept--CALL
-----------------------

--10.using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’

INSERT INTO v_dept
VALUES('d4','Development')


--11.Create view name “v_2006_check” that will display employee#, the project #where he works 
--and the date of joining the project which must be from the first of January and the last of December 2006.

CREATE VIEW v_2006_check
AS
	SELECT W.EmpNo , W.ProjectNo , W.Enter_Date
	FROM Works_on W
	WHERE W.Enter_Date BETWEEN '1-1-2006' AND '12-31-2006'

--------------------
SELECT * FROM v_2006_check--CALL
-----------------------