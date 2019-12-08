USE [HolidayPlannerDB]
GO

/****** Object:  Table [dbo].[Support_Teams]    Script Date: 12/8/2019 10:18:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Support_Teams](
	[team_id] [int] IDENTITY(100,1) NOT NULL,
	[team_name] [varchar](100) NULL,
	[team_email] [varchar](100) NULL,
	[application_supported] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[team_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[team_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Support_Teams] ADD  DEFAULT ('Team email unavailable') FOR [team_email]
GO

ALTER TABLE [dbo].[Support_Teams]  WITH CHECK ADD FOREIGN KEY([application_supported])
REFERENCES [dbo].[Applications] ([gear_id])
GO


