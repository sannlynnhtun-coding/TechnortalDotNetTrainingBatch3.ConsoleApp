// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;
using TechnortalDotNetTrainingBatch3.ConsoleApp2;

Console.WriteLine("Hello, World!");

//ProductService productService = new ProductService();
//productService.Read(); // F11 | Fn + F11
//productService.Create(); 
//productService.Update(); 
//productService.Delete(); 

//ProductDapperService productDapperService = new ProductDapperService();
//productDapperService.Read(); // F11 | Fn + F11
//productDapperService.Create();
//productDapperService.Update();
//productDapperService.Delete();

ProductEFCoreService productEFCoreService = new ProductEFCoreService();
productEFCoreService.Read();
productEFCoreService.Create();
productEFCoreService.Update();
productEFCoreService.Delete();

// Fn + Esc

Console.ReadLine();

// CRUD