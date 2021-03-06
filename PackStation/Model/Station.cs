﻿//Autor:        Monika Malolepsza
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
        private UserInterface _terminal;

        #endregion

        #region Properties

        public Box[] Boxes { get => _boxes; set => _boxes = value; }
        public UserInterface Terminal { get => _terminal; set => _terminal = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Station()
        {
            Terminal = new UserInterface();
            Boxes = new Box[9];
            for (int i = 0; i < 9; i++)
            {
                Boxes[i] = new Box();
            }
        }

        public Station(Box[] boxes)
        {
            Terminal = new UserInterface();
            Boxes = boxes;
        }
        #endregion

        #region Methods       
        public Package GivePackageAway(int packageId)
        {
            int pos = FindBoxByPackageId(packageId);

            if (pos != -1)
            {
                Terminal.Text = "Package received!";
                Terminal.print();
                return Boxes[pos].ReleasePackage();
            }
            else
            {
                throw new Exception("No package found for this client ID");
            }
        }

        public void SavePackageToBox(Package parcel)
        {
            int position = FindEmptyBox();

            if (position != -1)
            {
                Boxes[position].OpenBox();
                Boxes[position].Package = parcel;
                Boxes[position].CloseBox();
                Terminal.Text = "Package dropped off!";
                Terminal.print();
            }
            else
            {
                throw new Exception("Station is full!");
            }
        }

        public int EnterPackageId()
        {
            return Terminal.EnterPackageId();
        }

        public void GivePackagePreviewForClient(int clientId)
        {
            int[] clientPackageIds = new int[GetNumberPackagesForClient(clientId)];
            int counter = 0;
            for (int x = 0; x < Boxes.Length; x++)
            {
                if (Boxes[x].Package != null && Boxes[x].Package.Receiver == clientId)
                {
                    clientPackageIds[counter] = Boxes[x].Package.Id;
                    counter++;
                }
                else
                {
                    // continue
                }
            }
            Terminal.GivePackagePreviewForClient(clientPackageIds);
        }

        public int AuthenticateClient()
        {
            return Terminal.AuthenticateClient();
        }

        public Client Register()
        {
            return Terminal.Register();
        }

        public int ShowMainMenu()
        {
            return Terminal.ShowMenu(new string[] { "Drop off package", "Pick up package", "Package preview", "Exit" }, "Please select a Menupoint:");
        }

        private int GetNumberPackagesForClient(int clientId)
        {
            int res = 0;
            for (int x = 0; x < Boxes.Length; x++)
            {
                if (Boxes[x].Package != null && Boxes[x].Package.Receiver == clientId)
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
                    // Empty
                }
            }
            return -1;
        }

        private int FindBoxByPackageId(int packageId)
        {
            for (int x = 0; x < Boxes.Length; x++)
            {
                if (Boxes[x].Package != null && Boxes[x].Package.Id == packageId)
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
