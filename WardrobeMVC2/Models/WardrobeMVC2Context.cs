using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WardrobeMVC2.Models
{
    public class WardrobeMVC2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WardrobeMVC2Context() : base("name=WardrobeMVC2Context")
        {
        }

        public System.Data.Entity.DbSet<WardrobeMVC2.Models.Accessory> Accessories { get; set; }

        public System.Data.Entity.DbSet<WardrobeMVC2.Models.Bottom> Bottoms { get; set; }

        public System.Data.Entity.DbSet<WardrobeMVC2.Models.Shoe> Shoes { get; set; }

        public System.Data.Entity.DbSet<WardrobeMVC2.Models.Top> Tops { get; set; }
    }
}
