namespace _04_partial
{
     public class Message(){
            public string Title { get; set; } = "Thông báo";
            public string Content { get; set; } = "Đang chuyển hướng...";

            public string urlRedirect { get; set; } = "/";

            public int secondWait { get; set; } = 3;
    }
}
