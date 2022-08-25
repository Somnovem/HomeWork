#pragma once
#include <iostream>
#include <map>
#include <fstream>
using namespace std;
class FrequencyDictionary
{
	map<string, int> vocabulary;
public:
	FrequencyDictionary() {}
	bool work(ifstream& in, ofstream& out)
	{
		if (in.is_open() && out.is_open())
		{
			{
				string temp;
				while (in >> temp)
				{
					vocabulary[temp]++;
				}
			}
			auto it = vocabulary.begin();
			cout << "-----------------" << endl;
			cout << "All words: " << endl;
			while (it != vocabulary.end())
			{
				cout << (*it).first << "\t" << (*it).second << endl;
				it++;
			}
			it = vocabulary.end();
			it--;
			cout << "-----------------" << endl;
			cout << "Most used words: " << endl;
			string Words[5];

			{
				int previousMax = 0;
				int tempValue = 0;
				it = vocabulary.begin();
				while (it != vocabulary.end())
				{
					if (vocabulary.at((*it).first) > previousMax)
					{
						previousMax = vocabulary.at((*it).first);
						Words[0] = (*it).first;
					}
					it++;
				}
				for (size_t i = 1; i < 5; i++)
				{
					it = vocabulary.begin();
					tempValue = 0;
					while (it != vocabulary.end())
					{
						if (vocabulary.at((*it).first) > tempValue && vocabulary.at((*it).first) < previousMax)
						{
							tempValue = vocabulary.at((*it).first);
							Words[i] = (*it).first;
						}
						it++;
					}
					previousMax = tempValue;
				}
			}

			for (size_t i = 0; i < 5; i++)
			{
				auto temp = vocabulary.find(Words[i]);
				cout << (*temp).first << "\t" << (*temp).second << endl;
			}
			it = vocabulary.begin();
			while (it != vocabulary.end())
			{
				out << (*it).first << "\t" << (*it).second << endl;
				it++;
			}
			return 1;
		}
		return 0;
	}
};

