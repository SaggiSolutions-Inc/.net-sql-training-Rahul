Create database practice; -- CREATING DATABASE 


use practice;

--CREATING DEPARTMENT TABLE

CREATE TABLE Department(
    DepartmentID INT,
    DepartmentName VARCHAR(100),
    Location VARCHAR(100),
	primary key(DepartmentID));


INSERT INTO Department (DepartmentID, DepartmentName, Location)
VALUES
(10, 'Engineering', 'New York, NY'),
(20, 'Training', 'San Francisco, CA'),
(30, 'Human Resources', 'Chicago, IL'),
(40, 'Sales', 'Seattle, WA'),
(50, 'Finance', 'Chicago, IL'),
(60, 'Computer Science', 'Dallas, TX'),
(70, 'IT', 'Miami, FL');


select*from department;

--CREATING EMPLOYEE TABLE

CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    HireDate DATE,
    JobTitle VARCHAR(100),
    Salary DECIMAL(10, 2),
    ManagerID INT,
	DepartmentID INT,
	FOREIGN KEY(DepartmentID) REFERENCES Department(DepartmentID));

INSERT INTO Employee (EmployeeID, FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, ManagerID, DepartmentID)
VALUES
(1, 'John', 'Doe', 'john.doe@example.com', '123-456-7890', '2023-01-15', 'Software Engineer', 75000.00, 100, 10),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '234-567-8901', '2023-03-10', 'Training Specialist', 60000.00, 101, 20),
(3, 'Mike', 'Johnson', 'mike.johnson@example.com', '345-678-9012', '2022-11-20', 'HR Manager', 80000.00, 102, 30),
(4, 'Emily', 'Davis', 'emily.davis@example.com', '456-789-0123', '2021-05-12', 'Sales Representative', 55000.00, 103, 40),
(5, 'Chris', 'Brown', 'chris.brown@example.com', '567-890-1234', '2020-07-19', 'Financial Analyst', 65000.00, 104, 50),
(6, 'Anna', 'Taylor', 'anna.taylor@example.com', '678-901-2345', '2019-10-25', 'Computer Scientist', 95000.00, 105, 60),
(7, 'David', 'Wilson', 'david.wilson@example.com', '789-012-3456', '2023-02-14', 'IT Specialist', 70000.00, 106, 70);

Select * From Employee; 

-- CREATING STUDENT TABLE
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(100),
    EnrollmentDate DATE
);

-- INSERTING VALUES INTO STUDENT TABLE
INSERT INTO Student (StudentID, FirstName, LastName, Email, EnrollmentDate)
VALUES
(1, 'Alice', 'Johnson', 'alice.johnson@example.com', '2023-09-01'),
(2, 'Bob', 'Smith', 'bob.smith@example.com', '2022-06-15'),
(3, 'Charlie', 'Brown', 'charlie.brown@example.com', '2023-01-10'),
(4, 'Diana', 'Davis', 'diana.davis@example.com', '2021-11-20'),
(5, 'Eve', 'White', 'eve.white@example.com', '2020-08-30');

SELECT*FROM Student;

--CREATING COURSE TABLE
CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100),
    DurationInWeeks INT
);

-- INSERTING VALUES INTO COURSE TABLE
INSERT INTO Course (CourseID, CourseName, DurationInWeeks)
VALUES
(1, 'Introduction to Programming', 12),
(2, 'Data Structures and Algorithms', 16),
(3, 'Web Development', 10),
(4, 'Database Management', 14),
(5, 'Software Engineering', 18);

SELECT*FROM course;

--CREATING JUNCTION TABLE FOR EMPLOYEE,STUDENT,COURSE TABLE USING COMPOSITE PRIMARY KEY

CREATE TABLE EmployeeStudentCourse (
    EmployeeID INT,
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Course(CourseID));

--INSERTING VALUES INTO EMPLOYEESTUDENTCOURSE
INSERT INTO EmployeeStudentCourse (EmployeeID, StudentID, CourseID)
VALUES
(1, 1, 1),  
(2, 2, 2),  
(3, 3, 3),  
(4, 4, 4),  
(5, 5, 5),  
(6, 1, 5);  
INSERT INTO EmployeeStudentCourse (EmployeeID, StudentID, CourseID)
VALUES
(1, 2, 1);



--TO GET THE ENAME,SNAME,CNAME
SELECT 
    CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeFullName,
    CONCAT(s.FirstName, ' ', s.LastName) AS StudentFullName,
    c.CourseName
FROM 
    EmployeeStudentCourse esc
JOIN 
    Employee e ON esc.EmployeeID = e.EmployeeID
JOIN 
    Student s ON esc.StudentID = s.StudentID
JOIN 
    Course c ON esc.CourseID = c.CourseID;

