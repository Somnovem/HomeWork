#pragma once
#include "Data.h"
#include <initializer_list>
#include <cassert>
#include <iostream>
using namespace std;

template<class T>
class BaseQueue
{
protected:
	Data<T>* first = nullptr;
	Data<T>* last = nullptr;
	size_t   size = 0;
public:
	BaseQueue(initializer_list<T> init);
	BaseQueue() {}
	virtual ~BaseQueue();
	BaseQueue(const BaseQueue& q);
	BaseQueue& operator=(const BaseQueue& q)
	{
		this->clear();
		Data<T>* temp = q.first;
		while (temp)
		{
			enqueue(temp->value);
			temp = temp->next;
		}
	}
	void dequeue();
	T peek() const;
	size_t length() const;
	bool isEmpty() const;
	void clear();
	void print() const;
	virtual void enqueue(const T& value);
};

template<class T>
void BaseQueue<T>::enqueue(const T& value)
{
	if (this->size == 0)
	{
		this->first = new Data<T>;
		this->last = this->first;
		this->first->value = value;
	}
	else
	{
		this->last->next = new Data<T>;
		this->last->next->value = value;
		this->last = this->last->next;
	}
	this->size++;
}

template<class T>
BaseQueue<T>::BaseQueue(initializer_list<T> init)
{
	for (const T& i : init)
	{
		enqueue(i);
	}
}

template<class T>
BaseQueue<T>::~BaseQueue()
{
	clear();
}

template<class T>
BaseQueue<T>::BaseQueue(const BaseQueue& q)
{
	Data<T>* temp = q.first;
	while (temp)
	{
		this->enqueue(temp->value);
		temp = temp->next;
	}
}

template<class T>
void BaseQueue<T>::dequeue()
{
	if (size > 0)
	{
		Data<T>* temp = first;
		first = first->next;
		delete temp;
		size--;
		last = (size == 0) ? nullptr : last;
	}
}

template<class T>
T BaseQueue<T>::peek() const
{
	assert(size > 0);
	return first->value;
}

template<class T>
size_t BaseQueue<T>::length() const
{
	return size;
}

template<class T>
bool BaseQueue<T>::isEmpty() const
{
	return first == nullptr;
}

template<class T>
void BaseQueue<T>::clear()
{
	Data<T>* temp = first;
	while (temp)
	{
		first = first->next;
		delete temp;
		temp = first;
	}
	last = nullptr;
	size = 0;
}

template<class T>
void BaseQueue<T>::print() const
{
	Data<T>* temp = first;
	while (temp)
	{
		cout << temp->value << " ";
		temp = temp->next;
	}
	cout << endl;
}

namespace queue {

	template<class T>
	class Queue : public BaseQueue<T>
	{
	public:
		Queue() {}
		Queue(initializer_list<T> list) : BaseQueue<T>(list) {}
		void ring();
	};

	template<class T>
	void Queue<T>::ring()
	{
		if (this->size > 1)
		{
			Data<T>* temp = this->first;
			this->first = this->first->next;
			this->last->next = temp;
			this->last = temp;
			this->last->next = nullptr;
		}
	}

}

namespace priorityQueue
{
	template<class T>
	class PriorityQueue : public BaseQueue<T>
	{
	public:
		PriorityQueue() {}
		virtual void enqueue(const T& value, PRIORITY pri = PRIORITY::LOW);
	};

	template<class T>
	void PriorityQueue<T>::enqueue(const T& value, PRIORITY pri)
	{
		Data<T>* temp = new Data<T>;
		temp->value = value;
		temp->pri = pri;

		if (this->size == 0)
		{
			this->last = this->first = temp;
			this->size++;
			return;
		}

		if (pri <= this->last->pri)
		{
			this->last->next = temp;
			this->last = temp;
		}
		else if (pri > this->first->pri)
		{
			temp->next = this->first;
			this->first = temp;
		}
		else
		{
			Data<T>* pos = this->first;
			while (pri <= pos->next->pri)
			{
				pos = pos->next;
			}
			temp->next = pos->next;
			pos->next = temp;
		}
		this->size++;
	}
}