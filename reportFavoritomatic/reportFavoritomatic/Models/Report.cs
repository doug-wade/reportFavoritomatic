using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web;

namespace reportFavoritomatic.Models
{
    public class ReportContext : DbContext
    {
        public ReportContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Reports> Reports { get; set; }
    }

    [Table("Reports")]
    public class Reports
    {
        [Key]
        public Guid report_id { get; set; }
        public string report_name { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime last_updated_date { get; set; }

    }
}