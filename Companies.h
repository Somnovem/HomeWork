#pragma once
#include <iostream>
#include <string>
#include "BTree.h"
#include "List.h"
#include "Menu.h"
#include <experimental/filesystem>
#include <fstream>
using namespace std;
namespace fs = std::experimental::filesystem;

class Company
{
	string name;
	string owner;
	string phone;
	string adress;
public:
	Company() {};
	Company(string n, string o, string p, string a) :name{ n }, owner{ o }, phone{ p }, adress{a} {}
	Company(const Company& cmp)
	{
		this->name = cmp.name;
		this->owner = cmp.owner;
		this->phone = cmp.phone;
		this->adress = cmp.adress;
	}
	Company& operator=(const Company& cmp)
	{
		if (&cmp == this)
		{
			return *this;
		}
		this->name = cmp.name;
		this->owner = cmp.owner;
		this->phone = cmp.phone;
		this->adress = cmp.adress;
	}
	void print() const
	{
		cout << "Name : " << name << "\n";
		cout << "Owner : " << owner << "\n";
		cout << "Phone : " << phone << "\n";
		cout << "Adress : " << adress << "\n";
	}
	string getName()const noexcept{ return name; }
	string getOwner()const noexcept { return owner; }
	string getPhone()const noexcept { return phone; }
	string getAdress()const noexcept { return adress; }
	void save(ofstream& out)
	{
		out << name << endl << owner << endl << phone << endl << adress << endl;
	}
};

class Application
{
	BTree<string, Company> nameTree;
	BTree<string, Company> ownerTree;
	BTree<string, Company> phoneTree;
	BTree<string, Company> adressTree;
	void addCompany(Company comp)
	{
		string temp = comp.getName();
		nameTree.push(temp, comp);
		temp = comp.getOwner();
		ownerTree.push(temp, comp);
		temp = comp.getPhone();
		phoneTree.push(temp, comp);
		temp = comp.getAdress();
		adressTree.push(temp, comp);
	}
	void deleteCompany(int tree,string key)
	{
		Company temp;
		switch (tree)
		{
		case 0:
			if (nameTree.getValue(key))
			{
				temp = *(nameTree.getValue(key));
				nameTree.pop(key);
				ownerTree.pop(temp.getOwner());
				phoneTree.pop(temp.getPhone());
				adressTree.pop(temp.getAdress());
			}
			else
			{
				cout << "No matches" << endl;
			}
			break;
		case 1:
			temp = *(ownerTree.getValue(key));
			ownerTree.pop(key);
			nameTree.pop(temp.getName());
			phoneTree.pop(temp.getPhone());
			adressTree.pop(temp.getAdress());
			break;
		case 2:
			temp = *(phoneTree.getValue(key));
			phoneTree.pop(key);
			ownerTree.pop(temp.getOwner());
			nameTree.pop(temp.getName());
			adressTree.pop(temp.getAdress());
			break;
		case 3:
			temp = *(adressTree.getValue(key));
			adressTree.pop(key);
			ownerTree.pop(temp.getOwner());
			nameTree.pop(temp.getName());
			phoneTree.pop(temp.getPhone());
			break;
		}
	}
	void printAll()
	{
		nameTree.print("\n-----------\n");
		system("pause");
	}
	void search(int mode, string key)
	{
		system("cls");
		BTreeNode<string, Company>* found = nullptr;
		switch (mode)
		{
		case 0:
			found = nameTree.getNodeByKey(key);
			break;
		case 1:
			found = ownerTree.getNodeByKey(key);
			break;
		case 2:
			found = phoneTree.getNodeByKey(key);
			break;
		case 3:
			found = adressTree.getNodeByKey(key);
			break;
		}
		if (found == nullptr)
		{
			gotoxy(35, 10);
			cout << "No matches" << endl;
			gotoxy(35, 11);
			system("pause");
			return;
		}
		found->value.print();
		system("pause");
	}
public:
	Application() {}
	Application(const List<Company>& list)
	{
		for (size_t i = 0; i < list.length(); i++)
		{
			addCompany(list[i]);
		}
	}
	void menu()
	{
		while (true)
		{
			system("cls");	
			int c = Menu::select_vertical({"Add Company","Print all companies","Search","Delete company","Save to file","Load from file","Exit"}, HorizontalAlignment::Center);
			string name, phone, owner, adress,key;
			ofstream out;
			ifstream in;
			system("cls");
			switch (c)
			{
			case 0:
				cout << "Type in the name of the company: ";
				getline(cin, name);
				cout << "Type in the owner of the company: ";
				getline(cin, phone);
				cout << "Type in the phone of the company: ";
				getline(cin, owner);
				cout << "Type in the adress of the company: ";
				getline(cin, adress);
				this->addCompany(Company(name, owner, phone, adress));
				break;
			case 1:
				this->printAll();
				break;
			case 2:
				c = Menu::select_vertical({"Search by name","Search by owner","Search by phone","Search by adress","Exit"}, HorizontalAlignment::Center);
				if (c <4)
				{
					system("cls");
					cout << "Search for: ";
					getline(cin, key);
					search(c, key);
				}
				break;
			case 3:
				c = Menu::select_vertical({ "Delete by name","Delete by owner","Delete by phone","Delete by adress","Exit" }, HorizontalAlignment::Center);
				if (c < 4)
				{
					system("cls");
					cout << "Search for: ";
					getline(cin, key);
					deleteCompany(c, key);
				}
				break;
			case 4:
				out.open("Companies\\database.txt");
				if (!fs::exists("Companies"))
				{
					fs::create_directory("Companies");
				}
				nameTree.getRoot()->save(out);
				out.close();
				break;
			case 5:
				if (fs::exists("Companies"))
				{
					nameTree.clear();
					ownerTree.clear();
					phoneTree.clear();
					adressTree.clear();
					in.open("Companies\\database.txt");
					if (in.fail())
					{
						cout << "Couldn't open the file" << endl;
						exit(-1);
					}
					string name,owner,phone,adress;
					while (getline(in,name) && getline(in, owner) && getline(in, phone) && getline(in, adress))
					{
						Company temp(name, owner, phone, adress);
						nameTree.push(name,temp);
						ownerTree.push(owner, temp);
						phoneTree.push(phone, temp);
						adressTree.push(adress, temp);
					}
					in.close();
				}
				break;
			case 6:
				gotoxy(35, 10);
				cout << "Exiting..." << endl;
				exit(0);
			}
		}
	}
};
