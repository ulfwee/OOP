#include <iostream>
#include <string>
using namespace std;

#include "zavd.h"
#include "Investor.h"
#include "Creditor.h"
#include "Organization.h"
#include "Group.h"
#include "Reporter.h"


void showClient(Client* c);

int main() {
    setlocale(LC_ALL, "ukr");

    Group g;

    g.add(new Investor(1, "Mary", "Jonson", "Shevchenko 12", "AB123456",
        "15.05.2023", 10000, 3.5));

    g.add(new Creditor(2, "John", "Ray", "Franko 9", "CD789012",
        "20.06.2023", 50000, 7.5, 30000));

    g.add(new Organization(3, "BestOrg", "Central ave.", "UA123456",
        "15.05.2023", "UA3456789000", 100000));


    cout << "=== Вивід через showAll() ===\n";
    g.showAll();

    cout << "\n=== Перебір групи через ітератор ===\n";
    for (auto it = g.begin(); it != g.end(); ++it) {
        (*it)->show();
        cout << "-------------------\n";
    }

    cout << "\n=== forEach(showClient) ===\n";
    g.forEach(showClient);

    cout << "\n=== Reporter (DEPENDENCY) ===\n";
    Reporter rep;

    for (auto it = g.begin(); it != g.end(); ++it) {
        rep.printShort(**it);
    }

    return 0;
}

void showClient(Client* c) {
    cout << "\n### Обробка клієнта ###\n";
    c->show();
}
