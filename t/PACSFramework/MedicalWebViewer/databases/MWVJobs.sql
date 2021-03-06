USE [ltjobs]
GO
/****** Object:  Table [dbo].[jobsQueue]    Script Date: 03/20/2012 09:33:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobsQueue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](100) NOT NULL,
	[object] [text] NOT NULL,
	[status] [int] NOT NULL,
	[completedstatus] [int] NOT NULL,
	[timestamp] [datetime] NULL,
	[error] [text] NULL,
	[userdata] [text] NULL,
	[retries] [int] NOT NULL,
	[owner] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_jobsQueue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
