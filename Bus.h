#pragma once
#include <string>
#include "Queue.h"
#include <Windows.h>
using namespace queue;
using namespace priorityQueue;
namespace busStation
{
	class Human
	{
	public:
		string type;
		int haveBeenWaiting = 0;
		Human() {}
		Human(string type) : type{ type } {}
		void setType(string type) { this->type = type; }
		PRIORITY getPriority()
		{
			if (type == "Old lady" || type == "Doctor" || type == "Police Officer") return PRIORITY::SUPERHIGH;
			if (type == "Veteran" || type == "Teacher") return PRIORITY::HIGH;
			if (type == "Kid" || type == "Worker") return PRIORITY::MEDIUM;
			if (type == "Student" || type == "Unemployed" || type == "Somebody with an animal") return PRIORITY::LOW;
			return PRIORITY();
		}
		string getType() { return type; }
	};
	class Bus
	{
		int emptySits = -1;
	public:
		Bus()
		{
			emptySits = rand() % 20;
		}
		Bus(const Bus& temp)
		{
			emptySits = temp.emptySits;
		}
		int getSize() { return emptySits; }
		void setSize(int temp)
		{
			emptySits = temp;
		}
	};
	class Station
	{
		Queue<Bus> Route;
		PriorityQueue<Human> Station;
		void printStation(PriorityQueue<Human>& Station, int numberOfPeople)
		{
			PriorityQueue<Human> tempSt(Station);
			for (size_t i = 0; i < numberOfPeople; i++)
			{
				Human temp(tempSt.peek());
				tempSt.dequeue();
				cout << temp.getType() << endl;
			}
		}
	public:
		void work()
		{
			srand(time(NULL));
			string type[10] = { "Old lady","Veteran","Kid","Student","Worker","Teacher","Unemployed","Somebody with an animal","Doctor","Police Officer" };
			int avgTimeHuman = 0;
			int avgTimeBus = 0;
			int maxNumberOfPeople = 0;
			string name;
			Bus firstBus;
			Route.enqueue(firstBus);
			cout << "Name of the station: ";
			getline(cin, name);
			cout << "Average time before a new human arrives at the station(seconds are taken as minutes): ";
			cin >> avgTimeHuman;
			cout << "Average time before a bus arrives at the station(seconds are taken as minutes): ";
			cin >> avgTimeBus;
			cout << "Maximum number of people that can be on the station simultaneously(will be achieved through the prog): ";
			cin >> maxNumberOfPeople;
			cin.ignore();
			int i = 1;
			int currentlyWaiting = 0;
			int tooManyWaiting = 0;
			int nobodyWaiting = 0;
			int countdown = avgTimeBus;
			int original = avgTimeBus;
			double avgWaiting = 0.0;
			int sumWait = 0;
			Human temp;
			while (true)
			{
				system("cls");
				cout << "Name of the station: " << name << endl;
				cout << "---------------------------------" << endl;
				cout << "New person every: " << avgTimeHuman << " minutes" << endl;
				cout << "---------------------------------" << endl;
				cout << "Bus arrives every: " << avgTimeBus << " minutes" << endl;
				cout << "---------------------------------" << endl;
				cout << "Human waits " << avgWaiting << " minutes on average" << endl;
				cout << "---------------------------------" << endl;
				countdown--;
				Data<Human>* pos = Station.first;
				while (pos)
				{
					pos->value.haveBeenWaiting++;
					pos = pos->next;
				}
				if (countdown > 0)
				{
					cout << "Bus arrives in " << countdown << " minutes" << endl;
				}
				if (i % avgTimeHuman == 0)
				{
					temp.setType(type[rand() % 10]);
					Station.enqueue(temp, temp.getPriority());
					currentlyWaiting++;
				}
				if (i % avgTimeBus == 0)
				{
					countdown = avgTimeBus;
					cout << "   _____________" << endl;
					cout << " _/_|[][][][][] | - -" << endl;
					cout << "(      City Bus | - -" << endl;
					cout << "=--OO-------OO--- - -" << endl;
					if (currentlyWaiting >= (Route.peek()).getSize())
					{
						currentlyWaiting -= (Route.peek()).getSize();
						for (size_t i = 0; i < (Route.peek()).getSize(); i++)
						{
							sumWait += Station.peek().haveBeenWaiting;
							Station.dequeue();
						}
						avgWaiting = static_cast<double>(sumWait) / static_cast<double>((Route.peek()).getSize());
						(Route.peek()).setSize(0);
					}
					else
					{
						for (size_t i = 0; i < currentlyWaiting; i++)
						{
							sumWait += Station.peek().haveBeenWaiting;
							Station.dequeue();
						}
						(Route.peek()).setSize((Route.peek()).getSize() - currentlyWaiting);
						avgWaiting = static_cast<double>(sumWait) / static_cast<double>(currentlyWaiting);
						currentlyWaiting = 0;
						nobodyWaiting++;
					}
					sumWait = 0;
					if (currentlyWaiting >= maxNumberOfPeople)
					{
						tooManyWaiting++;
					}
					Route.ring();
				}
				if (tooManyWaiting == 3)
				{
					tooManyWaiting = 0;
					Bus newBus;
					Route.enqueue(newBus);
					avgTimeBus = original / Route.length();
					countdown = avgTimeBus;
				}
				if (nobodyWaiting == 3)
				{
					nobodyWaiting = 0;
					Route.dequeue();
					if (Route.length() > 1)
					{
						avgTimeBus = original / Route.length();
					}
					countdown = avgTimeBus;
				}
				cout << "---------------------------------" << endl;
				cout << "Currently waiting: " << endl;
				printStation(Station, currentlyWaiting);
				Sleep(1000);
				i++;
			}
		}
	};
}

