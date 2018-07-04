using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.API.Models
{
    public class SocialContext:DbContext
    {
        public SocialContext(DbContextOptions<SocialContext> dbContext) : base(dbContext) { }

        public DbSet<Value> Values { get; set; }
    }
}
