﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            Acteur s1 = Acteur.Instance();
            Acteur s2 = Acteur.Instance();
            //Acteur s3 = Acteur.Instance();
            //Acteur s4 = Acteur.Instance();
            //Acteur s5 = Acteur.Instance();
            //Acteur s6 = Acteur.Instance();
            Acteur s7 = Acteur.Instance();
            //Acteur s8 = Acteur.Instance();

            Console.WriteLine(s1.GetNbActeur());
            s7.Write();
            // Wait for user
            //Console.Read();
        }
    }
}
