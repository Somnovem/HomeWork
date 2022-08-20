#pragma once
#include <iostream>
#include <fstream>
#include "Functions.h"
using namespace std;

class Shape abstract
{
protected:
	int x;
	int y;
public:
	Shape() {}
	Shape(int x, int y) : x{ x }, y{ y } {}
	virtual ~Shape() {}
	virtual void show() const  = 0;
	virtual void load(ifstream& in) = 0;
	virtual void save(ofstream& out) const = 0;
};

class Square : public Shape
{
	int side;
public:
	Square() {}
	Square(int x, int y, int s) : Shape(x, y), side{ s }{}
	virtual void show() const override
	{
		cout << "Square in: ( " << x << " , " << y << " ), side - " << side << endl;
	}
	virtual void save(ofstream& out) const override
	{
		out << "Square" << endl;
		out << x << " "<< y << " " << side << endl;
	}
	virtual void load(ifstream& in) override
	{
		in >> x >> y >> side;
	}
};

class Circle : public Shape
{
	int radius;
public:
	Circle() {}
	Circle(int x, int y, int s) : Shape(x, y), radius{ s }{}
	virtual void show() const override
	{
		cout << "Circle in: ( " << x << " , " << y << " ), radius - " << radius << endl;
	}
	virtual void save(ofstream& out) const override
	{
		out << "Circle" << endl;
		out << x << " " << y << " " << radius << endl;
	}
	virtual void load(ifstream& in) override
	{
		in >> x >> y >> radius;
	}
};

class Rect : public Shape
{
	int width = 0;
	int length = 0;
public:
	Rect() {}
	Rect(int x, int y, int w, int l) : Shape(x, y), width{ w }, length{l}{}
	virtual void show() const override
	{
		cout << "Rectangle in: ( " << x << " , " << y << " ), short side - " << width << " , long side - " << length << endl;
	}
	virtual void save(ofstream& out) const override
	{
		out << "Rectangle" << endl;
		out << x << " " << y << " " << width << " " << length << endl;
	}
	virtual void load(ifstream& in) override
	{
		in >> x >> y >> width >> length;
	}
};

class Ellips : public Shape
{
	int width = 0;
	int length = 0;
public:
	Ellips() {}
	Ellips(int x, int y, int w, int l) : Shape(x, y), width{ w }, length{ l }{}
	virtual void show() const override
	{
		cout << "Ellipse in: ( " << x << " , " << y << " ), short side - " << width << " , long side - " << length << endl;
	}
	virtual void save(ofstream& out) const override
	{
		out << "Ellipse" << endl;
		out << x << " " << y << " " << width << " " << length << endl;
	}
	virtual void load(ifstream& in) override
	{
		in >> x >> y >> width >> length;
	}
};
Shape* getShapes()
{
	int n = rand() % 4;
	switch (n)
	{
	case 0:
		return new Square(rand() % 10, rand() % 10, rand() % 9+1);
		break;
	case 1:
		return new Rect(rand() % 10, rand() % 10, rand() % 9 + 1, rand() % 9 + 1);
		break;
	case 2:
		return new Circle(rand() % 10, rand() % 10, rand() % 9 + 1);
		break;
	case 3:
		return new Ellips(rand() % 10, rand() % 10, rand() % 9 + 1, rand() % 9 + 1);
		break;
	default:
		break;
	}
}
Shape* getShapes(string sh)
{
	if (sh == "Square") return new Square;
	if (sh == "Rect") return new Rect;
	if (sh == "Circle") return new Circle;
	if (sh == "Ellipse") return new Ellips;
}