//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Package.cs
//Datum:        24.09.2020
//Beschreibung:
//Aenderungen:  27.09.2020 Setup

using System;

namespace PackStation
{
    public class Package
    {
        #region Attributes

        private Guid _id;
        private Guid _clientId;
        private string _address;
        private string _name;
        private string _content;

        #endregion

        #region Properties

        public string Address { get => _address; set => _address = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Content { get => _content; set => _content = value; }
        public Guid ClientId { get => _clientId; set => _clientId = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Package()
         {
             Id = Guid.NewGuid();
         }

        //Package should always have an owner!
        public Package(string name, string address, Guid client)
        {
            Id = Guid.NewGuid();
            ClientId = client;
            Name = name;
            Address = address;
        }
      

        #endregion

        #region Methods

        private string ShowSender()
        {
            return this.Name;
        }

        #endregion



    }
}
