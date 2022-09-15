#pragma once
#include <iostream>
#include <string>

using namespace std;

class IRedactor
{
public:

	virtual ~IRedactor() {}
	virtual void open(const string& path) = 0;
	virtual void create() = 0;
	virtual void save() = 0;
	virtual void save_as() = 0;
	virtual void print() = 0;
	virtual void exit() = 0;
};

class ITextRedactor : public IRedactor
{
};

class TxtRedactor : public ITextRedactor
{
public:
	virtual void open(const string& path)
	{
		cout << "Txt redactor opened" << endl;
	};
	virtual void create()
	{
		cout << "New Txt created" << endl;
	};
	virtual void save()
	{
		cout << "Saved as Txt" << endl;
	};
	virtual void save_as()
	{
		cout << "Saved with new settings from Txt" << endl;
	};
	virtual void print()
	{
		cout << "Sent to print a Txt" << endl;
	};
	virtual void exit()
	{
		cout << "Exited Txt" << endl;
	};
};

class BinRedactor : public ITextRedactor
{
	virtual void open(const string& path)
	{
		cout << "Bin redactor opened" << endl;
	};
	virtual void create()
	{
		cout << "New Bin created" << endl;
	};
	virtual void save()
	{
		cout << "Saved as Bin" << endl;
	};
	virtual void save_as()
	{
		cout << "Saved with new settings from Bin" << endl;
	};
	virtual void print()
	{
		cout << "Sent to print a Bin" << endl;
	};
	virtual void exit()
	{
		cout << "Exited Bin" << endl;
	};
};


class IGraphicRedactor : public IRedactor
{

};

class JPEGRedactor : public IGraphicRedactor
{
	virtual void open(const string& path)
	{
		cout << "JPEG redactor opened" << endl;
	};
	virtual void create() 
	{
		cout << "New JPEG created" << endl;
	};
	virtual void save()
	{
		cout << "Saved as JPEG" << endl;
	};
	virtual void save_as()
	{
		cout << "Saved with new settings from JPEG" << endl;
	};
	virtual void print()
	{
		cout << "Sent to print a JPEG" << endl;
	};
	virtual void exit()
	{
		cout << "Exited JPEG" << endl;
	};
};

class PNGRedactor : public IGraphicRedactor
{
	virtual void open(const string& path)
	{
		cout << "PNG redactor opened" << endl;
	};
	virtual void create()
	{
		cout << "New PNG created" << endl;
	};
	virtual void save()
	{
		cout << "Saved as PNG" << endl;
	};
	virtual void save_as()
	{
		cout << "Saved with new settings from PNG" << endl;
	};
	virtual void print()
	{
		cout << "Sent to print a PNG" << endl;
	};
	virtual void exit()
	{
		cout << "Exited PNG" << endl;
	};
};