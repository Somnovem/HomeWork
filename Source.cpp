#include <iostream>
#include <queue>
#include "Student.h"
using namespace std;
template<class T>
class my_queue : public queue<T>
{
public:
	void print()
	{
		for (size_t i = 0; i < (this->c).size(); i++)
		{
			cout << (this->c)[i] << endl;
		}
	}

};
int main()
{
	my_queue<int> q;
	q.push(5);
	q.push(5);
	q.push(5);
	q.push(5);
	q.print();
	//std::set<Student> cont;
	//cont.insert(Student("Vasya", 20));
	//cont.insert(Student("Olga", 30));
	//auto it = cont.insert(Student("Alex", 25));
	//if (!it.second) cout << "Not added" << endl;
	//else
	//{
	//	cout << "Added" << endl;
	//	(*(it.first)).print();
	//}
	//auto it2 = cont.find(Student("Vasya", 201));
	//if (it2!=cont.end())
	//{
	//	(*it2).print();
	//}
	//auto lb = cont.lower_bound(Student("Olga", 30));
	//(*lb).print();
	//auto lb = cont.upper_bound(Student("Olga", 30));
	//(*lb).print();
	//for (auto i = lb; i != ub; i++)
	//{
	//	(*i).print();
	//}
	for (auto& s: cont)
	{
		s.print();
	}
	return 0;
}