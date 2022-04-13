namespace TuanBuy.Models.Line
{
    public class WebHookEventData
    {
        public string destination { get; set; }
        public Event[] events { get; set; }
    }

    public class Event
    {
        public string replyToken { get; set; }
        public string type { get; set; }
        public string mode { get; set; }
        public long timestamp { get; set; }
        public Source source { get; set; }
        public HookMessage message { get; set; }
    }
    //Line使用者端的資訊(userId)
    public class Source
    {
        public string type { get; set; }
        public string userId { get; set; }
    }
    //使用者訊息架構
    public class HookMessage
    {
        public string id { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public Emoji[] emojis { get; set; }
        public Mention mention { get; set; }
    }

    public class Mention
    {
        public Mentionee[] mentionees { get; set; }
    }

    public class Mentionee
    {
        public int index { get; set; }
        public int length { get; set; }
        public string userId { get; set; }
    }

    public class Emoji
    {
        public int index { get; set; }
        public int length { get; set; }
        public string productId { get; set; }
        public string emojiId { get; set; }
    }

}