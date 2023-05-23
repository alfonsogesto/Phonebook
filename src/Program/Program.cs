using System;
using WhatsAppApiUCU;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact owner = new Contact("Juan Carlos");
            PhoneBook phoneBook = new PhoneBook(owner);

            Contact agusB = new Contact("AgusB");
            Contact agusK = new Contact("AgusK");
            Contact nacho = new Contact("Nacho");
            Contact alfoG = new Contact("AlfoG");
            Contact andyC = new Contact("AndyC");

            agusB.Phone = "+59898348813";
            agusB.TwitterID = "1042525944";

            agusK.Phone = "+59893350714";

            nacho.Phone = "+59897992196";
            nacho.TwitterID = "1257805315480997888";

            alfoG.Phone = "+59891400647";

            andyC.Phone = "+59891774460";

            phoneBook.AddContact(agusB);
            phoneBook.AddContact(agusK);
            phoneBook.AddContact(nacho);
            phoneBook.AddContact(alfoG);
            phoneBook.AddContact(andyC);           
            
            // Enviar un WhatsApp a algunos contactos
            
            WhatsAppMessage wsp = new WhatsAppMessage();
            TwitterDM tw = new TwitterDM();
            phoneBook.SendMessage("probandooo", "AgusB", tw);
        }
    }
}
