//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Controller.cs
//Datum:        24.09.2020
//Beschreibung:
//Aenderungen:  27.09.2020 Setup


using System;
using System.CodeDom;
using System.Reflection.Emit;

namespace PackStation
{
    public class Controller
    {

        #region atributes

        private Station _station;
        private Client _client;

        #endregion

        #region properties

        public Station Station { get => _station; set => _station = value; }
        public Client Client { get => _client; set => _client = value; }

        #endregion

        #region constructors

        public Controller()
        {
            Station = new Station();
            Client = new Client();
        }

        #endregion

        #region methods

        public void Run()
        {

        }

        public void ClientSendsPackage()
        {
            Station.SavePackageToBox(Client.SendPackage());
        }

        public void ClientReceivesPackage()
        {
            Client.GetPackage(Station.GivePackageAway(packageId));
        }

        public void ClientReceivesOverview()
        {

        }

        #endregion
    }
}

