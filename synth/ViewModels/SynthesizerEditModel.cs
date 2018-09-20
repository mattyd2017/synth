using synth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace synth.ViewModels
{
    public class SynthesizerEditModel
    {
        [Required,MaxLength(500)]
        public string Name { get; set; }
        public SynthesizerType SynthType { get; set; }
    }
}
