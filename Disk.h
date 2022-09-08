#pragma once
#include<iostream>
#include <fstream>
#include <string>
using namespace std;
class Disk
{
	size_t size;
	size_t freeSize;
	string name;
	string data;
	bool is_Damaged;
public:
	Disk(string name, size_t size) : name{ name }, size{ size }
	{
		srand(time(NULL));
		is_Damaged = (rand() % 10 == 0);
		freeSize = size - 2;
	}
	Disk(string name, size_t size, string data) :  Disk(name, size) 
	{
		if (data.size() <= this->freeSize)
		{
			this->data = data;
			this->freeSize -= data.size();
		}
		else
		{
			this->data.assign(data.begin(), data.begin() + this->freeSize);
			this->freeSize *= 0;
		}
		
	}
	Disk(string name, size_t size, ifstream& in) : Disk(name, size)
	{
		if (in.is_open())
		{
			string holder;
			string temp;
			while (getline(in,temp))
			{
				holder+=temp;
			}
			if (holder.size() <= this->freeSize)
			{
				data.assign(holder);
				freeSize -= holder.size();
			}
			else
			{
				data.assign(holder.begin(), holder.begin() + this->size);
				freeSize *= 0;
			}
		}
	}
	size_t getSize() { return size; }
	size_t getFreeSize() { return freeSize; }
	string getName() { return name; }
	string getData() { return data; }
	bool getDamage() { return is_Damaged; }
	void setData(const string& s)
	{
			this->data = s;
			this->freeSize -= s.size();
	}
	void format() { data.clear(); this->freeSize = this->size  - 2; }
	void setName(const string& s) { name = s; }
};

class DVD
{
	Disk* disk;
	bool verify(const string& s)
	{
		return disk->getData() == s;
	}
	void diskState()
	{
		cout << "Name: " << disk->getName() << endl;
		cout << "Total size: " << disk->getSize() << " bit" << endl;
		cout << "Free size: " << disk->getFreeSize() << " bit" << endl;
		cout << "Contains: " << disk->getData() << endl;
		cout.setf(ios::boolalpha);
		cout << "Damaged : " << disk->getDamage() << endl;
		cout.unsetf(ios::boolalpha);
	}
public:
	DVD() { disk = nullptr; }
	string read()
	{
		if (disk)
			return disk->getData();
		else
			return "No disk";
	}
	void open(Disk* disk) { this->disk = disk; }
	bool write(const string& s)
	{
		if (disk == nullptr)
		{
			cout << "No disk" << endl;
			return false;
		}
		disk->format();
		if (s.size() > disk->getFreeSize() )
		{
			cout << "Not enough space" << endl;
			system("pause");
			return false;
		}
		if (disk->getDamage())
		{
			cout << "Disk is severely damaged" << endl;
			system("pause");
			return false;
		} 
		{
			srand(time(NULL));
			string buff(s);
			if (rand() % 100 == 0)
			{
				buff[rand() % s.size()] = '@';
			}
			disk->setData(buff);
		}
		if (!verify(s))
		{
			cout << "The written info differs from what was requested" << endl;
			system("pause");
			return false;
		}
		return true;
	}
	void getInfo()
	{
		if (disk)
		{
			diskState();
		}
	}
	void changeName(string s)
	{
		if (disk)
		{
			disk->setName(s);
		}
	}
};

