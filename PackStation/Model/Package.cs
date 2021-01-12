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

        private int _id;
        private int receiver;
        private int transmitter;
        private string _content;

        #endregion

        #region Properties

        public int Receiver { get => receiver; set => receiver = value; }
        public int Id { get => _id; set => _id = value; }
        public int Transmitter { get => transmitter; set => transmitter = value; }
        public string Content { get => _content; set => _content = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Package(int id)
        {
            Id = id;   
        }

        //Package should always have an owner!
        public Package(int receiver, int transmitter, int id)
        {
            Id = id;
            Transmitter = transmitter;
            Receiver = receiver;
        }


        #endregion

        #region Methods

        private string ShowTransmitter()
        {
            return this.Transmitter.ToString();
        }

        #endregion



    }
}
