//1.	Створити абстрактний клас Клієнт з методами, 
//що дозволяють вивести на екран інформацію про клієнтів банку, 
//а також визначити відповідність клієнта критерію пошуку.
//2.	Створити похідні класи : 
// Вкладник(прізвище, дата відкриття внеску, розмір внеску, відсоток по внеску), 
//Кредитор(прізвище, дата видачі кредиту, розмір кредиту, відсоток по кредиту, залишок боргу), 
//Організація(назва, дата відкриття рахунку, номер рахунку, сума на рахунку) з своїми методами виведення 
//інформації на екран, і визначення відповідності даті(відкриття внеску, видачі кредиту, відкриття рахунку).
//3.	Створити базу(масив) з n клієнтів, вивести повну інформацію з бази на екран, 
//а також організувати пошук клієнтів, що почали співробітничати з банком в задану дату.

#pragma once
#include <iostream>
#include <string>
using namespace std;

class Client {
protected:
    int id;
    string firstName; 
    string lastName;
    string address;
    string passport;

public:
    Client(int id, string fname, string lname, string addr, string pass)
        : id(id), firstName(fname), lastName(lname), address(addr), passport(pass) {
    }

    string getLastName() const { return lastName; }
    virtual void show() const = 0; 
    virtual bool matchC(const string& date) const = 0; 
    virtual string getType() const = 0;
    virtual ~Client() {}
};