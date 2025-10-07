#pragma once
#include <iostream>
#include "D1.h"
class D3 : private D1 {
public:
    string n_;
    D3() : D1(), n_("") {
        cout << "Конструктор без параметрів (D3)" << endl;
    cout << "Введення даних з клавіатури" << endl;
    cout << "Введіть D3 (string): ";
    cin >> n_;
}
    ~D3() {
        cout << "Деструктор (D3)" << endl;
    }
    void print() {
        cout << "D3: " << n_ << endl;
        D1::print();
    }
};