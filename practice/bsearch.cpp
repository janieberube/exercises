/***********************************************************
*
*  Auteur : Janie Bérubé
*  Date :	2023-04-17
*
*  Description : Exercie bsearch (recherche binaire)
*
***********************************************************/

#include <iostream>
using namespace std;

/****************  Prototypes de fonctions ****************/
int compare(const void* num1, const void* num2);
/******************* Programme principal ******************/
int main(void)
{
	/*
	Prototype bsearch:
	void* bsearch (const void* key, const void* base, size_t num, size_t size, int (*compar)(const void*,const void*))
	*/

	// Déclarations/Initialisations
	const int NB_CELLS = 10;

	int tableau[NB_CELLS] = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};	// Recherche binaire nécessite des données triées

	int cible;

	int* adresse = NULL;
	

	// Affichage 
	cout << "****Affichage****" << endl;

	for (int i = 0; i < NB_CELLS; i++)
		cout << tableau[i] << " ";


	// Input nombre 
	cout << endl << "Nombre a rechercher" << endl;
	cin >> cible;


	// Recherche binaire
	adresse = (int*)bsearch(&cible, tableau, NB_CELLS, sizeof(tableau[0]), compare);

	
	if (adresse != NULL)
		cout << cible << " est a l'adresse " << adresse << " et son index est : " << adresse - tableau;	
	else
		cout << cible << " n'est pas dans le  tableau.";



	return 0;
}

/*******************  Autres fonctions *******************/
int compare(const void* num1, const void* num2) {
	int nb1 = *(int*)num1;
	int nb2 = *(int*)num2;

	return nb1 - nb2;

}