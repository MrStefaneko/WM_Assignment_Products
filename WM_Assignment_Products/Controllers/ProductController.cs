using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WM_Assignment_Products.Models;

namespace WM_Assignment_Products.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult PrintProductsDB()
        {
            ProductContext productContext = new ProductContext();
            //Product products = productContext.Products.SingleOrDefault(pr => pr.ID == 15);
            List<Product> products = new List<Product>();
            products = productContext.Products.ToList();
            ViewBag.Products = products;
            return View();
        }

        public ActionResult PrintProductsJSON()
        {
            using (StreamReader sw = new StreamReader(@"D:\Users\Stefan\documents\visual studio 2015\Projects\WM_Assignment_Products/Product.json"))
            {
                string json = sw.ReadToEnd();
                ProductCollection productCollection = JsonConvert.DeserializeObject<ProductCollection>(json);
                ViewBag.Products = productCollection.products;
            }
            return View();
        }
    }
}