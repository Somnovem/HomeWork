#pragma once
#include<iostream>


using namespace std;


class Point
{
	char name;
	int x;
	int y;
	static int count;
public:

	Point() : Point('A',0, 0) {}
	Point(char n, int x, int y) :name{n}, x { x }, y{ y } { count++; }
	Point operator=(const Point& pt) 
	{
		*this = pt;
	}
	Point(const Point& pt) 
	{
		*this = pt;
		count++;
	}
	Point& operator=(Point&& p) = delete;
	Point (Point&& p) = delete;
	~Point()
	{
		count--;
	}
	static int getCount() { return count; }
	void print() const;
	void addVector(int x, int y)
	{
		this->x += x;
		this->y += y;
	}
	void operator()(char name,int x, int y)
	{
		this->name = name;
		this->x = x;
		this->y = y;
	}
};


int Point::count = 0;

void Point::print() const
{
	cout  << name << "( X = " << x << ", Y = " << y <<")" << endl;
}