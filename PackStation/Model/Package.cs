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
        private int _weight;
        private string _size;
        private string _content;

        #endregion

        #region Properties

        public int Weight { get => _weight; set => _weight = value; }
        public Guid Id { get => _id; set => _id = value; }
        public Guid ClientId { get => _clientId; set => _clientId = value; }
        public string Size { get => _size; set => _size = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Package()
        {
            Id = Guid.NewGuid();
        }

        // Constructor
        public Package(string size, int weight, Guid client)
        {
            Id = Guid.NewGuid();
            ClientId = client;
            Size = size;
            Weight = weight;
        }
        //Package should always have an owner!
        public Package(Guid client)
        {
            Id = Guid.NewGuid();
            ClientId = client;
        }

        #endregion

        #region Methods

        private string ShowWeight()
        {
            return this.Size;
        }

        #endregion



    }
}
