using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Reminder_Tool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [BindProperty]
        public string UserInput { get; set; }

        public void OnPost()
        {
            // Code to execute when the form is submitted (HTTP POST)
            // Access UserInput property here
            string userInputValue = UserInput;

            // Your logic here...
        }
    }
}