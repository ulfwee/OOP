
//2.	Створити похідні класи : 
// Вкладник(прізвище, дата відкриття внеску, розмір внеску, відсоток по внеску), 
//Кредитор(прізвище, дата видачі кредиту, розмір кредиту, відсоток по кредиту, залишок боргу), 
//Організація(назва, дата відкриття рахунку, номер рахунку, сума на рахунку) з своїми методами виведення 
//інформації на екран, і визначення відповідності даті(відкриття внеску, видачі кредиту, відкриття рахунку).
//3.	Створити базу(масив) з n клієнтів, вивести повну інформацію з бази на екран, 
//а також організувати пошук клієнтів, що почали співробітничати з банком в задану дату.

#pragma once
#include "zavd.h"

class Creditor :public Client {
protected:
    string creditDate;
    double creditAmount;
    double interestRate;
    double remainingDebt;
public:
    Creditor(int id, string fname, string lname, string addr, string pass, string date, double amount, double rate, double debt)
        : Client(id, fname, lname, addr, pass), creditDate(date), creditAmount(amount), interestRate(rate), remainingDebt(debt) {
    }

    void show() const override {
        cout << "Кредитор ID: " << id << "\n"
            << "ПІБ: " << firstName << " " << lastName << "\n"
            << "Адреса: " << address << "\n"
            << "Паспорт: " << passport << "\n"
            << "Дата видачі кредиту: " << creditDate << "\n"
            << "Розмір кредиту: " << creditAmount << "\n"
            << "Відсоток: " << interestRate << "%\n"
            << "Залишок боргу: " << remainingDebt << "\n";
    }

    bool matchC(const string& date) const override {
        return creditDate == date;
    }

    string getType() const override { return "Creditor"; }

    ~Creditor() override {}
};