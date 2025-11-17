USE [2024R2DEV]
GO

/****** Object:  Table [dbo].[PRL_POS_Sales]    Script Date: 11/16/2025 8:02:11 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRL_POS_Sales]') AND type in (N'U'))
DROP TABLE [dbo].[PRL_POS_Sales]
GO


Begin Transaction
commit;