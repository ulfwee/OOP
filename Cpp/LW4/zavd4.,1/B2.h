#pragma once
#include <iostream>
using namespace std;
class B2 {
public:
	float n_;
	B2() :n_(0) {
		cout << "Конструктор без параметрів (В2)" << endl;;
		cout << "Введення даних з клавіатури" << endl;
		cout << "Введіть B2 (float): ";
		cin >> n_;
	}
	~B2(void) {
		cout << "Деструктор (B2)" << endl;
	}
};