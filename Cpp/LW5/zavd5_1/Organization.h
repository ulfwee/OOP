
//2.	Створити похідні класи : 
// Вкладник(прізвище, дата відкриття внеску, розмір внеску, відсоток по внеску), 
//Кредитор(прізвище, дата видачі кредиту, розмір кредиту, відсоток по кредиту, залишок боргу), 
//Організація(назва, дата відкриття рахунку, номер рахунку, сума на рахунку) з своїми методами виведення 
//інформації на екран, і визначення відповідності даті(відкриття внеску, видачі кредиту, відкриття рахунку).
//3.	Створити базу(маси`1`в) з n клієнтів, вивести повну інформацію з бази на екран, 
//а також організувати пошук клієнтів, що почали співробітничати з банком в задану дату.

#pragma once
#include "zavd.h"
#include "Account.h"

class Organization : public Client {
private:
    Account account;   

public:
    Organization(int id, string name, string addr, string pass,
        string date, string accNum, double balance)
        : Client(id, name, "", addr, pass),
        account(accNum, balance) 
    {
    }

    void show() const override {
        cout << "Організація ID: " << id << "\n"
            << "Назва: " << firstName << "\n";
        account.show();   
    }

    bool matchC(const string& date) const override {
        return false; 
    }
};
