#pragma once
#include<cassert>
#include"Data.h"
#include <iostream>
using namespace std;
namespace Stack {
	template<class T, size_t maxSize>
	class Stack
	{
		Data<T>* first = nullptr;
		size_t size = 0;

	public:
		Stack() {}
		~Stack();
		Stack(const Stack& st);
		Stack& operator=(const Stack& st);
		void push(const T& value);
		T peek() const;
		void pop();
		int length() const;
		bool isEmpty() const;
		bool isFull() const;
		void clear();
		void print() const;
	};

	template<class T, size_t maxSize>
	inline Stack<T, maxSize>::~Stack()
	{
		this->clear();
	}

	template<class T, size_t maxSize>
	Stack<T, maxSize>::Stack(const Stack& st)
	{
		for (size_t i = 0; i < st.size; i++)
		{
			Data<T>* temp = st.first;
			for (size_t j = 0; j < st.size - 1 - i; j++)
			{
				temp = temp->next;
			}
			this->push(temp->value);
		}

	}

	template<class T, size_t maxSize>
	void Stack<T, maxSize>::push(const T& value)
	{
		if (size < maxSize)
		{
			if (size == 0)
			{
				first = new Data<T>;
				first->value = value;
			}
			else
			{
				Data<T>* temp = new Data<T>;
				temp->value = value;
				temp->next = first;
				first = temp;
			}
			size++;
		}
	}

	template<class T, size_t maxSize>
	T Stack<T, maxSize>::peek() const
	{
		assert(size > 0);
		return first->value;
	}

	template<class T, size_t maxSize>
	void Stack<T, maxSize>::pop()
	{
		if (size > 0)
		{
			Data<T>* temp = first;
			first = first->next;
			delete temp;
			size--;
		}
	}

	template<class T, size_t maxSize>
	int Stack<T, maxSize>::length() const
	{
		return size;
	}

	template<class T, size_t maxSize>
	inline bool Stack<T, maxSize>::isEmpty() const
	{
		return size == 0;
	}

	template<class T, size_t maxSize>
	bool Stack<T, maxSize>::isFull() const
	{
		return size == maxSize;
	}

	template<class T, size_t maxSize>
	void Stack<T, maxSize>::clear()
	{
		Data<T>* temp = first;
		while (first)
		{
			first = first->next;
			delete temp;
			temp = first;
		}
		size = 0;
	}

	template<class T, size_t maxSize>
	void Stack<T, maxSize>::print() const
	{
		Data<T>* temp = first;
		while (temp)
		{
			cout << temp->value << " ";
			temp = temp->next;
		}
		cout << endl;
	}
}