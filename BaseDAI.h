#pragma once
#include "BTree.h"
#include "List.h"
#include "Menu.h"
#include <fstream>
class Protocol
{
public:
	static int count;
	string license;
	string date;
	string numPP;
	string tag;
	int cash = 0;
	Protocol() {}
	friend ostream& operator<<(ostream& out, const Protocol* p);
	friend istream& operator>>(istream& in,Protocol* p);
	string getLicense() { return license; }
};


ostream& operator<<(ostream& out, const Protocol* p)
{
	out << "License: " << p->license << "\n" <<"Date: " << p->date << "\n" << "Violated: " << p->numPP << "\n" << "Additional info: " << p->tag << "\n" << "Must pay: " << p->cash << endl;
		out << "--------------------------------------------------------" << endl;
	return out;
}

istream& operator>>(istream& in, Protocol* p)
{
	cout << "License : "; getline(in, p->license);
	cout << "Date : "; getline(in, p->date);
	cout << "Number of PP : "; getline(in, p->numPP);
	cout << "Tag : "; getline(in, p->tag);
	cout << "Cash : "; in >> p->cash;
	in.ignore();
	return in;
}

class BaseDAI
{
	BTree<string, List<Protocol*>> base;
	void addProtocol();
	void printAll();
	void printLic(const string& lic);
	void printInRange(const string& bottom, const string& top);
	void load();
	void save();
public:
	void menu();
};

void BaseDAI::addProtocol()
{
	system("cls");
	cout << "Add protocol" << endl;
	cout << "-------------" << endl;
	Protocol* prot = new Protocol;
	cin >> prot;
	List<Protocol*>* list = base.getValue(prot->getLicense());
	if (!list)
	{
		List<Protocol*> newList;
		newList.push_back(prot);
		base.rpush(prot->getLicense(), newList);
	}
	else
	{
		list->push_back(prot);
	}
}

void BaseDAI::printAll()
{
	base.print();
}

void BaseDAI::printLic(const string& lic)
{
	system("cls");
	if (base.getValue(lic) != nullptr)
	{
		List<Protocol*> val = *(base.getValue(lic));
		val.print();
	}
	else
	{
		cout << "License plate not found" << endl;
	}
}

void BaseDAI::printInRange(const string& bottom, const string& top)
{
	system("cls");
	bool found = 0;
	base.getRoot()->printWithCheck(bottom, top,found);
}

void BaseDAI::menu()
{
	while (true)
	{
	system("cls");
	int c = Menu::select_vertical({ "Add protocol","Print All","Print by license","Print in range","Load from file","Save to file","Exit" }, HorizontalAlignment::Center);
	string temp1,temp2;
	switch (c)
	{
	case 0:
		addProtocol();
		break;
	case 1:
		printAll();
		system("pause");
		break;
	case 2:
		system("cls");
		cout << "What license plate you wanna search for: ";
		getline(cin,temp1);
		printLic(temp1);
		system("pause");
		break;
	case 3:	
		system("cls");
		cout << "Search from: ";
		getline(cin, temp1);
		cout << "Search to: ";
		getline(cin, temp2);
		printInRange(temp1, temp2);
		system("pause");
		break;
	case 4:
		load();
		break;
	case 5:
		save();
		break;
	case 6:
		exit(0);
	default:
		break;
	}
	}
}

void BaseDAI::save()
{
	string filename = "Output.txt";
	ofstream fileOut;
	fileOut.open(filename, ios::ate);
	if (fileOut.fail())
	{
		system("cls");
		cout << "Couldn't open the file" << endl;
		exit(404);
	}
	fileOut.close();
	base.getRoot()->save();
}

void BaseDAI::load()
{
	base.clear();
	string filename = "Output.txt";
	ifstream fileIn;
	fileIn.open(filename);
	List<Protocol*> tempL;
	while (!fileIn.eof())
	{
		Protocol* temp = new Protocol;
		tempL.clear();
		getline(fileIn, temp->license);
		getline(fileIn, temp->date);
		getline(fileIn, temp->numPP);
		getline(fileIn, temp->tag);
		string buff;
		getline(fileIn, buff);
		temp->cash = stoi(buff);
		tempL.push_back(temp);
		base.push(temp->license,tempL);
	}
	fileIn.close();
}
