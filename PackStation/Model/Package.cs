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

        private string _description;
        private int _id;

        #endregion

        #region Properties
    
        public string Description { get => _description; set => _description = value; }
        public int Id { get => _id; set => _id = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Package()
        {
            Description = "";
            Id = new Random().Next(int.MinValue, int.MaxValue);
        }

        //Constructor that receives the actual values
        public Package(string description)
        {

                Description = description;
                Id = Id;
           
        }

        #endregion

        #region Methods


        #region Public

        // Public Methods


        #endregion


        #endregion



    }
}
