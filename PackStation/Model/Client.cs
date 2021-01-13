//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Client.cs
//Datum:        24.09.2020
//Beschreibung:
//Aenderungen:  30.09.2020 Setup

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackStation
{
    public class Client
    {
        #region Attributes

        private Package _parcel;
        private string _name;
        private int _id;
        private string _address;
        #endregion

        #region Properties

        public Package Parcel { get => _parcel; set => _parcel = value; }
        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public string Address { get => _address; set => _address = value; }

        #endregion

        #region Constructors

        //Default Constructor

        public Client(int id)
        {
            Name = "";
            Id = id;
        }



        public Client(string name, int id)
        {
            Name = name;
            Id = Id;
        }

        public Client(string name, string address, int clientId)
        {
            Name = name;
            Address = address;
            Id = clientId;
        }

        #endregion

        #region Methods

        public Package SendPackage()
        {
            Package pack = Parcel;
            Parcel = null;
            return pack;
        }

        public void GetPackage(Package p)
        {
            if (Parcel != null)
            {
                throw new Exception($"Client already has a package: {Parcel.Id}!");
            }
            Parcel = p;
        }

        #endregion
    }
}
