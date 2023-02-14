USE [Flight_Management]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[spGetCustomers]

SELECT	@return_value as 'Return Value'

GO
