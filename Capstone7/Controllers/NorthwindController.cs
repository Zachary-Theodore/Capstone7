using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Capstone7.Models;
namespace Capstone7.Controllers
{
    public class NorthwindController : ApiController
    {
        //action to get a list of all products
       public List<Product> GetProducts()
        {
            //URL
            //http://localhost:pory/api/Northwind/GetProducts
            //create ORM
            northwindEntities ORM = new northwindEntities();
            //get the products from ORM
            List<Product> productList = ORM.Products.ToList();
            //return the list of products
            return productList;

        }

        //action to list products by productid
        [HttpGet]
        public Product GetProductById(int ID)
        {
            //URL
            //http:localhost:port/api/Northwind/GetProductById?ID=3
            //create ORM
            northwindEntities ORM = new northwindEntities();
            //filter products by ids and return
            return ORM.Products.Find(ID);

        }

        //public Product GetByMax()
        //{
        //    //URL
        //    //http:localhost:port/api/Northwind/GetByMax
        //    //create ORM
        //    northwindEntities ORM = new northwindEntities();

        //    //filter products by max price and return
        //    return ORM.Products.Where(x => x.UnitPrice.Max());
        //}
    }
}