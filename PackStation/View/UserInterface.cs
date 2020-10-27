//Autor:        Monika Malolepsza
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
            Text = " ";
        }

        #endregion

        #region methods
        // read text

        public string TextReader()
        {
            return Console.ReadLine();
        }
        // write text

        public void TextWriter()
        {
            Console.Write(Text);
        }

        //public
        static int ShowMenu(ref string[] menuPoints, string headline)
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

        public void Splashinfo()
        {
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

        #endregion


    }
}
