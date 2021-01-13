//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Controller.cs
//Datum:        24.09.2020
//Beschreibung:
//Aenderungen:  27.09.2020 Setup


using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PackStation
{
    public class Controller
    {

        #region atributes

        private Station _station;
        private List<Client> _clients;

        #endregion

        #region properties

        public Station Station { get => _station; set => _station = value; }
        public List<Client> Clients { get => _clients; set => _clients = value; }

        #endregion

        #region constructors

        public Controller()
        {
            Station = new Station();
            Clients = new List<Client>();
            Clients.Add(new Client("Peter", "Toronto", 1));
            Clients.Add(new Client("Max", "Dublin", 2));
            Clients.Add(new Client("Tom", "London", 3));
            Station.Boxes[1].Package = new Package(3, 2, 2);
            Station.Boxes[2].Package = new Package(3, 1, 3);
            Station.Boxes[3].Package = new Package(1, 2, 4);
        }

        #endregion

        #region methods

        public void run()
        {
            bool isActive = true;
            do
            {
                int selectedMainMenuPoint = Station.ShowMainMenu();
                switch (selectedMainMenuPoint)
                {
                    //Dropp off
                    case 0:
                        ClientSendsPackage();
                        break;
                    //pick up
                    case 1:
                        ClientReceivesPackage();
                        break;
                    //Preview
                    case 2:
                        ClientReceivesOverview();
                        break;
                    //Exit
                    case 3:
                        isActive = false;
                        break;
                    default:
                        break;
                }
            } while (isActive);
        }

        private void ClientSendsPackage()
        {
            int clientId = Station.AuthenticateClient();
            Client c = GetClientById(clientId);
            if (c == null)
            {
                c = Station.Register();
                Clients.Add(c);
            }

            try
            {
                Station.SavePackageToBox(c.SendPackage());
            }
            catch (Exception e)
            {
                Station.Terminal.Info(e.Message);

            }

        }

        private void ClientReceivesPackage()
        {
            int clientId = Station.AuthenticateClient();
            int clientPos = Clients.IndexOf(GetClientById(clientId));
            if (clientPos != -1)
            {
                try
                {
                    Clients[clientPos].GetPackage(Station.GivePackageAway(Station.EnterPackageId()));
                }
                catch(Exception e)
                {
                    Station.Terminal.Info(e.Message);
                }
            }
            else
            {
                Station.Terminal.Info("This client does not exists. Please double check the id.");
            }
        }

        private void ClientReceivesOverview()
        {
            int clientId = Station.AuthenticateClient();
            Client c = GetClientById(clientId);
            if (c != null)
            {
                Station.GivePackagePreviewForClient(clientId);
            }
            else
            {
                Station.Terminal.Info("Client not found");
            }
        }
        public Client GetClientById(int clientId)
        {
            foreach (Client c in Clients)
            {
                if (c.Id == clientId)
                    return c;
            }
            return null;
        }
        #endregion
    }
}

