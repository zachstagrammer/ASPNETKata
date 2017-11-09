using ASPNETKata.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

namespace ASPNETKata.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var list = conn.Query<Product>("SELECT * from Product");
                return View(list);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var product = conn.Query<Product>("SELECT * FROM Product WHERE ProductId = @id", new { Id = id }).FirstOrDefault();
                return View(product);
            }
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var name = collection["Name"];

            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    conn.Execute("INSERT INTO product (Name) VALUES (@Name)", new {Name = name});
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    Console.WriteLine("exception " + e);
                    return View();
                }
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var name = collection["Name"];

            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    conn.Execute("UPDATE Product SET Name = @Name WHERE ProductId = @Id", new { Name = name, Id = id });
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                    conn.Execute("DELETE FROM Product WHERE ProductId = @Id", new { Id = id });
                    return RedirectToAction("Index");
            }
        }
    }
}