--TO GET THE ENAME,NO.OF STUDENTS THAT EMPLOYEE IS TRAINING

SELECT 
    e.EmployeeID,CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeFullName,
    COUNT(esc.StudentID) AS NumberOfStudents
FROM 
    EmployeeStudentCourse esc
JOIN 
    Employee e ON esc.EmployeeID = e.EmployeeID
JOIN 
    Course c ON esc.CourseID=c.CourseID
GROUP BY 
    e.EmployeeID, e.FirstName, e.LastName;

	select*from course;
	select*from Employee;
    select*from Department;
    select*from EmployeeStudentCourse;

------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[ENTITY_COURSE] (
    ENTITY_ID INT NOT NULL, 
    COURSEID INT NOT NULL,
    ROLE CHAR(1) NOT NULL CHECK (ROLE IN ('S', 'E')), 
    ACTION_DATE DATE NOT NULL, 
    PRIMARY KEY (ENTITY_ID, COURSEID, ROLE),
    FOREIGN KEY (COURSEID) REFERENCES COURSE(COURSEID),
    CONSTRAINT FK_ENTITY_COURSE_EMP FOREIGN KEY (ENTITY_ID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE,
    CONSTRAINT FK_ENTITY_COURSE_STUDENT FOREIGN KEY (ENTITY_ID) REFERENCES Student(StudentID) ON DELETE CASCADE
);

-- For a student taking a course
INSERT INTO ENTITY_COURSE (ENTITY_ID, COURSEID, ROLE, ACTION_DATE)
VALUES
(1, 1, 'S', '2023-01-15'), -- Student with ID 1 enrolled in Course 1
(2, 2, 'S', '2023-03-01'); -- Student with ID 2 enrolled in Course 2

-- For an employee assigned to a course
INSERT INTO ENTITY_COURSE (ENTITY_ID, COURSEID, ROLE, ACTION_DATE)
VALUES
(1, 3, 'E', '2023-02-20'), -- Employee with ID 1 assigned to Course 3
(2, 4, 'E', '2023-04-05'); -- Employee with ID 2 assigned to Course 4

SELECT * FROM ENTITY_COURSE;

create procedure Sp_GetAllEmployees  -- Creating a stored procedure for displaying the employee table

As
BEGIN
     Select * from Employee;
END;

EXEC Sp_GetAllEmployees;

Create procedure spx_InsertEmployee
@EmployeeID Int,
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@PhoneNumber varchar(100),
@HireDate date,
@JobTitle varchar(100),
@Salary Decimal (10,2),
@ManagerID int,
@DepartmentID int
AS
BEGIN
     BEGIN TRY
	 IF EXISTS ( SELECT 1 FROM Employee WHERE EmployeeID = @EmployeeID)
	    BEGIN
		    THROW 50001, 'Employee with the given EmployeeID alredy exists.', 1;
			END

			INSERT INTO Employee (EmployeeID, FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, ManagerID, DepartmentID)
            VALUES (@EmployeeID, @FirstName, @LastName, @Email, @PhoneNumber, @HireDate, @JobTitle, @Salary, @ManagerID, @DepartmentID);

	    END TRY
		BEGIN CATCH 
		      PRINT 'Error occured during insertion';
			  PRINT ERROR_MESSAGE();
	    END CATCH
	END;
		 

EXEC spx_InsertEmployee 
@EmployeeID = 10,
@FirstName = 'osacr',
@LastName ='john',
@Email = 'oscarjohn@gmail.com',
@PhoneNumber = '123-234-2355',
@HireDate = '2025-01-24',
@JobTitle = 'Software Engineer',
@Salary = 1500000.00,
@ManagerID = 106,
@DepartmentID = 10;

EXEC spx_InsertEmployee 
@EmployeeID = 8,
@FirstName = 'Rahul',
@LastName ='Yadav',
@Email = 'Rahulyadav@gmail.com',
@PhoneNumber = '888-888-8686',
@HireDate = '2025-01-24',
@JobTitle = 'Software Engineer',
@Salary = 1500000.00,
@ManagerID = 106,
@DepartmentID = 10;


Select * from Employee;

create procedure spx_UpdateEmployee -- Creating a stored procedure for updating an employee in the employee table
@EmployeeID Int,
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@PhoneNumber varchar(100),
@HireDate date,
@JobTitle varchar(100),
@Salary Decimal (10,2),
@ManagerID int,
@DepartmentID int

As
BEGIN
     BEGIN TRY 
	 IF NOT EXISTS (Select 1 from Employee Where EmployeeID = @EmployeeID)
	  BEGIN
	    THROW 50002, 'Employee not found for the given Employee.', 1;
	  END

	  Update Employee
	   SET
			FirstName = @FirstName,
			LastName = @LastName,
			Email = @Email,
			PhoneNumber = @PhoneNumber ,
			HireDate = @HireDate ,
			JobTitle = @JobTitle,
			Salary = @Salary,
			ManagerID = @ManagerID,
			DepartmentId = @DepartmentID
			WHERE EmployeeID = @EmployeeID;
     
  END TRY
  BEGIN CATCH 
      PRINT 'Error occurred while updating the record';
	  PRINT ERROR_MESSAGE();
  END CATCH 

 END;

EXEC spx_UpdateEmployee
@EmployeeID = 10,
@FirstName = 'oscar',
@LastName ='Smith',
@Email = 'oscarjohn@gmail.com',
@PhoneNumber = '123-234-2355',
@HireDate = '2025-01-24',
@JobTitle = 'Software Engineer',
@Salary = 75000.00,
@ManagerID = 106,
@DepartmentID = 10;

select * from Employee;



EXEC spx_UpdateEmployee
@EmployeeID = 11,
@FirstName = 'oscar',
@LastName ='Smith',
@Email = 'oscarjohn@gmail.com',
@PhoneNumber = '123-234-2355',
@HireDate = '2025-01-24',
@JobTitle = 'Software Engineer',
@Salary = 75000.00,
@ManagerID = 106,
@DepartmentID = 10;


exec Sp_GetAllEmployees;

Create Procedure spx_DeleteEmployee          -- Creating a stored procedure for deleting the employee in the table.
@EmployeeID int 

AS
BEGIN 
   BEGIN TRY 
    IF NOT EXISTS (SELECT 1 FROM Employee WHERE EmployeeID = @EmployeeID)
	BEGIN 
	   THROW 50005, 'Employee not found for the given EmployeeID.',1;
	   END
	   
	   DELETE FROM Employee WHERE EmployeeID = @EmployeeID;

	END TRY
	BEGIN CATCH 
	PRINT ' Error occure while delecting the recor';
	PRINT ERROR_MESSAGE();
	END CATCH
END;

EXEC spx_DeleteEmployee
@EmployeeID = 10;

exec Sp_GetAllEmployees


EXEC spx_DeleteEmployee
@EmployeeID = 11;

EXEC spx_DeleteEmployee 
@EmployeeID = 2;


select * from Department;

Create Procedure spx_InsertDepartment
@DepartmentID int,
@DepartmentName varchar(100),
@Location varchar(100)

AS
BEGIN 
     BEGIN TRY
	 IF EXISTS ( SELECT 1 FROM Department WHERE DepartmentID = @DepartmentID)
	 BEGIN
	   THROW 50006, 'Department with the Department already exits.',1;
	 END

	 INSERT INTO Department(DepartmentID,DepartmentName,Location)
	 VALUES (@DepartmentID,@DepartmentName,@Location);

	 END TRY
	 BEGIN CATCH 
	    PRINT ' Error occurred during insertion';
		PRINT ERROR_MESSAGE();
	 END CATCH
END;

EXEC spx_InsertDepartment  -- Inserts a record into the Department table.
@DepartmentID = 100,
@DepartmentName = 'Timepass',
@Location = 'Intlo';

Select * from Department;

EXEC spx_InsertDepartment      -- This query should throw an error as the DepartmentID already exists.
@DepartmentID = 10,
@DepartmentName = 'Training',
@Location = 'Virginia';

Create Procedure spx_UpdateDepartment    -- Creating a stored procedure to update department with the exception handling 
@DepartmentID int,
@DepartmentName varchar(100),
@Location varchar(100)

AS
BEGIN
  BEGIN TRY 
  IF NOT EXISTS( SELECT 1 FROM Department WHERE DepartmentID = @DepartmentID)
  BEGIN 
  THROW 50007, 'No Department is found with the provided Department ID.',1;
  END

  UPDATE Department
  SET DepartmentName = @DepartmentName,
      Location = @Location
	  Where DepartmentID = @DepartmentID;

  END TRY

  BEGIN CATCH
    PRINT 'Error occurred while fetching records';
	PRINT ERROR_MESSAGE();
	END CATCH 
END;

EXEC spx_UpdateDepartment         --- Updates the department table if the given DepartmentID exists
@DepartmentID = 100,
@DepartmentName = 'Manufacturing',
@Location = 'Manassas';

Select * FROM Department;

EXEC spx_UpdateDepartment         --- Throws an error as the give DepartmentID is not available in the Table.
@DepartmentID = 500,
@DepartmentName = 'Manufacturing',
@Location = 'Manassas';

Create Procedure spx_DeleteDepartment
@DepartmentID int
As
BEGIN
  BEGIN TRY 
   IF NOT EXISTS(SELECT 1 FROM Department WHERE DepartmentID = @DepartmentID)
   BEGIN
   THROW 50008, 'Provided Department ID does not exists.',1;
   END

   DELETE FROM Department WHERE DepartmentID = @DepartmentID;
   END TRY
   BEGIN CATCH
     PRINT 'Error occured while fetching records.';
	 PRINT ERROR_MESSAGE();
   END CATCH
END;

EXEC spx_DeleteDepartment
@DepartmentID = 100;

Select * From Student;

Create procedure spx_InsertStudent
@StudentID INT,
@FirstName VARCHAR(100),
@LastName VARCHAR(100),
@Email VARCHAR(100),
@EnrollmentDate DATE

AS
BEGIN
 BEGIN TRY 
   IF EXISTS(SELECT 1 FROM Student WHERE StudentID = @StudentID)
   BEGIN
   THROW 50009, 'The Given Student ID already exists cannot create duplicate.',1;
   END

 INSERT INTO Student (StudentID, FirstName, LastName, Email, EnrollmentDate)
 VALUES (@StudentID,@FirstName,@LastName,@Email,@EnrollmentDate);
 
 END TRY

 BEGIN CATCH
  PRINT 'Error occured while fetching records';
  PRINT ERROR_MESSAGE();
  END CATCH
END;

EXEC spx_InsertStudent
@StudentID = 66,
@FirstName =  Raya,
@LastName = Samrah,
@Email = 'rayasamrah@gmail.com',
@EnrollmentDate='01-24-2025';

select * from Student;

 Create Procedure spx_UpdateStudent -- Creating the stored procedure for updating thea student record in the student table
@StudentID INT,
@FirstName VARCHAR(100),
@LastName VARCHAR(100),
@Email VARCHAR(100),
@EnrollmentDate DATE

As
BEGIN 
 BEGIN TRY 
   IF NOT EXISTS( SELECT 1 FROM Student WHERE StudentID = @StudentID)
   BEGIN 
   THROW 50010,'The provided StudentID does not exist.',1;
   END
   Update Student
   Set FirstName = @FirstName,
       LastName = @LastName,
       Email= @Email,
       EnrollmentDate = @EnrollmentDate
	   WHERE  StudentID = @StudentID;
	 END TRY
    BEGIN CATCH
	     PRINT 'Error occurred while updating the record.';
		 PRINT ERROR_MESSAGE();
	END CATCH
END;

EXEC spx_UpdateStudent
@StudentID= 66,
@FirstName ='Rambo',
@LastName = 'Smart',
@Email = 'rambosmart@gmail.com',
@EnrollmentDate = '01-24-2025';

select * from Student;

Create Procedure spx_DeleteStudent
@StudentID Int
As
BEGIN
   BEGIN TRY 
   IF NOT EXISTS( SELECT 1 FROM Student WHERE StudentID = @StudentID)
   BEGIN
   THROW 50011, 'The PRovide StudentID does not exists.',1;
   END

   DELETE FROM Student WHERE StudentID = @StudentID;
   END TRY
   
   BEGIN CATCH
   PRINT 'Error while fetching the records';
   PRINT ERROR_MESSAGE();
   END CATCH 

END;

EXEC spx_DeleteStudent
@StudentID = 66;

Create Procedure spx_InsertCourse
@CourseID INT,
@CourseName VARCHAR(100),
@DurationInWeeks INT

AS
BEGIN 
 BEGIN TRY 
  IF EXISTS(SELECT 1 FROM Course WHERE CourseID = @CourseID)
  BEGIN
  THROW 50012,'The Course ID already exists.',1;
  END

INSERT INTO Course(CourseID,CourseName,DurationInWeeks)
VALUES (@CourseID,@CourseName,@DurationInWeeks)

END TRY
BEGIN CATCH
PRINT 'Error inserting the records'
PRINT ERROR_MESSAGE();
END CATCH
END;

Select * from Course;

EXEC spx_InsertCourse
@CourseID = 68,
@CourseName = '.Net core',
@DurationInWeeks = 10;

CREATE PROCEDURE spx_UpdateCourse
@CourseID INT,
@CourseName VARCHAR(100),
@DurationInWeeks INT

As
BEGIN 
 BEGIN TRY 
   IF NOT EXISTS( SELECT 1 FROM Course WHERE CourseID = @CourseID)
   BEGIN 
   THROW 50010,'The provided CourseID does not exist.',1;
   END
   Update Course
   Set CourseName = @CourseName,
       DurationInWeeks = @DurationInWeeks
	   WHERE  CourseID = @CourseID;
	 END TRY
    BEGIN CATCH
	     PRINT 'Error occurred while updating the record.';
		 PRINT ERROR_MESSAGE();
	END CATCH
END;
