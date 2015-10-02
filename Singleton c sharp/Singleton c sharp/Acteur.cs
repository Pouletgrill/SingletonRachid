using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_c_sharp
{
    class Acteur
    {
        private string _nom = "";
        private static Acteur _instance;
        private static int nbActeur = 0;
        // Note: Constructor is 'protected'
        protected Acteur()
        {
        }
        public static Acteur Instance()
        {
            if (_instance == null)
            {
                _instance = new Acteur();
            }
            nbActeur++;
            return _instance;
        }
        public void SetValue(string val)
        {
            _nom = val;
        }
        public string GetValue()
        {
            return _nom;
        }
        public int GetNbActeur()
        {
            return nbActeur;
        }
    }
}
