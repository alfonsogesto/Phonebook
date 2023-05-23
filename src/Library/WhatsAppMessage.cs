using System;
using WhatsAppApiUCU;

namespace Library
{
    public class WhatsAppMessage : IMessageChannel
    {
        public void Send(Message message)
        {
            string cel = message.To.Phone;
            var whatsApp = new WhatsAppApi();
            Console.WriteLine(whatsApp.Send(cel, message.Text));
        }
    }
}