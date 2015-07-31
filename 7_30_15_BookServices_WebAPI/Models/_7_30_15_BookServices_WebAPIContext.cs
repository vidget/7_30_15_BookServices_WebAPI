﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _7_30_15_BookServices_WebAPI.Models
{
    public class _7_30_15_BookServices_WebAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _7_30_15_BookServices_WebAPIContext() : base("name=_7_30_15_BookServices_WebAPIContext")
        {
        }

        public System.Data.Entity.DbSet<_7_30_15_BookServices_WebAPI.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<_7_30_15_BookServices_WebAPI.Models.Book> Books { get; set; }
    
    }
}
