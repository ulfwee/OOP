#pragma once
#include <iostream>
using namespace std;
class B1 {
public:
	int n_;
	B1() :n_(0) {
		cout << "����������� ��� ��������� (B1)" << endl;
		cout << "�������� ����� � ���������" << endl;
		cout << "������ B1 (int): ";
		cin >> n_;
	}
	~B1(void) {
		cout << "���������� (B1)" << endl;
	}
};