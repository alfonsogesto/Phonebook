using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Nito.AsyncEx;

namespace Library
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string TwitterID { get; set; }
        public Contact(string name)
        {
            this.Name = name;
        }
    }
}