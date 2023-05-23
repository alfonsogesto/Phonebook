using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Nito.AsyncEx;

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