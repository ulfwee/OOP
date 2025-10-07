#pragma once
#include <iostream>
#include "B1.h"
#include "B2.h"
class D1 : private B1, public B2 {
public:
    double n_;
    D1() : B1(), B2(), n_(0.0) {
        cout << "����������� ��� ��������� (D1)" << endl;
        cout << "�������� ����� � ���������" << endl;
        cout << "������ D1 (double): ";
        cin >> n_;
    }
    ~D1() {
        cout << "���������� (D1)" << endl;
    }
    void print() {
        cout << "D1: " << n_ << endl;
        cout << "B1: " << B1::n_ << endl;
        cout << "B2: " << B2::n_ << endl;
    }
};