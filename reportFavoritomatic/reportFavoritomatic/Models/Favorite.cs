using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web;

namespace reportFavoritomatic.Models
{
    public class FavoriteContext : DbContext
    {
        public FavoriteContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Favorites> Favorites { get; set; }
    
    }

    [Table("Favorites")]
    public class Favorites
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FavoriteId { get; set; }
        public string FavoriteName { get; set; }
        public Guid ReportId { get; set; }
        public string ReportPath { get; set; }
        public Guid UserId { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime NextReminderDate { get; set; }

    }
}