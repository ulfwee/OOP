//1.	Створити абстрактний клас Клієнт з методами, 
//що дозволяють вивести на екран інформацію про клієнтів банку, 
//а також визначити відповідність клієнта критерію пошуку.
//2.	Створити похідні класи : Вкладник(прізвище, дата відкриття внеску, розмір внеску, відсоток по внеску), 
//Кредитор(прізвище, дата видачі кредиту, розмір кредиту, відсоток по кредиту, залишок боргу), 
//Організація(назва, дата відкриття рахунку, номер рахунку, сума на рахунку) з своїми методами виведення 
//інформації на екран, і визначення відповідності даті(відкриття внеску, видачі кредиту, відкриття рахунку).
//3.	Створити базу(масив) з n клієнтів, вивести повну інформацію з бази на екран, 
//а також організувати пошук клієнтів, що почали співробітничати з банком в задану дату.


#include <iostream>
#include "zavd.h"
#include "Investor.h"
#include "Creditor.h"
#include "Organization.h"

using namespace std;

void findClientsByDate(Client* clients[], int count, const string& date) {
    cout << "\nКлієнти, які почали співпрацю " << date << ":\n";
    bool found = false;
    for (int i = 0; i < count; i++) {
        if (clients[i] && clients[i]->matchC(date)) {
            clients[i]->show();
            cout << "------------------------\n";
            found = true;
        }
    }
    if (!found) {
        cout << "Клієнтів з датою " << date << " не знайдено.\n";
    }
}

int main() {
    setlocale(LC_ALL, "ukr");
    const int maxClients = 9;
    Client* clients[maxClients];
    int count = 0;

    clients[count] = new Investor(count + 1, "Mary", "Jonson", "Shevchenko street", "AB123456", "15.05.2023", 10000, 3.5);
    count++;
    clients[count] = new Creditor(count + 1, "John", "Ray", "Franko street", "CD789012", "20.06.2023", 50000, 7.5, 30000);
    count++;
    clients[count] = new Organization(count + 1, "BestOrg", "Prospect street", "UA123456", "15.05.2023", "UA1234567890", 100000);
    count++;

    cout << "Всі клієнти в базі даних:\n";
    for (int i = 0; i < count; i++) {
        if (clients[i] == nullptr) {
            cout << "Помилка: clients[" << i << "] є nullptr!" << endl;
            continue;
        }
        clients[i]->show();
        cout << "------------------------\n";
    }

    findClientsByDate(clients, count, "15.05.2023");

    for (int i = 0; i < count; i++) {
        delete clients[i];
    }

    return 0;
}
