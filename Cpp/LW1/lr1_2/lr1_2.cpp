#include <iostream>
#include "Money.h"
using namespace std;

int main() {
	setlocale(0, "ukr");
	Money money(7, 15);
	money.printMoney();

	int cost, price;
	cout << "Введіть суму товару: "; cin >> cost;
	cout << "Чи вистачить грошей купити товар за ціну " << cost << " ? " << (money.canBuy(cost) ? "Так" : "Ні") << endl;

	cout << "Введіть ціну товару: "; cin >> price;
	cout << "Скільки товарів за ціною " << price << " можна придбати? " << money.howMany(price) << endl;

	return 0;
}