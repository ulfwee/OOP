#pragma once
#include <string>
using namespace std;
class Animal {
private:
public:
	string name_;
	string type_;
	int avgweight_;
public:
	Animal();
	Animal(string name, string type, int avgweight);
	Animal(const Animal&);
	~Animal(void);
	string getName();
	string getType();
	int getAvweight();
	void setAnimal(string name, string type, int avgweight);
	void setName(string name);
	void setType(string type);
	void setAvweight(int avgweight);
	void printAnimal();
};