using System;
using WhatsAppApiUCU;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook("Juan Carlos");

            Contact agusB = phoneBook.AddContact("AgusB");
            Contact agusK = phoneBook.AddContact("AgusK");
            Contact nacho = phoneBook.AddContact("Nacho");
            Contact alfoG = phoneBook.AddContact("AlfoG");
            Contact andyC = phoneBook.AddContact("AndyC");

            agusB.Phone = "+59898348813";
            agusB.TwitterID = "1042525944";

            agusK.Phone = "+59893350714";

            nacho.Phone = "+59897992196";
            nacho.TwitterID = "1257805315480997888";

            alfoG.Phone = "+59891400647";

            andyC.Phone = "+59891774460";         
            
            // Enviar un WhatsApp a algunos contactos
            
            WhatsAppMessage wsp = new WhatsAppMessage();
            TwitterDM tw = new TwitterDM();
            phoneBook.SendMessage("probandooo", "AgusB", tw);
        }
    }
}
