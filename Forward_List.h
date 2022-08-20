#include"Data.h"
#include<initializer_list>
#include<cassert>
#include <iostream>
using namespace std;

template<class T>
bool findInBuff(T arr[], T& value, size_t size)
{
	for (size_t i = 0; i < size; i++)
	{
		if (arr[i] == value)
		{
			return 1;
		}
	}
	return 0;
}

template<class T>
bool asc(T a, T b) { return a > b; };

template<class T>
bool desc(T a, T b) { return a < b; };

template<class T>
class Forward_List
{
	Data<T>* first = nullptr;
	Data<T>* last = nullptr;
	size_t   size = 0;
	void copy(const Forward_List<T>& list)
	{
		this->clear();
		Data<T>* pos = list.first;
		while (pos)
		{
			this->push_back(pos->value);
			pos = pos->next;
		}
	}
public:
	Forward_List() {}
	Forward_List(initializer_list<T> list);
	~Forward_List();
	Forward_List(const Forward_List<T>& list);
	Forward_List<T>& operator=(const Forward_List<T>& list);

	void push_back(const T& value);
	void push_front(const T& value);
	void insert(const T& value, size_t ind);

	void pop_back();
	void pop_front();
	void remove(size_t ind);

	T& front() const;
	T& back() const;
	T& at(size_t ind) const;

	T& operator[](size_t ind) const;

	Forward_List<T> operator+(const Forward_List<T>& list);
	void operator+=(const Forward_List<T>& list);
	Forward_List<T> operator*(Forward_List<T>& list);
	Forward_List<T> operator/(Forward_List<T>& list);

	bool operator==(const Forward_List<T>& list) const;
	bool operator!=(const Forward_List<T>& list) const;

	bool isEmpty() const;
	size_t length() const;
	void clear();
	void print() const;
	void sort(bool(*method)(T a, T b) = asc);
	void reverse();
	void splice(Forward_List<T>& other, size_t ind, size_t count);

	bool findValue(T& value);
	size_t findValueInd(T& value);
	size_t findValueInd(T& value,size_t ind);
};

template<class T>
Forward_List<T>::Forward_List(initializer_list<T> list)
{
	for (T l : list)
	{
		this->push_back(l);
	}
}

template<class T>
Forward_List<T>::~Forward_List()
{
	this->clear();
}

template<class T>
Forward_List<T>::Forward_List(const Forward_List<T>& list)
{
	this->copy(list);
}

template<class T>
Forward_List<T>& Forward_List<T>::operator=(const Forward_List<T>& list)
{
	Forward_List<T> temp(list);
	return temp;
}

template<class T>
void Forward_List<T>::push_back(const T& value)
{
	if (size == 0)
	{
		last = new Data<T>;
		last->value = value;
		first = last;
	}
	else
	{
		last->next = new Data<T>;
		last->next->value = value;
		last = last->next;
	}
	size++;
}

