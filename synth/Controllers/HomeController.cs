using Microsoft.AspNetCore.Mvc;
using synth.Services;
using synth.ViewModels;

namespace synth.Controllers
{
    public class HomeController:Controller
    {
        private ISynthesizerData _synthesizerData;
        private IGreeter _greeter;

        public HomeController(ISynthesizerData synthesizerData, IGreeter greeter)
        {
            _synthesizerData = synthesizerData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {

            var model = new HomeIndexViewModel();
            model.Synthesizers = _synthesizerData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }
        public IActionResult Details(int id)
        {
           var model =_synthesizerData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
