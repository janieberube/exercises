// Programmeur: Janie Bérubé
// Date: 2023-10-08
// Bût: Devoir 2 - Classe Point

#include "Point.h"

Point::Point()
{
	this->x = 0;
	this->y = 0;
}

Point::Point(int pX, int pY)
{
	//this->x = pX;
	//this->y = pY;
	this->setX(pX); //Si de la validation est nécessaire
	this->setY(pY);	//Si de la validation est nécessaire
}

Point::~Point()
{
}

int Point::getX() const
{
	return this->x;
}

int Point::getY() const
{
	return this->y;
}

void Point::setX(int pX)
{
	this->x = pX;
}

void Point::setY(int pY)
{
	this->y = pY;
}

bool Point::isEqual(const Point& point) const
{
	if (this->x == this->y)
		return true;
	return false;

	//return (this->x == point.x && this->y == point.y);
}

void Point::move(int pX, int pY)
{
	this->x += pX;
	this->y += pY;
}

void Point::move(const Point& point)
{
	this->x += point.x;
	this->y += point.y;
}

void Point::setLocation(int pX, int pY)
{
	this->x = pX;
	this->y = pY;
}

void Point::setLocation(const Point& point)
{
	this->x = point.x;
	this->y = point.y;

	//this->setLocation(point.x, point.y);
}

bool Point::isOrigin() const
{
	if (this->x == 0 && this->y == 0)
		return true;
	return false;

	//return this->x == 0 && this->y == 0;
}

void Point::afficher() const
{
	cout << "( " << this->x << ", " << this->y << " )";
}

double Point::distance(const Point& point) const
{
	double resultat;
	resultat = sqrt(pow(this->x - point.x, 2.0) + pow(this->y - point.y, 2.0));
	return resultat;
}

double Point::distance(int pX, int pY) const
{
	double resultat;
	resultat = sqrt(pow(this->x - pX, 2.0) + pow(this->y - pY, 2.0));
	return resultat;
}
