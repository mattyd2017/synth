using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using synth.Models;

namespace synth.Data
{
    public class SynthDbContext : DbContext
    {
        public SynthDbContext(DbContextOptions options) :base(options)
        {
            
        }
        public DbSet<Synthesizer> Synthesizers { get; set; }
    }
}
