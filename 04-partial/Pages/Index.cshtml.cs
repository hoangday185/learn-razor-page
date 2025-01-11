using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _04_partial;

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

    public IActionResult OnPost(){
        return ViewComponent("MessagePage", new Message(){
            Title = "Thông báo",
            Content = "Cảm ơn bạn đã gửi thông tin",
            urlRedirect = "/",
            secondWait = 3
        });
    }
}