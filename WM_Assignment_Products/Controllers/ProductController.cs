using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WM_Assignment_Products.Models;
using System.Data.Entity;

namespace WM_Assignment_Products.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult PrintProductsDB()
        {
            ProductContext productContext = new ProductContext();
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

        [HttpGet]
        public ActionResult InsertDB()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InsertJSON()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertDB(FormCollection formCollection)
        {
            try
            {
                Product product = new Product();
                product.Name = formCollection["Name"];
                product.Description = formCollection["Description"];
                product.Category = formCollection["Category"];
                product.Manufacturer = formCollection["Manufacturer"];
                product.Supplier = formCollection["Supplier"];
                product.Price = Convert.ToDecimal(formCollection["Price"]);

                ProductContext productContext = new ProductContext();
                productContext.Products.Add(product);
                productContext.SaveChanges();
                return RedirectToAction("PrintProductsDB");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult InsertJSON(FormCollection formCollection)
        {
            using (StreamReader sw = new StreamReader(@"D:\Users\Stefan\documents\visual studio 2015\Projects\WM_Assignment_Products/Product.json"))
            {
                string json = sw.ReadToEnd();
                ProductCollection productCollection = JsonConvert.DeserializeObject<ProductCollection>(json);
                List<Product> jsonlist = productCollection.products;
                jsonlist.Add(new Product
                {
                    ID = Convert.ToInt32(formCollection["Id"]),
                    Name = formCollection["Name"],
                    Description = formCollection["Description"],
                    Category = formCollection["Category"],
                    Manufacturer = formCollection["Manufacturer"],
                    Supplier = formCollection["Supplier"],
                    Price = Convert.ToDecimal(formCollection["Price"])
                });
                json = JsonConvert.SerializeObject(jsonlist);
                sw.Close();
                System.IO.File.WriteAllText(@"D:\Users\Stefan\documents\visual studio 2015\Projects\WM_Assignment_Products/Product.json", "{\"products\" : " + json + "}");
                return RedirectToAction("PrintProductsJSON");
            }
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            ProductContext productContext = new ProductContext();
            Product product = productContext.Products.SingleOrDefault(p => p.ID == Id);
            return View(product);
        }

        [HttpGet]
        public ActionResult EditJSON(int Id)
        {
            Product product = new Product();
            using (StreamReader sw = new StreamReader(@"D:\Users\Stefan\documents\visual studio 2015\Projects\WM_Assignment_Products/Product.json"))
            {
                string json = sw.ReadToEnd();
                ProductCollection productCollection = JsonConvert.DeserializeObject<ProductCollection>(json);
                List<Product> jsonlist = productCollection.products;
                product = jsonlist.SingleOrDefault(p => p.ID == Id);
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(int Id, FormCollection formCollection)
        {
            ProductContext productContext = new ProductContext();
            Product product = productContext.Products.SingleOrDefault(p => p.ID == Id);
            product.Name = formCollection["Name"];
            product.Description = formCollection["Description"];
            product.Category = formCollection["Category"];
            product.Manufacturer = formCollection["Manufacturer"];
            product.Supplier = formCollection["Supplier"];
            product.Price = Convert.ToDecimal(formCollection["Price"]);
            productContext.SaveChanges();
            return RedirectToAction("PrintProductsDB");
        }

        [HttpPost]
        public ActionResult EditJSON(int Id, FormCollection formCollection)
        {
            Product product = new Product();
            using (StreamReader sw = new StreamReader(@"D:\Users\Stefan\documents\visual studio 2015\Projects\WM_Assignment_Products/Product.json"))
            {
                string json = sw.ReadToEnd();
                ProductCollection productCollection = JsonConvert.DeserializeObject<ProductCollection>(json);
                List<Product> jsonlist = productCollection.products;
                product = jsonlist.SingleOrDefault(p => p.ID == Id);

                product.ID = Convert.ToInt32(formCollection["Id"]);
                product.Name = formCollection["Name"];
                product.Description = formCollection["Description"];
                product.Category = formCollection["Category"];
                product.Manufacturer = formCollection["Manufacturer"];
                product.Supplier = formCollection["Supplier"];
                product.Price = Convert.ToDecimal(formCollection["Price"]);

                json = JsonConvert.SerializeObject(jsonlist);
                sw.Close();
                System.IO.File.WriteAllText(@"D:\Users\Stefan\documents\visual studio 2015\Projects\WM_Assignment_Products/Product.json", "{\"products\" : " + json + "}");
                return RedirectToAction("PrintProductsJSON");
            }
        }
    }
}