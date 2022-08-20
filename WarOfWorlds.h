#pragma once
#include "List.h"
#include <random>
#include <iomanip>
class Troop abstract
{
	int hp = 0;
	int gc = 0;
	int dmg = 0;
	size_t hitsOn = 0;
	virtual ostream& print(ostream& out) const
	{
		out << setw(5) << left << "HP: " << hp << setw(5) << " , Gold: " << gc << setw(5) << " , Damage: " << dmg << endl;
		return out;
	}
public:
	Troop(int h = 0, int g = 0, int d = 0, size_t ho = 0) : hp{ h }, gc{ g }, dmg{ d }, hitsOn{ho} {}
	virtual string getType() const = 0;
	virtual void skill(Troop* enemy) = 0;
	void setGold(int g) { gc = g; }
	int getGold() const { return gc; }
	void setHP(int h) { hp = h; }
	int getHP() const { return hp; }
	int getDMG()const  { return dmg; }
	size_t getAC() const { return hitsOn; }
	void setAC(size_t ac) { hitsOn = ac; }
	friend ostream& operator<<(ostream& out, const Troop* tp);
};

ostream& operator<<(ostream& out, const Troop* tp)
{
	out << tp->getType() << " ";
	return tp->print(out);
}

class Light : public Troop
{
public:
	Light(int h = 0, int g = 0, int d = 0,size_t ho = 0) : Troop(h,g,d,ho) {}

};

class Dark : public Troop
{
public:
	Dark(int h = 0, int g = 0, int d = 0,size_t ho = 0) : Troop(h, g, d,ho) {}
};

class Archer : public Light
{
public:
	Archer() : Light(rand()% 20 + 60, rand() % 10 + 15, rand()% 10 + 20,2) {}
	virtual string getType()const override { return "Archer"; }
	virtual void skill(Troop* enemy) override
	{
		for (size_t i = 0; i < 3; i++)
		{
			int dice = rand() % 6;
			if (dice >=4)
			{
				enemy->setHP(enemy->getHP() - this->getDMG());
			}
		}
	}
	friend ostream& operator<<(ostream& out, const Archer* tp);
};

ostream& operator<<(ostream& out, const Archer* tp)
{
	out << "Archer" << endl;
	return out;
}

class Swordsman : public Light
{
public:
	Swordsman() : Light(rand() % 10 + 90, rand() % 5 + 10, rand() % 10 + 15,3) {}
	virtual string getType() const override { return "Swordsman"; }
	virtual void skill(Troop* enemy) override
	{
		int dice = rand() % 10 + 1;
		this->setHP(this->getHP() + dice);
	}
};

class Rider : public Light
{
public:
	Rider() : Light(rand() % 5 + 90, rand() % 2 + 10, rand() % 10 + 16,1) {}
	virtual string getType()const override { return "Rider"; }
	virtual void skill(Troop* enemy) override
	{
		int dice = rand() % 6;
		if (dice >= this->getAC())
		{
			enemy->setHP(enemy->getHP() - rand() % 21 + 32);
		}
	}
};

class Skeleton : public Dark
{
public:
	Skeleton() : Dark(rand() % 10 + 50, 0, rand() % 10 + 8,3) {}
	virtual string getType()const override { return "Skeleton"; }
	virtual void skill(Troop* enemy) override
	{
		this->setHP(rand() % 10 + 50);
	}
};

class Orc : public Dark
{
public:
	Orc() : Dark(rand() % 10 + 100, rand() % 3 + 5, rand() % 10 + 17,2) {}
	virtual string getType()const override { return "Orc"; }
	virtual void skill(Troop* enemy) override
	{
		this->setAC(1);
	}
};

class Elf : public Dark
{
public:
	Elf() : Dark(rand() % 25 + 60, rand() % 4 + 12, rand() % 10 + 25,2) {}
	virtual string getType()const override { return "Elf"; }
	virtual void skill(Troop* enemy) override
	{
		for (size_t i = 0; i < 2; i++)
		{
			int dice = rand() % 6;
			if (dice >= 2)
			{
				enemy->setHP(enemy->getHP() - this->getDMG());
			}
		}
	}
};

