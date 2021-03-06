﻿//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        UserInterface.cs
//Datum:        24.08.2020
//Beschreibung:
//Aenderungen:  27.09.2020 Setup
//Aenderungen:  27.09.2020 splashinfo added

using System;
namespace PackStation
{
    public class UserInterface
    {
        #region atributes
        private string _text;
        #endregion

        #region properties
        public string Text { get => _text; set => _text = value; }
        #endregion

        #region constructors
        public UserInterface()
        {
            Splashinfo();
        }
        public UserInterface(string text)
        {
            Splashinfo();
            Text = text;
            print();
        }
        #endregion

        #region methods
        public void GivePackagePreviewForClient(int[] packageIds)
        {
            Console.Clear();
            Console.WriteLine($"There are {packageIds.Length} packages for you:");
            Console.WriteLine();
            Console.WriteLine("Nr        Package ID");

            for (int i = 0; i < packageIds.Length; i++)
            {
                Console.WriteLine($"({i + 1})       {packageIds[i]}");
            }

            Console.ReadKey(true);
        }

        public Client Register()
        {
            Client c = new Client(new Random().Next());
            Console.WriteLine("Enter your name: ");
            c.Name = Console.ReadLine();
            Console.WriteLine("Enter your adress: ");
            c.Address = Console.ReadLine();
            Console.WriteLine($"Finished, your clientid is: {c.Id}");
            return c;
        }

        public int EnterPackageId()
        {
            Console.Clear();
            Console.WriteLine("Please enter the id of your package:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int AuthenticateClient()
        {
            Console.Clear();
            Console.WriteLine("Please authenticate by entering your client Id");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int ShowMenu(string[] menuPoints, string headline)
        {
            int currentItem = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.Clear();
                Console.WriteLine(headline + "\n");

                for (int counter = 0; counter < menuPoints.Length; counter++)
                {
                    if (currentItem == counter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(menuPoints[counter]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(menuPoints[counter]);
                    }
                }

                Console.WriteLine("\n\nYou can navigate with the arrow keys.\nConfirm your entry with the return key.");
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    currentItem++;
                    if (currentItem > menuPoints.Length - 1) currentItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    currentItem--;
                    if (currentItem < 0) currentItem = menuPoints.Length - 1;
                }
            } while (key.Key.ToString() != "Enter");

            return currentItem;
        }

        public void Info(string text)
        {
           Console.Clear();
           Console.WriteLine(text);
        }

        public void Splashinfo()
        {
            Console.Clear();
            string[] titles = { "Project name:", "Version:", "Data:", "Author:", "Class:" };
            string[] information = { "Pack Station", "1.0", "24.09.2020", "Monika Malolepsza", "IA119" };
            Console.CursorTop = 5;
            for (int i = 0; i < information.Length; i++)
            {
                Console.CursorLeft = (Console.WindowWidth - 32) / 2;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0,-12}{1,20}", titles[i], information[i]);
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(400);
            }
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.WindowHeight - 2);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

        }

        public void print()
        {
            Console.WriteLine(Text);
            Console.ReadKey(true);
        }

        #endregion
    }
}
