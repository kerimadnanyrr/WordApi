﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace langApi
{
    public class WordsDbContext:DbContext
    {
        public WordsDbContext(DbContextOptions<WordsDbContext> options) : base(options)
        {

        }
        public DbSet<Words> Words { get; set; }


    }

}
