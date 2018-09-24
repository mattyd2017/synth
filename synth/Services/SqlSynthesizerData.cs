using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using synth.Data;
using synth.Models;

namespace synth.Services
{
    public class SqlSynthesizerData : ISynthesizerData
    {
        private SynthDbContext _context;

        public SqlSynthesizerData(SynthDbContext context)
        {
            _context = context;
        }
        public Synthesizer Add(Synthesizer synthesizer)
        {
            _context.Synthesizers.Add(synthesizer);
            _context.SaveChanges();
            return synthesizer;
        }

        public Synthesizer Get(int id)
        {
            return _context.Synthesizers.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Synthesizer> GetAll()
        {
           return  _context.Synthesizers.OrderBy(s => s.Name);
        }

        public Synthesizer Update(Synthesizer synthesizer)
        {
            _context.Attach(synthesizer).State = EntityState.Modified;
            _context.SaveChanges();
            return synthesizer;
        }
    }
}
