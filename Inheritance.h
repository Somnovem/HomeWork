#pragma once
#include <iostream>
using namespace std;
class Human
{
	string name;
	int age;
public:
	Human(string n = "", int a = 0) : name(n), age(a) 
	{
		cout << "Human" << endl;
	}
	string getName() { return name; }
	int getAge() { return age; }
	void print()
	{
		cout << "Name: " << name << endl;
		cout << "Age: " << age << endl;
	}
	void foo() {}
};

class FootballPlayer : public Human
{
	int games;
public:
	FootballPlayer(string n = "", int a = 0, int g = 0) : games{ g }, Human(n, a)
	{ 
		cout << "FP" << endl;
	}
	int getGanmesCount() { return games; }
	void print()
	{
		Human::print();
		cout << "Games: " << games << endl;
	}
	void foo() = delete;
};

class Forward : FootballPlayer
{
	int goals;
public:
	Forward(string n = "", int a = 0, int g = 0, int goals = 0) : FootballPlayer(n, a, g), goals{goals}
	{
		cout << "F" << endl;
	}
	void print()
	{
		FootballPlayer::print();
		cout << "Goals: " << goals << endl;
	}
};

class A 
{
	int privA;
public: 
	int publA;
protected:
	int protA;
	void ma() {}
};
class B : public A
{
	int privB;
public:
	int publB;
protected:
	int protB;
public:
	void foo() 
	{
		publA = 9;
		protA = 9;
		ma();
	}
};


class Adapter
{
public:
	int id;
	Adapter(int id) : id{ id } { cout << this->id << endl; }
};

class LANAdapter : virtual public Adapter
{
	int id;
public:
	LANAdapter(int id1, int id2) : id{ id1 }, Adapter(id2) {cout << this->id << endl; }
	int getId() { return id; }
};

class WIFIAdapter :virtual  public Adapter
{
	int id;
public:
	WIFIAdapter(int id1,int id2) : id{ id1 }, Adapter(id2) {cout << this->id << endl; }
	int getId() { return id; }
};

class Router : public WIFIAdapter, public LANAdapter
{
public:
	Router(int idW, int idL, int idA) : WIFIAdapter(idW, idA), LANAdapter(idL, idA),Adapter(idA) {}
};
