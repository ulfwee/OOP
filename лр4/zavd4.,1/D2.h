#pragma once
#include <iostream>
#include "D1.h"
class D2 : public D1 {
public:
    char n_;
    D2() : D1(), n_('\0') {
        cout << "����������� ��� ��������� (D2)" << endl;
        cout << "�������� ����� � ���������" << endl;
        cout << "������ D2 (char): ";
        cin >> n_;
    }
    
   ~D2() {
        cout << "���������� (D2)" << endl;
    }
   void print() {
       cout << "D2: " << n_ << endl;
       D1::print();
   }
};