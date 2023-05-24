using System;
using System.Collections.Generic;
using WhatsAppApiUCU;
using TwitterUCU;

namespace Library
{
    public class PhoneBook
    {
        public Contact Owner { get; }
        private List<Contact> persons;
        public PhoneBook(string name)
        {
            Contact owner = new Contact(name);
            this.Owner = owner;
            this.persons = new List<Contact>();
        }
        public Contact AddContact(string name)
        {
            // Aplicando el patron Creator, creo el nuevo objeto Contact dentro del metodo
            Contact contact = new Contact(name);
            this.persons.Add(contact);
            return contact;
        }
        public void RemoveContact(Contact contact)
        {
            this.persons.Remove(contact);
        }
        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }
            return result;
        }
        public void SendMessage(string message, string contactName, IMessageChannel channel)
        {
            // Defino destinatario
            string[] to = {contactName};
            List<Contact> result = this.Search(to);
            Contact recipient = result[0];

            // Defino el mensaje a ser enviado
            Message text = new Message(this.Owner, recipient);
            text.Text = message;

            // Envio el mensaje por el canal indicado
            channel.Send(text);
        }
    }
}
