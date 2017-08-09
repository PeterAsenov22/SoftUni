namespace Twitter
{
    using Twitter.Interfaces;
    using Twitter.Models;

    public class StartUp
    {
        public static void Main()
        {
            IMessage tweet = new Tweet("just test");
            IWriter console = new ConsoleWriter();
            IClient microwave = new MicrowaveOven(console);

            microwave.RetrieveMessage(tweet);
        }
    }
}
