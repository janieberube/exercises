// Programmeur: Janie Bérubé
// Date: 2023-10-08
// Bût: Devoir 2 - Classe Point

#pragma once

#include <iostream>
#include <math.h> //
using namespace std;

class Point
{
private:
	//Déclaration de variables
	int x;
	int y;

public:
	//Constructeurs
	Point();
	Point(int, int);

	//Deconstructeur
	~Point();

	//Getters/Setters
	int getX() const; //
	int getY() const; //
	void setX(int);
	void setY(int);

	//Autres fonctions
	bool isEqual(const Point& point) const;
	void move(int, int);
	void move(const Point& point);
	void setLocation(int, int);
	void setLocation(const Point& point);
	bool isOrigin() const;
	void afficher() const;
	double distance(const Point& point) const;
	double distance(int, int) const;
};