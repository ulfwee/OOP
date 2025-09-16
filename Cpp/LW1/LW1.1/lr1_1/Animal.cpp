#include "Animal.h"
#include <iostream>
#include <iomanip>



Animal::Animal() :name_(""), type_(""), avgweight_(0) {
	cout << "Constructor without parameters " << this << endl;
}
Animal::Animal(string name, string type, int avgweight) 
	: name_(name), type_(type), avgweight_(avgweight) {
	cout << "Constructor with parameters " << this << endl;
}
Animal::Animal(const Animal&) {
	cout << "Copy constructor " << this << endl;
}
Animal::~Animal(void) {
	cout << "Destructor " << this << endl;
}
string Animal::getName() {
	return name_;
}
string Animal::getType() {
	return type_;
}
int Animal::getAvweight() {
	return avgweight_;
}
void Animal::setName(string name) {
	name_ = name;
}
void Animal::setType(string type) {
	type_ = type;
}
void Animal::setAvweight(int avgweight) {
	avgweight_ = avgweight;
}
void Animal::printAnimal() {
	cout << "Name: " << name_ << "\tType: " << type_ << "\tAverage weight: " << avgweight_ << endl;
}
void Animal::setAnimal(string name, string type, int avgweight) {
	name_ = name;
	type_ = type;
	avgweight_ = avgweight;
}