using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_c_sharp
{
    class Acteur
    {
        //private string _nom = "";
        private static Acteur _instance;
        private static int nbActeur = 0;
        private static List<string> ActeursNames = new List<string>();
        // Note: Constructor is 'protected'
        protected Acteur()
        {
        }
        public static Acteur Instance()
        {
            if (_instance == null)
            {
                _instance = new Acteur();
                _instance.Read();
            }

            return _instance;
        }
        private void Read()
        {
            try
            {   // Open the text file using a stream reader.
                for (int j = 1; j < 4; j++)
                {

                    foreach (string line in File.ReadLines("..\\ListeActeur" + j + ".txt"))
                    {
                        if (!ActeursNames.Contains(line)) //Regarde si l'acteur existe deja dans la liste d'acteurs
                        {
                            Console.WriteLine(line);
                            nbActeur++;
                            ActeursNames.Add(line);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public void Write()
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter("..\\ActeurComplet.txt");

            for (int i = 0; i < ActeursNames.Count; i++)
            {
                tw.WriteLine(ActeursNames[i] + "\n");
            }
            // close the stream
            tw.Close();
        }
        public int GetNbActeur()
        {
            return nbActeur;
        }
    }
}
