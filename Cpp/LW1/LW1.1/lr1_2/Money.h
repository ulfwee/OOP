#pragma once
#include <iostream>
using namespace std;
class Money {
public:
	int first;
	int second;
public:
	Money();
	Money(int f, int s);
	void setFirst(int f);
	void setSecond(int s);
	int getFirst();
	int getSecond();
	int getTotalsum();

	void printMoney();
	bool canBuy(int n);
	int howMany(int price);
};