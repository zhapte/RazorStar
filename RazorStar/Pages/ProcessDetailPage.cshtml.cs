

namespace RazorStar.Pages
{
    public class ProcessDetailPageModel : PageModel
    {
        public void OnGet(int Id)
        {
            var process = Process.GetProcessById(Id);
            ViewData["Proc"] = process;
        }
    }
}
