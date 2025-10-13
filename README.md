ADO.NET
Dapper
EFCore
- Model First
- Code First
- Database First

Homework
ADO.NET - Project - 1
Dapper - Project - 1
EFCore Database First - Project - 2 (ConsoleApp + Database)

Product (CRUD)
CREATE TABLE [dbo].[Tbl_Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[DeleteFlag] [bit] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


Sale (Create, Read)
SaleId
ProductId
Quantity
Price
DeleteFlag
CreatedDateTime

Validation (Quantity <, Quantity -)

dotnet ef dbcontext scaffold "Server=.;Database=Batch3MiniPOS;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o AppDbContextModels -c AppDbContext -f