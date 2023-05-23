using System;

namespace Library
{
    public class Message
    {
        public string Text { get; set; }
        public Contact From { get; }
        public Contact To { get; }
        public Message(Contact from, Contact to)
        {
            this.From = from;
            this.To = to;
        }
    }
}