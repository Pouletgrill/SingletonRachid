#pragma once
#include <string>
#include <iostream>
using namespace std;

class Acteur
{
private:
   Acteur() : _nom("") { }
   ~Acteur(){}
public:
   static int nbrActeur();

   string GetNom();
   void SetNom(string nom);
   //à compléter …

   static Acteur *getInstance()
   {
      if (NULL == _singleton) {
         std::cout << "creating singleton." << std::endl;
         _singleton = new Acteur;
      }
      else
      {
         std::cout << "singleton already created!" << std::endl;
      }
      return _singleton;
   }
   static void kill()
   {
      if (NULL != _singleton)
      {
         delete _singleton; _singleton = NULL;
      }
   }

private:
   static int cptAct;
   static Acteur * _singleton;
   string _nom;
   //à compléter …
   
};

Acteur *Acteur::_singleton = NULL;