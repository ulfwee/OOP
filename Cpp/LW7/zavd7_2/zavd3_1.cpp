#include <iostream>
#include <string>
#include <map>
#include <queue>
#include <vector>
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

    cout << "\nmultimap\n\n";

    multimap<string, Client*> clientsMap;

    for (auto it = g.begin(); it != g.end(); ++it) {
        clientsMap.insert({ (*it)->getType(), *it });
    }

    for (auto& p : clientsMap) {
        cout << p.first << ":\n";
        p.second->show();
        cout << "---------------\n";
    }


    cout << "\nqueue\n"; cout << endl;

    queue<Client*> processQueue;

    for (auto it = g.begin(); it != g.end(); ++it) {
        processQueue.push(*it);
    }

    while (!processQueue.empty()) {
        Client* c = processQueue.front();
        processQueue.pop();

        cout << "\nОбробка клієнта з черги:\n";
        c->show();
    }

    return 0;
}

void showClient(Client* c) {
    cout << "\nОбробка клієнта\n";
    c->show();
}
