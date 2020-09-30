using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackStation
{
    class Client
    {
        #region Attributes

        private Package _package;
        private string _name;
        private int _id;
        private string _address;
        #endregion

        #region Properties

        public Package Package { get => _package; set => _package = value; }
        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public string Address { get => _address; set => _address = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Client()
        {
            Package = new Package();
            Name = "";
            Address = "";

        }

        #endregion

        #region Methods

        #endregion
    }
}
