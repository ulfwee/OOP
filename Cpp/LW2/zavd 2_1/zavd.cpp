#include "zavd.h"

Circle::Circle() :R_(0.0) { }

Circle::Circle(double R) :R_(R) {};

Circle::~Circle(void) {}


double Circle::getR() {
	return R_;
}
void Circle::setR(double R) {
	R_ = R;
}
bool operator>(Circle& other1, double n)
{
	if (other1.R_ > n) return true; else return false;
}

ostream& operator<< (ostream& out, const Circle& c)
{
	out << c.R_;
	return out;
}

Circle operator+(const Circle& c1, const Circle& c2)
{
	return Circle(c1.R_ + c2.R_);
}

Circle operator-(const Circle& c1, const Circle& c2)
{
	return Circle(c1.R_ - c2.R_);
}

Circle operator+(const Circle& c1, double n) {
	return Circle(c1.R_ + n);
}
Circle operator+(double n, const Circle& c1) {
	return Circle(c1.R_ + n);
}

Circle operator-(double n, const Circle& c1) {
	return Circle(n - c1.R_);
}
Circle operator-(const Circle& c1, double n) {
	return Circle(c1.R_ - n);
}

bool operator!(const Circle& c) {
	return !c.R_;
}