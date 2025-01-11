using Microsoft.AspNetCore.Mvc;

namespace _04_partial
{
    public class MessagePage : ViewComponent
    {

        public MessagePage(){}

        public IViewComponentResult Invoke(Message message){
            HttpContext.Response.Headers.Append("Refresh", $"{message.secondWait};url={message.urlRedirect}");
            return View(message);
        }
    }
    
}