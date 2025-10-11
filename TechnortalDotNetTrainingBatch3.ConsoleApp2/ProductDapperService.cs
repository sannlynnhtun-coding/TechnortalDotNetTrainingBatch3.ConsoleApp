﻿using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnortalDotNetTrainingBatch3.ConsoleApp2
{
    public class ProductDapperService
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "Batch3MiniPOS",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

        public void Read()
        {
            using (IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();

                string query = @"SELECT [ProductId]
      ,[ProductName]
      ,[Quantity]
      ,[Price]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Product]";

                List<ProductDto> lst = db.Query<ProductDto>(query).ToList();
                for (int i = 0; i < lst.Count; i++)
                {
                    Console.WriteLine(lst[i].ProductName);
                    Console.WriteLine(lst[i].ProductId);
                }
            }
        }

        public void Create()
        {
            using (IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();

                string query = @"INSERT INTO [dbo].[Tbl_Product]
           ([ProductName]
           ,[Quantity]
           ,[Price]
           ,[DeleteFlag])
     VALUES
           ('Test'
           ,10
           ,10000
           ,0);";

                int result = db.Execute(query);
                string message = result > 0 ? "Saving Successful." : "Saving Failed.";
                Console.WriteLine(message);
            }
        }

        public void Update()
        {
            using (IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();

                string query = @"UPDATE [dbo].[Tbl_Product]
   SET [ProductName] = 'Test2'
      ,[Quantity] = 20
      ,[Price] = 2000
 WHERE ProductId = 12;";

                int result = db.Execute(query);
                string message = result > 0 ? "Updating Successful." : "Updating Failed.";
                Console.WriteLine(message);
            }
        }

        public void Delete()
        {
            using (IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();

                string query = @"Delete From Tbl_Product WHERE ProductId = 11;";
                
                int result = db.Execute(query);
                string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
                Console.WriteLine(message);
            }
        }
    }

    public class ProductDto // DTO = Data Transfer Object
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
