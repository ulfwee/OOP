#pragma once
#include <iostream>
#include "D1.h"
class D3 : private D1 {
public:
    string n_;
    D3() : D1(), n_("") {
        cout << "����������� ��� ��������� (D3)" << endl;
    cout << "�������� ����� � ���������" << endl;
    cout << "������ D3 (string): ";
    cin >> n_;
}
    ~D3() {
        cout << "���������� (D3)" << endl;
    }
    void print() {
        cout << "D3: " << n_ << endl;
        D1::print();
    }
};