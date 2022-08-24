#pragma once
#include <iostream>
#include "MyException.h"
using namespace std;

template<class T>
class SmartPointer
{
	T* ptr;
public:
	SmartPointer(T* ptr = nullptr) : ptr{ptr} {}

	SmartPointer(const SmartPointer& ptr) { this->ptr = new T; ptr = *ptr.ptr; }
	SmartPointer(SmartPointer&& ptr) { this->ptr = ptr.ptr; ptr.ptr = nullptr; cout << "CM" << endl; }

	SmartPointer& operator=(const SmartPointer& ptr)
	{
		if (&ptr == this)
		{
			return *this;
		}
		delete this->ptr;
		this->ptr = new T;
		ptr = *ptr.ptr;
	}
	SmartPointer& operator=(SmartPointer&& ptr)
	{
		if (&ptr == this)
		{
			return *this;
		}
		delete this->ptr;
		this->ptr = ptr.ptr;
		ptr.ptr = nullptr;
		cout << "OPM" << endl;
		return *this;
	}

	~SmartPointer() { delete ptr; }
	T& operator*() { return *ptr; }
	T* operator->() { return ptr; }
	bool isPtr() { return ptr != nullptr; }
};

template <class T>
class SharedPointer
{
	T* ptr;
	int* count;
public:
	SharedPointer(T* ptr = nullptr) : ptr{ ptr }
	{ 
		count = new int(1);
		if (!this->count)
		{
			throw __OUT_OF_MEMORY__();
		}
	}

	SharedPointer(SharedPointer&& ptr) = delete;
	SharedPointer& operator=(SharedPointer&& ptr) = delete;

	SharedPointer(const SharedPointer& ptr)
	{ 
		this->ptr = ptr.ptr;
		this->count = ptr.count;
		++(*this->count);
	}

	SharedPointer& operator=(const SharedPointer& ptr)
	{
		if (&ptr == this)
		{
			return *this;
		}
		delete this->ptr;
		this->ptr = ptr.ptr;
		this->count = ptr.count;
		++(*this->count);
	}

	~SharedPointer() noexcept
	{
		--(*this->count);
		if (*count == 0)
		{
			delete ptr;
		}
    }

	T& operator*() const noexcept { return *ptr; }

	T* operator->() const noexcept { return ptr; }

	T* get()  const noexcept { return ptr; }
	int use_count() const noexcept { return *count; }
	bool unique() const noexcept { return *(this->count) == 1; }

	explicit operator bool() const noexcept
	{
		return this->ptr != nullptr;
	}
	void swap(SharedPointer& p) noexcept
	{
		std::swap(this->ptr,p.ptr);
		std::swap(this->count, p.count);
	}
};

template<class T>
class UniquePointer
{
	T* ptr;
public:
	UniquePointer(T* ptr = nullptr) : ptr{ ptr } {}

	UniquePointer(UniquePointer&& ptr)
	{
		this->ptr = ptr.ptr;
		ptr.ptr = nullptr;
	}
	UniquePointer& operator=(UniquePointer&& ptr)
	{
		if (&ptr == this)
		{
			return this;
		}
		delete this->ptr;
		this->ptr = new T;
		if (!this->ptr)
		{
			throw __OUT_OF_MEMORY__();
		}
		this->ptr = ptr.ptr;
		ptr.ptr = nullptr;
	}

	UniquePointer(const UniquePointer& ptr) = delete;
	UniquePointer& operator=(const UniquePointer& ptr) = delete;

	~UniquePointer() noexcept { delete ptr; }

	T& operator*() const noexcept { return *ptr; }

	T* operator->() const noexcept { return ptr; }

	T* get()  const noexcept { return ptr; }
	T* release() noexcept
	{
		T* temp = this->ptr;
		this->ptr = nullptr;
		return temp;
	}
	explicit operator bool() const noexcept
	{
		return this->ptr != nullptr;
	}
	void swap(UniquePointer& p) noexcept
	{
		std::swap(this->ptr, p.ptr);
	}
};

