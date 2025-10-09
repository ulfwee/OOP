//9.	Додати в клас для роботи :
//Перевантаження :
//	констант true і false : звернення до екземпляра класу дає значення true, якщо поле R додатне, інакше false;
//	операції бінарного + :, яка  збільшує значення поля R на 2;.
//	перетворення класу Circle в тип string(і навпаки).


#include <iostream>
#include "zavd.h"

int main()
{
    Circle c1(3.5);
    Circle c2(-1.0);

    if (c1) cout << "Radius is > 0 (" << c1 << ")" << endl;
    else cout<<"Radius is < 0 (" << c1 << ")" << endl;

    if (c2) cout << "Radius is > 0 (" << c2 << ")" << endl;
    else cout << "Radius is < 0 (" << c2 << ")" << endl;
    cout << endl;
    c2 += 2;
    cout <<"r2 + 2 = "<< c2<<endl;

    c1 -= 1;
    cout << "c1 - 1 = " << c1 << endl;
    cout << endl;

    Circle c3(5.8);
    cout << "c3: " << c3 << endl;
    cout << "prefix ++c3:" << ++c3 << "  --> c3 now: " << c3 << endl;
    cout << "postfix c3++:" << c3++ << "  --> c3 now: " << c3 << endl;
    cout << "prefix --c3: " << --c3 << "  --> c3 now: " << c3 << endl;
    cout << "postfix c3--: " << c3-- << "  --> c3 now: " << c3 << endl;
    cout << endl;

    Circle c4 = c1 + c3;
    cout << "c4 = c1 + c3 = " << c4 << endl;

    cout << "c4 - c2 = " << c4 - c2 << endl;

    cout << "c4 + 10 = " << c4 + 10 << endl;
    cout << "6.8 - c3 = " << 6.8 - c3 << endl;
    cout << endl;

    Circle c5(9.0);
    string s = c5;
    cout << "Radius of c5: " << s << endl;
    cout << "-c5 = " << -c5 << endl;
    cout << endl;

    c1 = Circle(0.0);
    if (!c1) cout << "Radius c1 = 0" << endl;
    else cout << "Radius c1 != 0; c1 = " << c1 << endl;

    if (!c4) cout << "Radius c4 = 0" << endl;
    else cout << "Radius c4 != 0; c4 = " << c4 << endl;
    
    return 0;
}

