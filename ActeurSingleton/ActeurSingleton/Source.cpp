#include <iostream>
#include <fstream>
#include <string>
#include "Acteur.h"

using namespace std;

int main()
{
   string line;
   Acteur *obj1, *obj2;
   for (int j = 1; j < 4; j++)
   {
      ifstream myfile("..\\ListeActeur" + to_string(j) + ".txt");

      if (myfile.is_open())
      {
         cout << "*********************************************************" << endl;
         for (int i = 0; getline(myfile, line); i++)
         {
            cout << line << '\n';
            obj1 = Acteur::getInstance();
            obj1->SetNom(line);
            cout << obj1->nbrActeur();
         }
         myfile.close();
      }
      else cout << "Unable to open file";
   }
}