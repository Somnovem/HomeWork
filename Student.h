#pragma once
#include<iostream>
#include <fstream>
#include "Functions.h"

using namespace std;

class Student
{

	char* name = nullptr;
	int age = 0;
	int* mark = nullptr;
	int sizeMark = 0;

public:
	Student() : Student("No name", 0) { }

	Student(const char* n, int a)
	{
		this->init(n, a);
	}

	~Student()
	{
		delete this->name;
		delete[] this->mark;
	}

	void init(const char* n, int a)
	{
		setName(n);
		setAge(a);
	}

	void save(ofstream& out)
	{
		out.write((char*)this, sizeof(Student));
		int len = strlen(this->name);
		out.write((char*)&len, sizeof(int));
		out.write((char*)this->name, len);
		for (size_t i = 0; i < sizeMark; i++)
		{
			out.write((char*)mark[i], sizeof(int));
		}
	}

	void load(ifstream& in)
	{
		in.read((char*)this, sizeof(Student));
		int len;
		in.read((char*)&len, sizeof(int));
		char buff[80];
		in.read((char*)buff, len);
		buff[len] = '\0';
		setName(buff);
		mark = new int[sizeMark];
		for (size_t i = 0; i < sizeMark; i++)
		{
			in.read((char*)&mark[i], sizeof(int));
		}
	}

	void addMark(int m)
	{
		if (m < 1 || m > 12)
			return;
		addElemArray(mark, sizeMark, m);
	}

	void setAge(int a)
	{
		if (a > 100 || a < 0)
		{
			age = 0;
			return;
		}
		age = a;
	}

	int getAge() const
	{
		return age;
	}

	void setName(const char* n)
	{
		int len = strlen(n) + 1;
		name = new char[len];
		strcpy_s(name, len, n);
	}

	char* getName() const
	{
		return name;
	}

	void print() const;

};


void Student::print() const
{
	cout << "Name: " << this->name << ", Age: " << this->age << ", Mark: ";
	printArray(mark, sizeMark);
}

class FFF
{
	string n;
	int a;
public:
	FFF(string n, int a) : n{ n }, a{ a }{}
};