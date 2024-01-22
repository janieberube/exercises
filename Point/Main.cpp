// Programmeur: Janie Bérubé
// Date: 2023-10-08
// Bût: Devoir 2 - Classe Point

#include <iostream>

#include "Point.h"

using namespace std;

int main(void)
{
	Point origine;
	Point p1(23, 41);
	Point p2(3, 1);
	Point p3(9, 9);
	Point p4;
	Point p5(11, 23);
	Point p6(11, 23);

	//Getters 
	cout << "p1: ";
	p1.afficher();
	cout << endl << "getX(): " << p1.getX();
	cout << endl << "getY(): " << p1.getY();
	cout << endl << endl;

	cout << "origine: ";
	origine.afficher();
	cout << endl << "getX(): " << origine.getX();
	cout << endl << "getY(): " << origine.getY();
	cout << endl << endl;

	//Setters
	cout << "p4: ";
	p4.afficher();
	p4.setX(4);
	p4.setY(7);
	cout << endl << "setX( 4 )" << endl << "set( 7 )" << endl << "p4: ";
	p4.afficher();
	cout << endl << endl;

	cout << "p1: ";
	p1.afficher();
	p1.setX(-2);
	p1.setY(18);
	cout << endl << "setX( -2 )" << endl << "set( 18 )" << endl << "p4: ";
	p1.afficher();
	cout << endl << endl;

	//isEqual
	cout << "p2: ";
	p2.afficher();
	cout << endl << "p3: ";
	p3.afficher();
	cout << endl << "p2.isEqual( p3 ) : " << p2.isEqual(p3) << endl << endl;

	cout << "p6: ";
	p6.afficher();
	cout << endl << "p5: ";
	p5.afficher();
	cout << endl << "p6.isEqual( p5 ) : " << p6.isEqual(p5) << endl << endl;

	//move
	cout << "p3: ";
	p3.afficher();
	cout << endl << "p3.move( 6, 5 )";
	p3.move(6, 5);
	cout << endl << "p3: ";
	p3.afficher();
	cout << endl << "p2: ";
	p2.afficher();
	cout << endl << "p3.move( p2 ) : ";
	p3.move(p2);
	p3.afficher();
	cout << endl << endl;

	//distance
	cout << "p2: ";
	p2.afficher();
	cout << endl << "p5: ";
	p5.afficher();
	cout << endl << "p2.distance( p5 ): " << p2.distance(p5) << endl << endl;

	cout << "p4: ";
	p4.afficher();
	cout << endl << "p4.distance( 53, 18 ): " << p4.distance(53, 18) << endl << endl;

	cout << "origine: ";
	origine.afficher();
	cout << endl << "origine.distance( -53, -18 ): " << origine.distance(-53, -18) << endl << endl;

	return 0;
}


