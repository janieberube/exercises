/***********************************************************
*
*  Auteur : Janie Bérubé
*  Date :	  2023-05-24
*  Cours :  PROG1234
*
*  Description : Exercice Factorielle (recursion)
*
***********************************************************/

#include <iostream>

using namespace std;


int factorielle(int n);
/******************* Programme principal ******************/
int main(void)
{
  int nombre;
  int resultat;

  cout << "Entrez un nombre entier : " << endl;
  cin >> nombre;

  resultat = factorielle(nombre);

  cout << endl << endl << nombre << " factorielle est : " << resultat;

  return 0;
}
/**********************************************************/

int factorielle(int n) {

  if (n > 0)
    return n * factorielle(n-1);

  else {
    return 1;
  }
}
