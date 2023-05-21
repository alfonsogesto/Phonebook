using System.Collections.Generic;
using WhatsAppApiUCU;
using TwitterUCU;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

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

        public void AddContact(Contact contact)
        {
            this.persons.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            this.persons.Remove(contact);
        }

        public void SendMessage(string[] names,IMessageChannel channel, string text)
        {
            List<Contact> sendmessage = new List<Contact>();

            foreach(Contact contact in sendmessage)
            {
                Message message = channel.sendmessage(this.Owner, contact);
                message.Text = text;
                channel.Send(message);
            }
        }
    }
}
