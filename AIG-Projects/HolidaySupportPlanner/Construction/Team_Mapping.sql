USE [HolidayPlannerDB]
GO

/****** Object:  Table [dbo].[Team_Mapping]    Script Date: 12/8/2019 10:17:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Team_Mapping](
	[team_id] [int] NULL,
	[member_id] [int] NULL,
	[is_Lead] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Team_Mapping] ADD  DEFAULT ((0)) FOR [is_Lead]
GO

ALTER TABLE [dbo].[Team_Mapping]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[Resources] ([resource_id])
GO

ALTER TABLE [dbo].[Team_Mapping]  WITH CHECK ADD FOREIGN KEY([team_id])
REFERENCES [dbo].[Support_Teams] ([team_id])
GO


