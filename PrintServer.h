#pragma once
#include "Queue.h"
#include <string>
#include <iomanip>
using namespace std;
class TaskPrint
{
	string department;
	string fileName;
	int timePrint = -1;
public:
	TaskPrint(string dep, string file, int time) : department{ dep }, fileName{ file }, timePrint{time} {}
	TaskPrint() {}
	PRIORITY getPriority() const;
	friend ostream& operator<<(ostream& out, const TaskPrint& tp);
	int getTimePrint();
	void setTimePrint(int t);
};
class PrintServer
{
	string ip;
	priorityQueue::PriorityQueue<TaskPrint> qPrint;
	queue::Queue<TaskPrint> qLog;
	TaskPrint currentTaskPrint;
	int spentPrinting = 0;
public:
	PrintServer(string ip) : ip{ip} {}
	void addTaskPrint(const TaskPrint& tp);
	void work();
};
void PrintServer::addTaskPrint(const TaskPrint& tp)
{
	qPrint.enqueue(tp, tp.getPriority());
}
PRIORITY TaskPrint::getPriority() const
{
	if (department == "Admin") return PRIORITY::SUPERHIGH;
	if (department == "Economist") return PRIORITY::HIGH;
	if (department == "Transport") return PRIORITY::MEDIUM;
	if (department == "HR") return PRIORITY::LOW;
	return PRIORITY();
}
void PrintServer::work()
{
	static int time = 0;
	if (currentTaskPrint.getTimePrint() == 0)
	{
		currentTaskPrint.setTimePrint(time);
		qLog.enqueue(currentTaskPrint);
		currentTaskPrint.setTimePrint(-1);
	}
	if (currentTaskPrint.getTimePrint() != -1)
	{
		currentTaskPrint.setTimePrint(currentTaskPrint.getTimePrint() - 1);
	}
	system("cls");
	currentTaskPrint = qPrint.peek();
	cout << "PrintDServer: " << ip << endl;
	cout << "---------------------------" << endl;
	cout << "Printing: " << endl;
	cout << "-----------------------" << endl;
	if (currentTaskPrint.getTimePrint() != -1)
		cout << currentTaskPrint << endl;
	else
		cout << endl;
	cout << endl;
	cout << "Waiting: " << endl;
	cout << "-----------------------" << endl;
	qPrint.print();
	if (!qPrint.isEmpty() && currentTaskPrint.getTimePrint() == -1)
	{
		currentTaskPrint = qPrint.peek();
		time = currentTaskPrint.getTimePrint();
		spentPrinting += time;
		qPrint.dequeue();
	}
	cout << "Printed: " << endl;
	cout << "-----------------------" << endl;
	qLog.print();
	cout << "--------------------------------------------------------------" << endl;
	cout << "Documents printed: " << qLog.length() << endl;
	cout << "Time printing: " << spentPrinting << " s" << endl;
}
ostream& operator<<(ostream& out, const TaskPrint& tp)
{
	out << setw(10) << left <<tp.department << setw(10) << tp.fileName << setw(4) << tp.timePrint;
	return out;
}
int TaskPrint::getTimePrint()
{
	return timePrint;
}
 void TaskPrint::setTimePrint(int t)
{
	 timePrint = t;
}

