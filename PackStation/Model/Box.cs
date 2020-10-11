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
        private int _numer;
        private bool _open;

        #endregion

        #region Properties

        public Package Package { get => _package; set => _package = value; }
        public int Numer { get => _numer; set => _numer = value; }
        public bool Open { get => _open; set => _open = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Box()
        {
            Package = null;
            Open = false; 
        }

        #endregion

        #region Methods

        public void OpenBox()
        {
            if (Open == false)
            {
                Open = true;
            }
            else
            {
                throw new Exception("Box is already open!");
            } 
        }

        public void CloseBox()
        {
            if (Open == true)
            {
                Open = false;
            }
            else
            {
                throw new Exception("Box is already closed!");
            }
        }

        public void SavePackage(Package package)
        {
            this.Package = package;

        }


        public Package ReleasePackage()
        {
            Package packageToRelease = this.Package;
            this.Package = null;
            return packageToRelease;
        }

        public bool isFull()
        {
            bool status;

            if (this.Package != null)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        #endregion

      
    }
}
