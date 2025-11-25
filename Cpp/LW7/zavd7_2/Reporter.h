#pragma once
#include "zavd.h"

class Reporter {
public:
    void printShort(const Client& c) {
        cout << "Çâ³ò ïî êë³ºíòó: " << c.getLastName() << "\n";
    }
};
