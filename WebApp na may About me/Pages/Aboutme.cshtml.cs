using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_na_may_About_me.Pages
{
    public class AboutmeModel : PageModel
    {
        private readonly ILogger<AboutmeModel> _logger;

        public AboutmeModel(ILogger<AboutmeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["variable1"] = "Hi My Name is OMAR Q. SAINODIN. I live in Taguig City. I'm 21 years old. I studied in Technological University of the Philippines - Manila Campus. My hobbies is mostly playing sports, reading manhwa and manga, listening to music, and watching movies.";
        }
    }
}