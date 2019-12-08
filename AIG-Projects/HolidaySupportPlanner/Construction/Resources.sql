USE [HolidayPlannerDB]
GO

/****** Object:  Table [dbo].[Resources]    Script Date: 12/8/2019 10:17:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Resources](
	[resource_id] [int] IDENTITY(100,1) NOT NULL,
	[resource_name] [varchar](200) NULL,
	[contact_number] [varchar](15) NULL,
	[email_id] [varchar](100) NOT NULL,
	[associate_app_id] [int] NULL,
	[resource_status] [int] NULL,
	[is_support_personnel] [int] NULL,
	[is_manager] [int] NULL,
	[manager_id] [int] NULL,
	[is_PSM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[resource_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Resources] ADD  DEFAULT (NULL) FOR [associate_app_id]
GO

ALTER TABLE [dbo].[Resources] ADD  DEFAULT ((1)) FOR [resource_status]
GO

ALTER TABLE [dbo].[Resources] ADD  DEFAULT ((1)) FOR [is_support_personnel]
GO

ALTER TABLE [dbo].[Resources]  WITH CHECK ADD FOREIGN KEY([manager_id])
REFERENCES [dbo].[Resources] ([resource_id])
GO


