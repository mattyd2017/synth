using synth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using synth.Models;

namespace synth.Services
{
    public interface ISynthesizerData
    {
        IEnumerable<Synthesizer> GetAll();
        Synthesizer Get(int id);
        Synthesizer Add(Synthesizer synthesizer);
        Synthesizer Update(Synthesizer synthesizer);
    }
}