template<class T>
void Forward_List<T>::push_front(const T& value)
{
	if (size == 0)
	{
		first = new Data<T>;
		first->value = value;
		last = first;
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

template<class T>
void Forward_List<T>::insert(const T& value, size_t ind)
{
	assert(ind >= 0 && ind <= size);
	if (ind == 0)
	{
		this->push_front(value);
	}
	else if (ind == size)
	{
		this->push_back(value);
	}
	else
	{
		Data<T>* pos = first;
		for (size_t i = 0; i < ind - 1; i++)
		{
			pos = pos->next;
		}
		Data<T>* temp = new Data<T>;
		temp->value = value;
		temp->next = pos->next;
		pos->next = temp;
		size++;
	}
}

template<class T>
void Forward_List<T>::pop_back()
{
	assert(size > 0);
	Data<T>* pos = first;
	for (size_t i = 0; i < size - 2; i++)
	{
		pos = pos->next;
	}
	delete last;
	last = pos;
	size--;
	if (size == 0)
	{
		last = first = nullptr;
	}
	else
	{
		last->next = nullptr;
	}
}

template<class T>
void Forward_List<T>::pop_front()
{
	assert(size > 0);
	Data<T>* temp = first;
	first = first->next;
	delete temp;
	size--;
	if (size == 0)
	{
		last = nullptr;
	}
}

template<class T>
void Forward_List<T>::remove(size_t ind)
{
	assert(ind >= 0 && ind < size);
	if (ind == 0)
	{
		this->pop_front();
	}
	else if (ind == size - 1)
	{
		this->pop_back();
	}
	else
	{
		Data<T>* pos = first;
		for (size_t i = 0; i < ind - 1; i++)
		{
			pos = pos->next;
		}
		Data<T>* temp = pos->next;
		pos->next = pos->next->next;
		delete temp;
		size--;
	}
}

template<class T>
T& Forward_List<T>::front() const
{
	assert(size > 0);
	return first->value;
}

template<class T>
T& Forward_List<T>::back() const
{
	assert(size > 0);
	return last->value;
}

template<class T>
T& Forward_List<T>::at(size_t ind) const
{
	assert(ind >= 0 && ind < size);
	Data<T>* pos = first;
	for (size_t i = 0; i < ind; i++)
	{
		pos = pos->next;
	}
	return pos->value;
}

template<class T>
T& Forward_List<T>::operator[](size_t ind) const
{
	assert(ind >= 0 && ind < size);
	return this->at(ind);
}

template<class T>
Forward_List<T> Forward_List<T>::operator+(const Forward_List<T>& list)
{
	Forward_List<T> temp(*this);
	Data<T>* pos = list.first;
    while(pos)
	{
		temp.push_back(pos->value);
		pos = pos->next;
	}
	return temp;
}

template<class T>
void Forward_List<T>::operator+=(const Forward_List<T>& list)
{
	
	Data<T>* pos = list.first;
	while (pos)
	{
		this->push_back(pos->value);
		pos = pos->next;
	}
}

template<class T>
Forward_List<T> Forward_List<T>::operator*(Forward_List<T>& list)
{
	Forward_List<T> temp;
	T buff[256];
	Data<T>* pos = this->first;
	int current = 0;
	while (pos)
	{
		if (list.findValue(pos->value) && !findInBuff(buff,pos->value,current+1))
		{
			temp.push_back(pos->value);
			buff[current++] = pos->value;
		}
		pos = pos->next;
	}
	return temp;
}

template<class T>
Forward_List<T> Forward_List<T>::operator/(Forward_List<T>& list)
{
	Forward_List<T> temp;
	T buff[256];
	Data<T>* pos = this->first;
	Data<T>* secondPos = list.first;
	int current = 0;
	while (pos)
	{
		if (!list.findValue(pos->value) && !findInBuff(buff, pos->value, current + 1))
		{
			temp.push_back(pos->value);
			buff[current++] = pos->value;
		}
		pos = pos->next;
		secondPos = secondPos;
	}
	return temp;
}

template<class T>
bool Forward_List<T>::operator==(const Forward_List<T>& list) const
{
	if (this->size != list.size)
	{
		return 0;
	}
	Data<T>* pos = this->first;
	Data<T>* secondPos = list.first;
	while (pos)
	{
		if (pos->value != secondPos->value)
		{
			return 0;
		}
		pos = pos->next;
		secondPos = secondPos->next;
	}
	return 1;
}

template<class T>
bool Forward_List<T>::operator!=(const Forward_List<T>& list) const
{
	if (this->size != list.size)
	{
		return 1;
	}
	Data<T>* pos = this->first;
	Data<T>* secondPos = list.first;
	while (pos)
	{
		if (pos->value == secondPos->value)
		{
			return 0;
		}
		pos = pos->next;
		secondPos = secondPos->next;
	}
	return 1;
}


template<class T>
bool Forward_List<T>::findValue(T& value)
{
	 Data<T>* pos = this->first;
	 while (pos)
	 {
		 if (pos->value == value)
		 {
			 return 1;
		 }
		 pos = pos->next;
	 }
	 return 0;
}

template<class T>
size_t Forward_List<T>::findValueInd(T& value)
{
	Data<T>* pos = this->first;
	size_t ind = 0;
	while (pos)
	{
		if (pos->value == value)
		{
			return ind;
		}
		ind++;
		pos = pos->next;
	}
	return -1;
}

template<class T>
size_t Forward_List<T>::findValueInd(T& value, size_t ind)
{
	assert(ind >= 0 && ind < size);
	Data<T>* pos = first;
	size_t count = 0;
	while (ind >0 && pos)
	{
		pos = pos->next;
		ind--;
	}
	while (pos)
	{
		if (pos->value == value)
		{
			return count;
		}
		count++;
		pos = pos->next;
	}
	return -1;
}

template<class T>
bool Forward_List<T>::isEmpty() const
{
	return size == 0;
}

template<class T>
size_t Forward_List<T>::length() const
{
	return size;
}

template<class T>
void Forward_List<T>::clear()
{
	Data<T>* pos = first;
	while (pos)
	{
		first = first->next;
		delete pos;
		pos = first;
	}
	last = nullptr;
	size = 0;
}

template<class T>
void Forward_List<T>::print() const
{
	Data<T>* pos = first;
	while (pos)
	{
		cout << pos->value << " ";
		pos = pos->next;
	}
	cout << endl;
}

template<class T>
void Forward_List<T>::sort(bool(*method)(T a, T b))
{
	for (size_t i = 0; i < size-1; i++)
	{
		for (size_t j = 0; j < size-1-i; j++)
		{
			if (method(this->operator[](j),this->operator[](j+1)))
			{
				swap(this->operator[](j), this->operator[](j + 1));
			}
		}
	}
}

template<class T>
void Forward_List<T>::reverse()
{
	size_t lb = 0;
	size_t rb = size - 1;
	for (size_t i = 0; i < size/2; i++)
	{
		swap((this->operator[](lb)), (this->operator[](rb)));
		lb++;
		rb--;
	}
}

template<class T>
void Forward_List<T>::splice(Forward_List<T>& other, size_t ind, size_t count)
{
	if (ind >=0 && ind < other.size && ind + count <= other.size)
	{
		this->clear();
		Data<T>* lb = other.first;
		Data<T>* rb = other.first;
		Data<T>* cut = other.first;
		for (size_t i = 0; i < ind; i++)
		{
			lb = lb->next;
		}
		for (size_t i = 0; i < ind+count-1; i++)
		{
			rb = rb->next;
		}
		if (ind > 0)
		{
			for (size_t i = 0; i < ind - 1; i++)
			{
				cut = cut->next;
			}
		}
		if (ind == 0)
		{
			other.first = rb->next;
		}
		if (ind + count == other.size)
		{
			cut->next = nullptr;
		}
		else
		{
			cut->next = rb->next;
		}
		other.size -= count;
		this->first = lb;
		this->last = rb;
		this->size = count;
		rb->next = nullptr;
	}
}