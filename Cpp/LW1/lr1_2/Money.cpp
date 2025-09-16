#include "Money.h"

Money::Money(): first(1), second(1) {}

Money::Money(int f, int s): first(f), second(s) {}

int Money::getFirst() {
	return first;
}
int Money::getSecond() {
	return second;
}
int Money::getTotalsum() {
	return first * second;
}
void Money::setFirst(int f) {
	first = f;
}
void Money::setSecond(int s) {
	second = s;
}
void Money::printMoney() {
	cout << "Номінал купюри: " << first << "\tКількість: " << second << "\tЗагальна сума " << getTotalsum() << endl;
}
bool Money::canBuy(int n) {
	if (getTotalsum() >= n) return true; else return false;
}
int Money::howMany(int price) {
	if (price <= 0) return 0;
	else return getTotalsum() / price;
}