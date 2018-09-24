using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using synth.Services;
using synth.Models;

namespace synth.Pages.Synthesizers
{
    public class EditModel : PageModel
    {
        private ISynthesizerData _synthesizerData;

        [BindProperty]
        public Synthesizer Synthesizer { get; set; }

        public EditModel(ISynthesizerData synthesizerData)
        {
            _synthesizerData = synthesizerData;
        }
        public IActionResult OnGet(int id)
        {
             Synthesizer = _synthesizerData.Get(id);
            if(Synthesizer == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _synthesizerData.Update(Synthesizer);
                return RedirectToAction("Details", "Home", new { id = Synthesizer.Id });
            }
            return Page();
        }
    }
}