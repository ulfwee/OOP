#pragma once
#include <iostream>
using namespace std;
class B1 {
public:
	int n_;
	B1() :n_(0) {
		cout << "Конструктор без параметрів (B1)" << endl;
		cout << "Введення даних з клавіатури" << endl;
		cout << "Введіть B1 (int): ";
		cin >> n_;
	}
	~B1(void) {
		cout << "Деструктор (B1)" << endl;
	}
};