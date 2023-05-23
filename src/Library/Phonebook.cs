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
        public PhoneBook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }
        public void AddContact(Contact contact)
        {
            this.persons.Add(contact);
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
            string[] to = {contactName};
            List<Contact> result = this.Search(to);
            Contact recipient = result[0];

            Message text = new Message(this.Owner, recipient);
            text.Text = message;

            channel.Send(text);
        }
    }
}
