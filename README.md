# EmployeeInformationCRUD
CRUD in ASP.NET MVC using jQuery and JSON with Dapper ORM

<br>

</br>

<h2>Table (SQL Server)</h2>
CREATE TABLE [dbo].[Employee](<br><br><br>
	[Id] [int] IDENTITY(1,1) NOT NULL,<br><br>
	[Name] [varchar](50) NULL,<br>
	[City] [varchar](50) NULL,<br>
	[Address] [varchar](50) NULL,<br>
 CONSTRAINT [PK_Employee] PRIMARY KEY;<br>
 
<br>

</br>

<h2>Stored Procedures (SQL Server)</h2>

1. AddNewEmpDetails

USE [test]<br>
GO<br>
SET ANSI_NULLS ON<br>
GO<br>
SET QUOTED_IDENTIFIER ON<br>
GO<br>
CREATE procedure [dbo].[AddNewEmpDetails]<br>
(<br>
@Name varchar (50),<br>
@City varchar (50),<br>
@Address varchar (50),<br>
@EmpId int<br>
)<br>
as<br>
begin<br>
Insert into Employee values(@Name,@City,@Address)<br>
End;<br>


<br>

</br>

2. GetEmployees

USE [test]<br>
GO<br>
SET ANSI_NULLS ON<br>
GO<br>
SET QUOTED_IDENTIFIER ON<br>
GO<br>
CREATE Procedure [dbo].[GetEmployees]    <br>
as    <br>
begin    <br>
   select Id as Empid,Name,City,Address from Employee  <br>
End;<br>

<br>

</br>

3. UpdateEmpDetails

USE [test]<br>
GO<br>
SET ANSI_NULLS ON<br>
GO<br>
SET QUOTED_IDENTIFIER ON<br>
GO<br>
CREATE procedure [dbo].[UpdateEmpDetails]  <br>
(  <br>
   @EmpId int,  <br>
   @Name varchar (50),  <br>
   @City varchar (50),  <br>
   @Address varchar (50)  <br>
)  <br>
as  <br>
begin  <br>
   Update Employee  <br>
   set Name=@Name,  <br>
   City=@City,  <br>
   Address=@Address <br> 
   where Id=@EmpId  <br>
End;<br>

<br>

</br>

4. DeleteEmpById

USE [test]<br>
GO<br>
SET ANSI_NULLS ON<br>
GO<br>
SET QUOTED_IDENTIFIER ON<br>
GO<br>
CREATE procedure [dbo].[DeleteEmpById]  <br>
(  <br>
   @EmpId int  <br>
)  <br>
as  <br>
begin  <br>
   Delete from Employee where Id=@EmpId  <br>
End;<br>
