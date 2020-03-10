using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishbait.Models
{
    public class Database
    {
        MySqlConnection con = new MySqlConnection("server=Localhost;user id=Tijmen;database=fishbait");
    }
}
