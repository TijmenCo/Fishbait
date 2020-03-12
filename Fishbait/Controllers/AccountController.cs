using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fishbait.Models;
using MySql.Data.MySqlClient;

namespace Fishbait.Controllers
{
    public class AccountController : Controller
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader dr;
        //Get the account
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "server=127.0.0.1;user=Tijmen;database=fishbait;password=Suckmycred123";
        }
        [HttpPost]
        public IActionResult Verify(User acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM users WHERE username='"+acc.Username+"' AND password='"+acc.Password+"'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("Succes");
            } 
            else
            {
                con.Close();
                return View("Failure");
            }
          
   
        }
    }
}