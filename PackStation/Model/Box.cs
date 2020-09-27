//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Package.cs
//Datum:        24.09.2020
//Beschreibung:
//Aenderungen:  27.09.2020 Setup

using System;

namespace PackStation
{
    public class Box
    {
        #region Attributes

        private Package _package;

        #endregion

        #region Properties

        public Package Package { get => _package; set => _package = value; } 

        #endregion

        #region Constructors

        //Default Constructor
        public Box()
        {
            Package = new Package();
        }

        #endregion

        #region Methods

        #endregion



    }
}