class War
{
	List<Light*> Alive;
	List<Dark*> Undead;
	int count;
	void init();
	void fight(Troop* w1, Troop* w2);
public:
	War(int c = 5) : count{ c } { init(); }
	void game();
};

void War::init()
{
	Light* a;
	Dark* d;
	for (size_t i = 0; i < count; i++)
	{
		int c = rand() % 3;
		switch (c)
		{
		case 0: a = new Archer; break;
		case 1: a = new Swordsman; break;
		case 2: a = new Rider; break;
		default: break;
		}
		Alive.push_back(a);
		c = rand() % 3;
		switch (c)
		{
		case 0: d = new Skeleton; break;
		case 1: d = new Orc; break;
		case 2: d = new Elf; break;
		default: break;
		}
		Undead.push_back(d);
	}
}

void War::game()
{
	while (!Alive.isEmpty() && !Undead.isEmpty())
	{
		system("cls");
		cout << "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\" << endl;
		cout << "\t\t\t\t\t WAR OF WORLDS" << endl;
		cout << "//////////////////////////////////////////////////////////////////////////////////////////////////" << endl;
		for (size_t i = 0; i < Alive.length(); i++)
		{
			cout << Alive[i];
		}
		cout << endl;
		int m = 3;
		for (size_t i = 0; i < Undead.length(); i++)
		{
			gotoxy(50, m++);
			cout << Undead[i] << endl;
		}
		int aliveWarr = rand() % Alive.length();
		int deadWarr = rand() % Undead.length();
		fight(Alive[aliveWarr], Undead[deadWarr]);
		cout << endl;
		m += 4;
		gotoxy(30, m++);
		cout << Alive[aliveWarr]->getType() << "  VS  " << Undead[deadWarr]->getType() << endl;
		if (Alive[aliveWarr]->getHP() <= 0)
		{
			gotoxy(30, m++);
			cout << Alive[aliveWarr]->getType() << " was slain" << endl;
			Alive.remove(aliveWarr);
		}
		if (Undead[deadWarr]->getHP() <= 0)
		{
			gotoxy(30, m++);
			cout << Undead[deadWarr]->getType() << " was slain" << endl;
			Undead.remove(deadWarr);
		}
		system("pause");
    }
	system("cls");
	gotoxy(30, 9);
	if (Alive.isEmpty())
	{
		cout << "Forces of Light were destroyed" << endl;
	}
	gotoxy(30, 10);
	if (Undead.isEmpty())
	{
		cout << "Forces of Darkness were destroyed" << endl;
	}
}

void War::fight(Troop* w1, Troop* w2)
{
	Troop* first = nullptr;
	Troop* second = nullptr;
	{
		int temp = rand() % 2;
		if (temp)
		{
			first = w1;
			second = w2;
		}
		else
		{
			first = w2;
			second = w1;
		}
	}
	while (first->getHP() >0 && second->getHP() > 0)
	{
		{
			int usingSkill = rand() % 10;// chance 1 in 10
			if (usingSkill == 0)
			{
				first->skill(second);
			}
			usingSkill = rand() % 10;
			if (usingSkill == 0 && first->getHP() > 0)
			{
				second->skill(first);
			}
		}
		if (first->getHP() > 0 && second->getHP() > 0)
		{
			int dice = rand() % 6; // d6 to hit
			if (dice >= first->getAC())
			{
				second->setHP(second->getHP() - first->getDMG());
			}
			dice = rand() % 6;
			if (dice >= second->getAC() && second->getHP() > 0)
			{
				first->setHP(first->getHP() - second->getDMG());
			}
		}
		if (first->getHP() > 0 && second->getHP() <=0)
		{
			first->setGold(first->getGold() + second->getGold());
		}
		else if (first->getHP() <= 0 && second->getHP() > 0)
		{
			second->setGold(second->getGold() + first->getGold());
		}
	}
	
}
