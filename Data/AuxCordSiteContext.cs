using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuxCordSite.Models;

namespace AuxCordSite.Data
{
    public class AuxCordSiteContext : DbContext
    {
        public AuxCordSiteContext (DbContextOptions<AuxCordSiteContext> options)
            : base(options)
        {
        }

        public DbSet<AuxCordSite.Models.Song> Song { get; set; } = default!;
    }
}
