
CREATE PROCEDURE [dbo].[GetEmployeeList]
AS
BEGIN
		SELECT * FROM Employee
END


--=====================================================

CREATE PROCEDURE [dbo].[GetEmployeeById]
@Id int
AS
BEGIN
		SELECT * FROM Employee where Id = @Id
END

--=====================================================

CREATE PROCEDURE [dbo].[AddEmployee]
@Name VARCHAR(30),
@City VARCHAR(30)
AS
BEGIN
		INSERT INTO Employee VALUES (@Name, @City)
END


--=====================================================


CREATE PROCEDURE [dbo].[UpdateEmployee]
@Id int,
@Name VARCHAR(30),
@City VARCHAR(30)
AS
BEGIN
		Update Employee 
		SET 
			Name = @Name,
			City = @City
		WHERE Id = @Id
END



--=====================================================

CREATE PROCEDURE [dbo].[DeleteEmployee]
@Id int
AS
BEGIN
		DELETE FROM Employee Where Id = @Id
END


--=====================================================