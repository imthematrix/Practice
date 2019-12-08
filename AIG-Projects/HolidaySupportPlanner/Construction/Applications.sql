USE [HolidayPlannerDB]
GO

/****** Object:  Table [dbo].[Applications]    Script Date: 12/8/2019 10:16:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Applications](
	[gear_id] [int] NOT NULL,
	[application_name] [varchar](150) NULL,
	[asm_id] [int] NULL,
	[psm_id] [int] NULL,
	[bundle_name] [varchar](50) NULL,
	[supported_by] [varchar](10) NULL,
	[support_mode] [varchar](15) NULL,
	[support_team_id] [int] NULL,
	[support_nature] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[gear_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[application_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Applications] ADD  DEFAULT ('Global Claims NA') FOR [bundle_name]
GO

ALTER TABLE [dbo].[Applications] ADD  DEFAULT ('Onsite') FOR [supported_by]
GO

ALTER TABLE [dbo].[Applications] ADD  DEFAULT ('In-Office') FOR [support_mode]
GO

ALTER TABLE [dbo].[Applications]  WITH CHECK ADD FOREIGN KEY([asm_id])
REFERENCES [dbo].[Resources] ([resource_id])
GO

ALTER TABLE [dbo].[Applications]  WITH CHECK ADD FOREIGN KEY([psm_id])
REFERENCES [dbo].[Resources] ([resource_id])
GO

ALTER TABLE [dbo].[Applications]  WITH CHECK ADD FOREIGN KEY([support_team_id])
REFERENCES [dbo].[Support_Teams] ([team_id])
GO


