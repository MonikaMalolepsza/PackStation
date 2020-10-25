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
        private PackageLabel _packageLabel;
        private string _name;
        private Guid _id;
        private string _address;
        #endregion

        #region Properties

        public Package Parcel { get => _parcel; set => _parcel = value; }
        public string Name { get => _name; set => _name = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Address { get => _address; set => _address = value; }
        public PackageLabel PackageLabel { get => _packageLabel; set => _packageLabel = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Client()
        {
            Id = Guid.NewGuid();
            Parcel = new Package(Id);
        }

        public Client(string name, string address)
        {
            Id = Guid.NewGuid();
            Parcel = new Package(Id);
            Name = name;
            Address = address;
        }

        public Client(string name, string address, Package package)
        {
            Parcel = package;
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
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
