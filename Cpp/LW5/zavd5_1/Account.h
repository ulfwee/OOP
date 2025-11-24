#pragma once
#include <string>
using namespace std;

class Account {
private:
    string number;
    double balance;

public:
    Account(string num, double bal) : number(num), balance(bal) {}

    void show() const {
        cout << "Рахунок: " << number
            << "\nБаланс: " << balance << "\n";
    }
};
