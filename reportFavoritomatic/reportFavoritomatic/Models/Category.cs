using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web;

namespace reportFavoritomatic.Models
{
    public class CategoryContext : DbContext
       
    {
        public CategoryContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Categories> Categories { get; set; }
    }

    [Table("Categories")]
    public class Categories
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CategoryCreationDate { get; set; }

    }
}