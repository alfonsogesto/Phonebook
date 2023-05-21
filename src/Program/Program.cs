using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact owner = new Contact("Juan Carlos");
            Phonebook phonebook = new Phonebook(owner);

            Contact receptor =  new Contact("Laura");
            phonebook.AddContact(receptor);

            
            
            
            // Enviar un WhatsApp a algunos contactos

            
        }
    }
}
