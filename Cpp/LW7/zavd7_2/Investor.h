
//2.	Створити похідні класи : 
// Вкладник(прізвище, дата відкриття внеску, розмір внеску, відсоток по внеску), 
//Кредитор(прізвище, дата видачі кредиту, розмір кредиту, відсоток по кредиту, залишок боргу), 
//Організація(назва, дата відкриття рахунку, номер рахунку, сума на рахунку) з своїми методами виведення 
//інформації на екран, і визначення відповідності даті(відкриття внеску, видачі кредиту, відкриття рахунку).
//3.	Створити базу(масив) з n клієнтів, вивести повну інформацію з бази на екран, 
//а також організувати пошук клієнтів, що почали співробітничати з банком в задану дату.
#pragma once
#include "zavd.h"

class Investor : public Client {
private:
    string depositDate;
    double depositAmount;
    double interestRate;

public:
    Investor(int id, string fname, string lname, string addr, string pass, string date, double amount, double rate)
        : Client(id, fname, lname, addr, pass), depositDate(date), depositAmount(amount), interestRate(rate) {
    }

    void show() const override {
        cout << "Вкладник ID: " << id << "\n"
            << "ПІБ: " << firstName << " " << lastName << "\n"
            << "Адреса: " << address << "\n"
            << "Паспорт: " << passport << "\n"
            << "Дата відкриття внеску: " << depositDate << "\n"
            << "Розмір внеску: " << depositAmount << "\n"
            << "Відсоток: " << interestRate << "%\n";
    }

    bool matchC(const string& date) const override {
        return depositDate == date;
    }

    string getType() const override { return "Investor"; }

    ~Investor() override {}
};