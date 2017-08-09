namespace Twitter.Models
{
    using Interfaces;

    public class Tweet : IMessage
    {
        public Tweet(string messageContent)
        {
            this.Content = messageContent;
        }

        public string Content { get; private set; }
    }
}
