USE [Business]
GO
/****** Object:  StoredProcedure [dbo].[spGetEmployeeById]    Script Date: 15/10/2017 15:05:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spGetEmployeeById] 
	@ID varchar

AS
BEGIN
	SELECT ID, FirstName, LastName, Mail,Phone, Salary FROM Employees WHERE ID= @ID
END
