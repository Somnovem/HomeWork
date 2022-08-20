#pragma once
#include <iostream>
#include <fstream>
using namespace std;
class Pet abstract
{
	string name;
	size_t age;
	string owner;
public:
	Pet(string s, size_t a, string o) : name{ s }, age{ a }, owner{o} {}
	string getName() { return name; }
	int getAge() { return age; }
	virtual string voice();
	virtual void print() = 0;

};

void Pet::print() {
	cout << "Name: " << name << endl;
	cout << "Age: " << age << endl;
	cout << "Owner: " << owner << endl;
}
string Pet::voice()
{
	return "No voice";
}
class Cat : public Pet
{
public:
	Cat(string s, size_t a,string o) : Pet(s,a,o){}
	virtual string voice() override final{ return "MEOW"; }
	virtual void print() override final { cout << "Animal: Cat" << endl; Pet::print(); cout << "Is a liquid" << endl; }
	void method() { cout << "Personal" << endl; }
};

class SiamCat : public Cat
{
public:
	SiamCat(string s, size_t a,string o) : Cat(s,a,o) {}
};



class Dog : public Pet
{
public:
	Dog(string s, size_t a,string o) : Pet(s,a,o){}
	virtual string voice() override { return "GAW"; }
	virtual void print() override { cout << "Animal: Dog" << endl; Pet::print(); cout << "The human's best friend" << endl; }
};

class Snail : public Pet
{
public:
	Snail(string n, size_t a,string o) : Pet(n,a,o){}
	virtual string voice() override { return Pet::voice(); }
	virtual void print() override { cout << "Animal: Snail" << endl; Pet::print(); cout << "Lives in its shell" << endl; }
};

class Parrot : public Pet
{
public:
	Parrot(string n, size_t a,string o) : Pet(n, a,o) {}
	void fly() { cout << "flies" << endl; }
	virtual string voice() override { return "*Whistle*"; }
	virtual void print() override { cout << "Animal: Parrot" << endl; Pet::print(); cout << "Can fly" << endl; }
};





class ILog
{
protected:
	string fname;
	ofstream fileOut;
public:
	ILog(string fname = " ") : fname{fname} {}
	virtual void open() = 0;
	virtual void close() = 0;
	virtual void write(string err) = 0;
	virtual ~ILog() {}
};

class FileLog : public ILog
{
public:
	FileLog(string fname) : ILog(fname) {}
	FileLog(const FileLog& fl) {}
	virtual void open() override
	{
		fileOut.open(fname);
	}
	virtual void close() override
	{
		fileOut.close();
	}
	virtual void write(string err) override
	{
		open();
		fileOut << err << endl;
		close();
	}
};

class ConsoleLog : public ILog
{
public:
	ConsoleLog(string fname) : ILog(fname) {}
	virtual void open() override
	{
		fileOut.open(fname);
	}
	virtual void close() override
	{
		fileOut.close();
	}
	virtual void write(string err) override
	{
		fileOut << err << endl;
	}
};