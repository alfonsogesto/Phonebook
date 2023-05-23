using System;
using TwitterUCU;

namespace Library
{
    public class TwitterDM : IMessageChannel
    {
        public void Send(Message message)
        {
            string TID = message.To.TwitterID;
            var twitterDM = new TwitterMessage();
            Console.WriteLine(twitterDM.SendMessage(message.Text, TID));
        }
    }
}