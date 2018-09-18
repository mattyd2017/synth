using synth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace synth.Services
{
    public interface ISynthesizerData
    {
        IEnumerable<Synthesizer> GetAll();
        Synthesizer Get(int id);
    }
}
