//9.	Додати в клас для роботи :
//Перевантаження :
//	констант true і false : звернення до екземпляра класу дає значення true, якщо поле R додатне, інакше false;
//	операції бінарного + :, яка  збільшує значення поля R на 2;.
//	перетворення класу Circle в тип string(і навпаки).

#pragma once
#include <iostream>
#include <string>
using namespace std;
class Circle {
private:
	double R_;
public:
	Circle();
	Circle(double R);
	~Circle();

	void setR(double R);
	double getR();

	explicit operator bool() const {
		return R_ > 0;
	}
	
	//prefix
	 Circle& operator++() {
		R_ += 1.0;
		return *this;
	 }
	 Circle& operator--() {
		 R_ -= 1.0;
		 return *this;
	}

	//postfix
	 Circle operator++(int) {
		Circle temp = *this;
		++(*this);
		return temp;
	}
	 Circle operator--(int) {
		Circle temp = *this;
		--(*this);
		return temp;
	}

	 friend Circle operator+(const Circle& c1, const Circle& c2);
	 friend Circle operator-(const Circle& c1, const Circle& c2);

	 friend Circle operator+(const Circle& c1, double n);
	 friend Circle operator+(double n, const Circle& c1);

	 friend Circle operator-(const Circle& c1, double n);
	 friend Circle operator-(double n, const Circle& c1);


	operator string() const {
		return to_string(R_);
	}

	friend ostream& operator<< (ostream& out, const Circle& c);

	Circle& operator+=(int n) {
		R_ += n;
		return *this;
	}

	Circle& operator-=(int n) {
		R_ -= n;
		return *this;
	}

	friend bool operator>(Circle& other1, double n);

	const Circle operator+() noexcept {
		return *this;
	}
	const Circle operator-() noexcept {
		return Circle(-R_);
	}

	friend bool operator!(const Circle& c);


};
