#pragma once
#include<string>
#include<stack>
#include <vector>
#include <algorithm>
using namespace std;


class Calc
{
	int getPriority(char op) const;
	int operation(int a, int b, char op) const;
public:

	int operator()(string data) const;
};

inline int Calc::getPriority(char op) const
{
	switch (op)
	{
	case '+': return 1;
	case '-': return 2;
	case '*': return 3;
	case '/': return 4;
	case '^': return 5;
	default: break;
	}
}

inline int Calc::operation(int a, int b, char op) const
{
	switch (op)
	{
	case '+': return a + b;
	case '-': return a - b;
	case '*': return a * b;
	case '/': return a / b;
	case '^': return pow(a, b);
	default: break;
	}
}

int Calc::operator()(string data) const
{
	stack<int> num;
	stack<char> oper;
	int i = 0;
	while (data[i])
	{
		if (isdigit(data[i]))
		{
			num.push(data[i] - 48);
		}
		else
		{
			if (oper.empty() || getPriority(data[i]) > getPriority(oper.top()))
			{
				oper.push(data[i]);
			}
			else
			{
				int b = num.top(); num.pop();
				int a = num.top(); num.pop();
				char op = oper.top(); oper.pop();
				num.push(operation(a, b, op));
				oper.push(data[i]);
			}
		}
		i++;
	}

	vector<int> numbers;
	for (size_t i = 0; i < num.size(); i++)
	{
		numbers.push_back(num._Get_container().at(i));
	}

	vector<char> operations;
	for (size_t i = 0; i < oper.size(); i++)
	{
		operations.push_back(oper._Get_container().at(i));
	}

	while (!operations.empty())
	{
		int a= numbers.front(); numbers.erase(numbers.begin());
		int b = numbers.front(); numbers.erase(numbers.begin());
		char op = operations.front(); operations.erase(operations.begin());
		numbers.insert(numbers.begin(), operation(a, b, op));
	}

	return numbers.front();
}
