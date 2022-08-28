#pragma once
#include <iostream>
#include <fstream>
#include <algorithm>
#include <list>
#include "Menu.h"
using namespace std;
class Country
{
	string name;
	vector<string> cities;
public:
	Country() {}
	Country(const string& name) : name{ name } {}
	Country(const Country& _Other)
	{
		this->name = _Other.name;
		this->cities.resize(_Other.cities.size());
		copy(_Other.cities.begin(), _Other.cities.end(), this->cities.begin());
	}
	Country& operator=(const Country& _Other)
	{
		if (&_Other == this)
		{
			return *this;
		}
		this->cities.clear();
		this->name = _Other.name;
		this->cities.resize(_Other.cities.size());
		copy(_Other.cities.begin(), _Other.cities.end(), this->cities.begin());
	}
	void addCity(const string& city)
	{
		cities.push_back(city);
	}
	void deleteCity(const string& city)
	{
		cities.erase(find(cities.begin(), cities.end(), city));
	}
	bool operator==(const Country& _Other) const
	{
		return this->name == _Other.name;
	}
	void print()
	{
		cout << "Name: " << name << endl;
		cout << "Cities: ";
		for_each(cities.begin(), cities.end(), [](string& s) {cout << s << ", "; });
		cout << endl;
	}
	string getName()const { return name; }
	void setName(const string& s) { name = s; }
	void printCities()
	{
		for_each(cities.begin(), cities.end(), [](string& s) {cout << s << ", "; });
		cout << endl;
	}
	void replace(const string& what, const string& with)
	{
		cities.emplace(find(cities.begin(),cities.end(),what), with);
	}
	bool contains(const string& city)const 
	{
		auto a = find(cities.begin(), cities.end(), city);
		if (a == cities.end())
		{
			return false;
		}
		return true;
	}
	size_t numberOfCities()const { return cities.size(); }
	void save(ofstream& out)
	{
		if (out.is_open())
		{
			out << "Country: " << name << endl;
			for_each(cities.begin(), cities.end(), [&out](string& s) {out << "City: " << s << endl; });
		}
	}
};

class App
{
vector<Country> countries;
public:
App(){}
App(const list<Country> _Other){}
void menu();
};

void App::menu()
{
	while (true)
	{
		system("cls");
		int c = Menu::select_vertical({ "View info about country","Change info about country","Add Country","Delete Country","Statictics","Show all","Read from file","Save to file","Exit" }, HorizontalAlignment::Center, 3);
		switch (c)
		{
		case 0:
			system("cls");
			{
				string temp;
				cout << "Countries: " << endl;
				cout << "------------------" << endl;
				for_each(countries.begin(), countries.end(), [](const Country& s) {cout << s.getName() << endl; });
				cout << "------------------" << endl;
				cout << "Name of the country: ";
				getline(cin, temp);
				auto a = find(countries.begin(), countries.end(), Country(temp));
				if (a == countries.end())
				{
					cout << "No matches" << endl;
					system("pause");
					continue;
				}
				system("cls");
				(*a).print();
			}
			system("pause");
			break;
		case 1:
			system("cls");
			{
				cout << "Countries: " << endl;
				cout << "------------------" << endl;
				for_each(countries.begin(), countries.end(), [](const Country& s) {cout << s.getName() << endl; });
				cout << "------------------" << endl;
				string temp;
				cout << "Name of the country: ";
				getline(cin, temp);
				auto a = find(countries.begin(), countries.end(), Country(temp));
				if (a == countries.end())
				{
					cout << "No matches" << endl;
					continue;
				}
				while (c < 4)
				{
					system("cls");
					c = Menu::select_vertical({"Change the name of the country","Change a name of a city","Add a city","Remove a city","Exit"}, HorizontalAlignment::Left);
					switch (c)
					{
						case 0:
							system("cls");
							cout << "The new name of the country: ";
							getline(cin, temp);
							(*a).setName(temp);
							break;
						case 1:
							while (true)
							{
								system("cls");
								cout << "Already has: ";
								(*a).printCities();
								cout << "City to change: ";
								getline(cin, temp);
								if (!((*a).contains(temp)))
								{
									cout << "Invalid name" << endl;
									continue;
								}
								{
									cout << "New name of the city: ";
									string newName;
									getline(cin, newName);
									(*a).replace(temp, newName);
									break;
								}
							}
							break;
						case 2:
							cout << "Already has: ";
							(*a).printCities();
							cout << "Name of the city: ";
							getline(cin, temp);
							(*a).addCity(temp);
							break;
						case 3:
							cout << "Already has: ";
							(*a).printCities();
							cout << "Name of the city: ";
							getline(cin, temp);
							(*a).deleteCity(temp);
							break;
						case 4:
							break;
					default:
						break;
					}
				}
			}
			break;
		case 2:
		{
			string temp;
			cout << "Name of the country: ";
			getline(cin, temp);
			countries.push_back(Country(temp));
		}
			break;
		case 3:
		{
			string temp;
			cout << "Name of the country: ";
			getline(cin, temp);
			auto a = find(countries.begin(), countries.end(), Country(temp));
			if (a == countries.end())
			{
				cout << "No matches" << endl;
				break;
			}
			countries.erase(a);
		}
			break;
		case 4:
		{
			{
				int c = 0;
				for_each(countries.begin(), countries.end(), [&c](Country& ctr) { c += ctr.numberOfCities(); });
				cout << "Cities total: " << c << endl;
			}

			cout << "Number of countries : " << countries.size() << endl;

			{
				Country max = countries.front();
				Country min = countries.front();
				for_each(countries.begin(), countries.end(), [*this,&max,&min](Country& s)
				{
					if ((max).numberOfCities() < s.numberOfCities())
					{
						max = s;
					}
					if ((min).numberOfCities() > s.numberOfCities())
					{
						min = s;
					}
				});
				cout << "City with the most of cities: " << endl;
				cout << max.getName() << " : " << max.numberOfCities() << endl;
				cout << "City with the least of cities: " << endl;
				cout << min.getName() << " : " << min.numberOfCities() << endl;
			}
		}
		system("pause");
			break;
		case 5:
			system("cls");
			for_each(countries.begin(), countries.end(), [](Country& ctr) {ctr.print(); });
			system("pause");
			break;
		case 6:
		{
			this->countries.clear();
			ifstream in("Countries.txt");
			string temp;
			while (getline(in,temp))
			{
				if (temp._Starts_with("Country: "))
				{
					temp.erase(temp.begin(), temp.begin() + 9);
					countries.push_back(Country(temp));
				}
				else if (temp._Starts_with("City: "))
				{
					temp.erase(temp.begin(), temp.begin()+6);
					countries.back().addCity(temp);
				}
			}
		}
			break;
		case 7:
		{
			ofstream out("Countries.txt");
			for_each(countries.begin(), countries.end(), [&out](Country& s) {s.save(out); });
			out.close();
		}
			break;
		case 8:
			system("cls");
			gotoxy(30, 15);
			cout << "Exiting..." << endl;
			gotoxy(20, 16);
			exit(0);
			break;
		default:
			break;
		}
	}
}
