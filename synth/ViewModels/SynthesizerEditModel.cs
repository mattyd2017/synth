using synth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace synth.ViewModels
{
    public class SynthesizerEditModel
    {
        public string Name { get; set; }
        public SynthesizerType SynthType { get; set; }
    }
}
