using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace langApi
{
    public class LangDbContext:DbContext
    {
        public LangDbContext(DbContextOptions<LangDbContext> options) : base(options) //1.language db context olusturduk database olustumall için
        {

        }
        public DbSet<Language> Languages { get; set; }
        //5.
    }
}
