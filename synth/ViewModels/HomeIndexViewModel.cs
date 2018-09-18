using synth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace synth.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Synthesizer> Synthesizers { get; set; }
        public string CurrentMessage { get; set; }
    }
}
