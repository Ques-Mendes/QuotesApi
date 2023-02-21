﻿using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuotesApi.Data
{
    public class QuoteDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
    }
}