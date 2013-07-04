using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web;

namespace reportFavoritomatic.Models
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Users> Users { get; set; }
    }

    [Table("Users")]
    public class Users
    {
        [Key]
        public string domain_id { get; set; }
        public string user_name { get; set; }
        public bool is_supervisor { get; set; } 

    }
}