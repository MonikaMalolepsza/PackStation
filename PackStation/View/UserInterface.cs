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

        #endregion

        #region properties

        #endregion

        #region constructors

        public UserInterface()
        {
         
        }

        #endregion

        #region methods

        //public

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
