﻿//Autor:        Monika Malolepsza
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

        #endregion

        #region Properties
    
        public int Id { get => _id; set => _id = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Package()
        {
            Id = new Random().Next(int.MinValue, int.MaxValue);
        }

        #endregion

        #region Methods


        #region Public

        // Public Methods


        #endregion


        #endregion



    }
}
