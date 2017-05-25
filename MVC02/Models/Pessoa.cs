using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC02.Models
{
    public class Pessoa
    {
        [Key]
        public long id { get; set; }
        public string nome { get; set; }
    }

    public class PContexto : DbContext
    {
        public PContexto()
            : base()
        {

        }

        public DbSet<Pessoa> pessoas { get; set; }
    }
}