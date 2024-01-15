using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u=>u.Id == obj.Id); 
            if(objFromDb != null)
            {
                objFromDb.Title= obj.Title;
                objFromDb.ISBN= obj.ISBN;
                objFromDb.Price= obj.Price;
                objFromDb.Description= obj.Description;
                objFromDb.Price50= obj.Price50;
                objFromDb.ListPrice= obj.ListPrice;
                objFromDb.Price100= obj.Price100;
                objFromDb.CategoryId= obj.CategoryId;
                objFromDb.Author= obj.Author;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl= obj.ImageUrl;   
                }
            }
        }
    }
}
