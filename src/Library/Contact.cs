using System;

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