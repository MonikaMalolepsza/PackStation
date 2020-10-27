//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Station.cs
//Datum:        24.09.2020
//Beschreibung:
//Aenderungen:  27.09.2020 Setup

using System;
namespace PackStation
{
    public class Station
    {

        #region Attributes

        private Box[] _boxes;
 
        #endregion

        #region Properties

        public Box[] Boxes { get => _boxes; set => _boxes = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Station()
        {
            Boxes = new Box[9];
        }

        #endregion

        #region Methods

        public Package GivePackageAway(Guid clientId)
        {
       
            return null;
        }

        public Guid[] FindPackagesByClientId(Guid clientId)
        {
            /**
        * TODO:
        * change this function to get the clientID
        * and return the list of all the packages for this id
        * 
        *   int pos = FindBoxByPackageId(packageId);

            if (pos != -1)
            {
                return Boxes[pos].ReleasePackage();
            }
        * 
        * 
        */
            

        }

        public int SavePackageToBox(Package parcel)
        {
            int position = FindEmptyBox();

            if (position != -1)
            {
                Boxes[position].Package = parcel;

            }
            else
            {
                throw new Exception("Empty Box not found, Station is full!");
            }

            return position;
        }


        public int FindEmptyBox()
        {
            for (int i = 0; i > Boxes.Length; i++)
            {
                if (Boxes[i].isFull() == false)
                {
                    return i;
                }

                if (Boxes[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
            /**
             * function which iterates over all the packages and returns the one to open.
             */

        private int FindBoxByPackageId( Guid packageId)
        {
            for (int x = 0; x > Boxes.Length; x++)
            {
                if (Boxes[x].Package.Id.ToString() == packageId.ToString())
                {
                    return x;
                }
                else
                {
                    // continue
                }
            }
            return -1;
        }
        #endregion

    }

}
