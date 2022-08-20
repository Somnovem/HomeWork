#pragma once
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
class Base
{
public:
	Base() {}
	virtual void display(const char* path)
	{
		ifstream fileIn;
		fileIn.open(path);
		if (fileIn.fail())
		{
			cout << "Couldn't open the file" << endl;
			exit(404);
		}
		string temp;
		while (!fileIn.eof())
		{
			getline(fileIn, temp);
			cout << temp << endl;
		}
	}
};

class ASCII_Base : public Base
{
public:
	ASCII_Base() {}
	virtual void display(const char* path)
	{
		ifstream fileIn;
		fileIn.open(path);
		if (fileIn.fail())
		{
			cout << "Couldn't open the file" << endl;
			exit(404);
		}
		string temp;
		while (!fileIn.eof())
		{
			getline(fileIn, temp);
			for (size_t i = 0; i < temp.length(); i++)
			{
				cout << static_cast<int>(temp[i]) << " ";
			}
			cout << endl;
		}
	}
};

class Binary_Base : public Base
{
public:
	Binary_Base() {}
	virtual void display(const char* path) 
	{
		ifstream fileIn;
		fileIn.open(path);
		if (fileIn.fail())
		{
			cout << "Couldn't open the file" << endl;
			exit(404);
		}
		string temp;

		while (!fileIn.eof())
		{
			getline(fileIn, temp);
			for (size_t i = 0; i < temp.size(); i++)
			{
				char buff[8]{};
				int m = 0;
				int modifier = 1;
				int num = static_cast<int>(temp[i]);
				while (modifier <= num)
				{
					modifier *= 2;
				}
				modifier /= 2;
				while (num > 0)
				{
					if (num >= modifier)
					{
						num -= modifier;
						buff[m] = '1';
					}
					else
					{
						buff[m] = '0';
					}
					m++;
					modifier /= 2;
				}
				if (modifier >= 1)
				{
					while (modifier != 0)
					{
						modifier /= 2;
						buff[m++] = '0';
					}
				}
				cout << buff << " ";
			}
			cout << endl;
		}
	}
};

