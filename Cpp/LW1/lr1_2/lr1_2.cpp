#include <iostream>
#include "Money.h"
using namespace std;

int main() {
	setlocale(0, "ukr");
	int n, k;
	cout << "Введіть номінал: "; cin >> n;
	cout << "ВВедіть к-ть куплюр: "; cin >> k;
	if (n == 1 || n == 2 || n == 5 || n == 10 || n == 20 || n == 50 || n == 100 || n == 200 || n == 500 || n == 1000) {
		Money money(n, k);
		money.printMoney();

		int cost, price;
		cout << "Введіть суму товару: "; cin >> cost;
		cout << "Чи вистачить грошей купити товар за ціну " << cost << " ? " << (money.canBuy(cost) ? "Так" : "Ні") << endl;

		cout << "Введіть ціну товару: "; cin >> price;
		cout << "Скільки товарів за ціною " << price << " можна придбати? " << money.howMany(price) << endl;
		return 0;
	}
	else {
		
		cout << "Направильно введений капітал";
		return 0;
	}
	
}