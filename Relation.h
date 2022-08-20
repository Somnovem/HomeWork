#pragma once
#include <iostream>
#include "List.h"
using namespace std;
namespace Composition
{
	class Engine
	{
	public:
		void start() { cout << "Engine start" << endl; }
	};
	class Car
	{
		Engine* engine;
	public:
		Car() { engine = new Engine; }
		~Car() { delete engine; }
		void move() { engine->start(); cout << "Moving" << endl; }
	};
}
namespace Agregation
{
	class Engine
	{
	public:
		int power = 50;
		void start() { cout << "Engine start" << endl; }
	};

	class Car
	{
		Engine* engine;
	public:
		Car(Engine* en) { engine = en; }
		void move() { engine->start(); cout << "Moving" << endl; }
		Engine* get() { return engine; }
		void set(Engine* en) { engine = en; }
	};

	class STO
	{
		Engine* engine;
	public:
		void set(Engine* en) { engine = en; }
		void test() { engine->power = 100; }
		Engine* get() { return engine; }
	};
}

class Teacher;

class Student 
{
	string name;
	List<Teacher*> teachers;
	void addTeacher(Teacher* tc);
public:
	Student(string name) : name{ name } {}
	string getName() { return name; }
	friend ostream& operator<<(ostream& out, const Student* list);
	friend class Teacher;
};

class Teacher
{
	string name;
	List<Student*> students;
public:
	Teacher(string n) : name{ n } {}
	string getName() { return name; }
	friend ostream& operator<<(ostream& out, const Teacher* list);
	void addStudent(Student* s);
};

ostream& operator<<(ostream& out, const Teacher* list)
{
	out << list->name << endl;
	if (!list->students.isEmpty())
	{
		out << "Is teaching: " << endl;
		for (size_t i = 0; i < list->students.length(); i++)
		{
			out << list->students[i]->getName() << endl;
		}
	}
	else
	{
		out << "No students" << endl;
	}

	return out;
}

ostream& operator<<(ostream& out, const Student* list)
{
	out << list->name << endl;
	if (!list->teachers.isEmpty())
	{
		out << "Is taught by:" << endl;
		for (size_t i = 0; i < list->teachers.length(); i++)
		{
			out << list->teachers[i]->getName() << endl;
		}
	}
	else
	{
		out << "No teachers" << endl;
	}

	return out;
}

void Student::addTeacher(Teacher* tc)
{
	teachers.push_back(tc);
}

void Teacher::addStudent(Student* s)
{
	students.push_back(s);
	s->addTeacher(this);
}
