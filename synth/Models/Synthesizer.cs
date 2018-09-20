using synth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace synth.Models
{
    public class Synthesizer
    {
        public int Id { get; set; }

        [Display(Name ="Synthesizer Model")]
        [Required,MaxLength(500)]
        public string Name { get; set; }
        [Display(Name = "Type of synthesizer")]
        public SynthesizerType SynthType { get; set; }
    }
}
