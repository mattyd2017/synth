using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace synth.Models
{
    public class Synthesizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SynthesizerType SynthType { get; set; }
    }
}
