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
        private int _weight;
        private string _reciever;
        private string _sender;
        private string _size;
        private string _content;

        #endregion

        #region Properties

        public int Weight { get => _weight; set => _weight = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Reciever { get => _reciever; set => _reciever = value; }
        public string Sender { get => _sender; set => _sender = value; }
        public string Size { get => _size; set => _size = value; }
        public string Content { get => _content; set => _content = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Package()
        {
            Id = Guid.NewGuid();
        }

        // Constructor
        public Package(string content)
        {
            Id = Guid.NewGuid();
            Content = content;
        }

        #endregion

        #region Methods


        #endregion



    }
}
