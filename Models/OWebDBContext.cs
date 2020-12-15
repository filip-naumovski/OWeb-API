using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OWEBAPI.Models
{
    public class OWebDBContext:DbContext
    {
        public OWebDBContext(DbContextOptions<OWebDBContext> options) : base(options)
        {

        }

        public DbSet<Comment> comments { get; set; }
        public DbSet<BlogPost> blogPosts { get; set; }
    }
}
