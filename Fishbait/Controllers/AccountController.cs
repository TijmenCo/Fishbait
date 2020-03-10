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
            con.ConnectionString = "server=Localhost;user id=Tijmen;database=fishbait";
        }
        public IActionResult Verify(User acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from users where username='"+acc.Username+"' and password='"+acc.Password+"'";
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