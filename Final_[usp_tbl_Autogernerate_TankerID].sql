USE [DDISMandyaDairy_MIS_Liquid]
GO
/****** Object:  StoredProcedure [dbo].[usp_tbl_Autogernerate_TankerID]    Script Date: 02-Apr-24 13:47:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Chirag>
-- Create date: <Create Date,,18-03-2022>
-- Description:	<Description,,Auto Generate TankerID>
-- Changes By : <Shweta , 22-03-2024>
-- =============================================
-- exec usp_tbl_Autogernerate_TankerID 1

ALTER PROCEDURE [dbo].[usp_tbl_Autogernerate_TankerID]
(
	@Purpose int
)

as
BEGIN
	declare @Day varchar(2),@Month varchar(2), @Year varchar(4), @Date varchar(10)
	declare @TempP varchar(2), @Count int, @LastDigit int

	if @Purpose = 1
		set @TempP = 'Rx'
	else if @Purpose = 2
		set @TempP = 'Tx'

	set @Day = (Select FORMAT(getdate(),'dd')) 
	set @Month = (Select FORMAT(getdate(),'MM'))
	set @Year = (Select FORMAT(getdate(),'yyyy'))
	set @Date = @Year + @Month + @Day 

	set @Count = (Select COUNT(*) from tbl_WeightBridge where TankerID LIKE @Date + '%' + 'W1%' and IsDeleted = 0 and CONVERT(date,DateTime,103) = CONVERT(date,GETDATE(),103))
		--set @LastDigit = (SELECT ISNULL(CAST(RIGHT(MAX(TankerID), 3) AS INT), 0) AS latest_tanker_id
		--FROM [tbl_WeightBridge]
		--WHERE TankerID LIKE  @Date + '%' + 'W1%')
		
		--select @Date + @TempP +'W1'+ RIGHT('00'+CONVERT(varchar,(@LastDigit +1)),3) as 'TankerID'

		--set @LastDigit = (SELECT ISNULL(CAST(RIGHT(MAX(TankerID), 3) AS INT), 0) AS last_three_digits
		--		FROM [tbl_WeightBridge]
		--WHERE TankerID LIKE @Date + '%' + 'W1%') 
		if @Count=0
	begin
	select @Date + @TempP +'W1'+'001' as 'TankerID'
	end
	else
	begin
		set @LastDigit = (Select Top 1 right(TankerID,3) from tbl_WeightBridge where TankerID LIKE @Date + '%' + 'W1%'  and  IsDeleted = 0 and CONVERT(date,DateTime,103) = CONVERT(date,GETDATE(),103) order by WeightBridgeID desc)


		select @Date + @TempP +'W1'+ RIGHT('00'+CONVERT(varchar,(@LastDigit +1)),3) as 'TankerID'
		end
END

