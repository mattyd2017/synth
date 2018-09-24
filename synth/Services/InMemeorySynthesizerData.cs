using synth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using synth.Models;

namespace synth.Services
{
    //public class InMemeorySynthesizerData : ISynthesizerData
    //{
    //    List<Synthesizer> _synthesizer;
    //    public InMemeorySynthesizerData()
    //    {
    //        _synthesizer = new List<Synthesizer>
    //        {
    //            new Synthesizer{Id =1, Name = "MiniMoog"},
    //            new Synthesizer{Id =2, Name = "Waldorf Quantum"},
    //            new Synthesizer{Id =3, Name = "roland JD-XA"},
    //            new Synthesizer{Id =4, Name = "Acces Virus"},
    //        };
    //    }

    //    public Synthesizer Add(Synthesizer synthesizer)
    //    {
    //        synthesizer.Id = _synthesizer.Max(s => s.Id) + 1;
    //        _synthesizer.Add(synthesizer);
    //        return synthesizer;
    //    }

    //    public Synthesizer Get(int id)
    //    {
    //        return _synthesizer.FirstOrDefault(s => s.Id == id);
    //    }

    //    public IEnumerable<Synthesizer> GetAll()
    //    {
    //        return _synthesizer.OrderBy(s => s.Name);
    //    }
    //}
}
