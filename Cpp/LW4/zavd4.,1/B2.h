#pragma once
#include <iostream>
using namespace std;
class B2 {
public:
	float n_;
	B2() :n_(0) {
		cout << "����������� ��� ��������� (�2)" << endl;;
		cout << "�������� ����� � ���������" << endl;
		cout << "������ B2 (float): ";
		cin >> n_;
	}
	~B2(void) {
		cout << "���������� (B2)" << endl;
	}
};