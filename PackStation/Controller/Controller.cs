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
        private Client[] _clients;
        private UserInterface _UI;

        #endregion

        #region properties

        public Station Station { get => _station; set => _station = value; }
        public Client Client { get => _client; set => _client = value; }
        public UserInterface UI { get => _UI; set => _UI = value; }
        public Client[] Clients { get => _clients; set => _clients = value; }

        #endregion

        #region constructors

        public Controller()
        {
            Station = new Station();
            Client = new Client();
            Clients = new Client[3];
            Clients[0] = new Client("Jan", "Toronto");
            Clients[1] = new Client("Max", "Dublin");
            Clients[2] = new Client("Tom", "London");
            UI = new UserInterface();
        }

        #endregion

        #region methods

        public void run()
        {
            UI.Splashinfo();

            bool isActive = true;
            do
            {
                int selectedMainMenuPoint = UI.ShowMenu(new string[] { "Add new Client", "Provide Client Name", "Splashinfo", "Exit" }, "Main Menu");
                bool KundeIstAusgewaehlt = false;

                switch (selectedMainMenuPoint)
                {
                    case 0:
                        /**
                         * TODO: add new client feature here
                         * 
                         * dunno yet 
                         * 
                         *  UI.Text = UI.TextReader();
                         *  UI.TextWriter();
                         * 
                         */
                        break;
                    case 1:

                        UI.FindClientMenu();

                        Client activeClient = this.FindClient(UI.TextReader());

                        if (activeClient != null)
                        {
                            KundeIstAusgewaehlt = true;
                        }
                        else
                        {
                            //Fehlermeldung Kunde existiert nicht
                        }
                        do
                        {
                            int operation = UI.ShowMenu(new string[] { "Send parcel", "Receive parcel", "Display all my package IDs", "Back" }, "What would you like to do:");

                            switch (operation)
                            {
                                case 0:
                                    ClientSendsPackage(activeClient);
                                    break;
                                case 1:
                                    ClientReceivesPackage(activeClient);
                                    break;
                                case 2:
                                    ClientReceivesOverview(activeClient);
                                    break;
                                default:
                                    KundeIstAusgewaehlt = false;
                                    break;
                            }
                        } while (KundeIstAusgewaehlt);
                        break;
                    case 2:
                        UI.Splashinfo();
                        break;
                    case 3:
                        isActive = false;
                        break;
                    default:
                        break;
                }
            } while (isActive);
        }

        public void ClientSendsPackage(Client client)
        {
            Station.SavePackageToBox(client.SendPackage());
        }

        public void ClientReceivesPackage(Client client)
        {
            Client.GetPackage(Station.GivePackageAway(client.Id));
        }

        public void ClientReceivesOverview(Client client)
        {
            Guid[] packageIds = Station.GivePackagePreviewForClient(client.Id);
            UI.DisplayPackageInfo(packageIds);
        }

        public Client FindClient(string name)
        {
            for (int i = 0; i < Clients.Length; i++)
            {
                if (Clients[i].Name == name)
                {
                    return Clients[i];
                }
                else
                {
                    //continue;
                }
            }
            return null;
        }

        #endregion
    }
}

