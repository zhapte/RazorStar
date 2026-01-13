

namespace RazorStar.Pages
{
    public class BindProcessDetailPageModel : PageModel
    {
        [BindProperty]
        public Process? MyProcess {get; set;}
        public void OnGet(int Id)
        {
            MyProcess = Process.GetProcessById(Id);
        }
    }
}
