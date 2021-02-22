using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TV_SHOW.Models;

namespace TV_SHOW.Data
{
    public class TV_SHOWContext : DbContext
    {
        public TV_SHOWContext (DbContextOptions<TV_SHOWContext> options)
            : base(options)
        {
        }

        public DbSet<TV_SHOW.Models.TVShow_TRP> TVShow_TRP { get; set; }
    }
}
