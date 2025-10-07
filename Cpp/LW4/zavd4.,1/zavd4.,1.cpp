#include <iostream>
#include "D2.h"
#include "D3.h"

using namespace std;
int main()
{
    setlocale(0, "ukr");
    cout << "Об'єкт D2:" << endl;
    D2 d2;
    cout << endl;
    d2.print();

    cout << "\nОб'єкт D3:" << endl;
    D3 d3;
    cout << endl;
    d3.print();
}


