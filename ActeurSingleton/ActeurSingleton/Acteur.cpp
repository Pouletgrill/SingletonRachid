#include "Acteur.h"

int Acteur::cptAct = 0;

Acteur::Acteur()
{
   cptAct++;
}

Acteur::~Acteur()
{
   cptAct--;
}

int Acteur::nbrActeur()
{
   return cptAct;
}
