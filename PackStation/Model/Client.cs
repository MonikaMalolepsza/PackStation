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
        private Package[] _packages;
        private string _name;
        private Guid _id;
        private string _address;
        #endregion

        #region Properties

        public Package Parcel { get => _parcel; set => _parcel = value; }
        public string Name { get => _name; set => _name = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Address { get => _address; set => _address = value; }

        #endregion

        #region Constructors

        //Default Constructor

        public Client()
        {
            Name = "";
            Id = Guid.NewGuid();
        }



        public Client(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Client(string name, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
            Parcel = new Package(this.Name, this.Address, this.Id);

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
