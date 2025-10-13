using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnortalDotNetTrainingBatch3.ConsoleApp2
{
    public class ProductEFCoreService
    {
        //private readonly ModelFirstAppDbContext _db;

        public ProductEFCoreService()
        {
            //_db = new ModelFirstAppDbContext();
        }

        public void Read()
        {
            ModelFirstAppDbContext db = new ModelFirstAppDbContext();
            var lst = db.Products.Where(x => x.DeleteFlag == false).ToList();

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i].ProductName);
                Console.WriteLine(lst[i].ProductId);
            }
        }

        public void Create()
        {
            ModelFirstAppDbContext db = new ModelFirstAppDbContext();
            var item = new Tbl_Product()
            {
                ProductName = "test",
                Price = 10000,
                Quantity = 100,
                CreatedDateTime = DateTime.Now,
                DeleteFlag = false,
            };
            db.Products.Add(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }

        public void Update()
        {
            ModelFirstAppDbContext db = new ModelFirstAppDbContext();
            var item = db.Products.FirstOrDefault(x => x.ProductId == 9);
            //var item = db.Products.Where(x => x.ProductId == 9).FirstOrDefault();
            if (item is null)
            {
                return;
            }

            item.ProductName = "apple";
            item.ModifiedDateTime = DateTime.Now;
            int result = db.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }

        public void Delete()
        {
            ModelFirstAppDbContext db = new ModelFirstAppDbContext();
            var item = db.Products.FirstOrDefault(x => x.ProductId == 10);
            if (item is null)
            {
                return;
            }

            //db.Remove(item);
            item.DeleteFlag = true;
            item.ModifiedDateTime = DateTime.Now;
            int result = db.SaveChanges();
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);
        }
    }
}
