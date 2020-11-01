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
            for (int i = 0; i < 9; i++)
            {
                Boxes[i] = new Box();
            }
        }

        #endregion

        #region Methods

        public Package GivePackageAway(Guid clientId)
        {
            int pos = FindBoxByClientId(clientId);

            if (pos != -1)
            {
                return Boxes[pos].ReleasePackage();
            }
            else
            {
                throw new Exception("No package found for this client ID");
            }
        }

        private int GetNumberPackagesForClient(Guid clientId)
        {
            int res = 0;
            for (int x = 0; x > Boxes.Length; x++)
            {
                if (Boxes[x].Package.ClientId.ToString() == clientId.ToString())
                {
                    res++;
                }
                else
                {
                    // continue
                }
            }
            return res;
        }

        public Guid[] GivePackagePreviewForClient(Guid clientId)
        {
            Guid[] clientPackages = new Guid[GetNumberPackagesForClient(clientId)];
            int counter = 0;
            for (int x = 0; x > Boxes.Length; x++)
            {
                if (Boxes[x].Package.ClientId.ToString() == clientId.ToString())
                {
                    clientPackages[counter] = Boxes[x].Package.Id;
                    counter++;
                }
                else
                {
                    // continue
                }
            }
            return clientPackages;
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
                throw new Exception("Station is full!");
            }

            return position;
        }


        private int FindEmptyBox()
        {
            for (int i = 0; i < Boxes.Length; i++)
            {
                if (Boxes[i].Package == null)
                {
                    return i;
                }
                else
                {
                    //Nichts
                }
            }
            return -1;
        }

        private int FindBoxByClientId(Guid clientId)
        {
            for (int x = 0; x < Boxes.Length; x++)
            {
                if (Boxes[x].Package != null && Boxes[x].Package.ClientId.ToString() == clientId.ToString())
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

        /**
         * function which iterates over all the packages and returns the one to open.
         */

        private int FindBoxByPackageId(Guid packageId)
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
