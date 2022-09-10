#Banner
![Screenshot_1](https://user-images.githubusercontent.com/105933602/189497765-50ab6d43-b8ac-44dd-bf7c-c9de337d100d.png)
![Screenshot_9](https://user-images.githubusercontent.com/105933602/189497767-b479e272-17a7-4116-9584-cb4d1adbad94.png)
![Screenshot_8](https://user-images.githubusercontent.com/105933602/189497770-6617b82b-6f89-40af-b50a-d866368e9745.png)
#DataAll
![Screenshot_2](https://user-images.githubusercontent.com/105933602/189497952-c9a0922c-5de1-46f7-882e-0123adb27d56.png)
#Hover
![Screenshot_10](https://user-images.githubusercontent.com/105933602/189497863-d31610a1-dd82-4cbf-8849-876af8782509.png)
#Modal
![Screenshot_3](https://user-images.githubusercontent.com/105933602/189497877-da5d67b8-6c4c-4361-a525-9847875c5d24.png)
![Screenshot_4](https://user-images.githubusercontent.com/105933602/189497882-ea5ce976-0229-40fa-93d5-ce7f5e972aab.png)
#Responsive
![Screenshot_6](https://user-images.githubusercontent.com/105933602/189497929-19309741-9aa8-4bbe-9ec1-4bf5cb28b024.png)
![Screenshot_7](https://user-images.githubusercontent.com/105933602/189497933-e55b11a5-e825-4ee6-b8f6-1320e7437076.png)
#Database SQL Server
![Screenshot_5](https://user-images.githubusercontent.com/105933602/189497904-730c01cc-4477-4e79-a149-5bef66309167.png)
#Script SQL
................
USE [demo]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 11/9/2565 2:02:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NULL,
	[ProductDescription] [varchar](500) NULL,
	[ProductPrice] [varchar](10) NULL,
	[Img1] [text] NULL,
	[Img2] [text] NULL,
	[Img3] [text] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

...............
