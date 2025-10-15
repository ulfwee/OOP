
//2.	�������� ������ ����� : 
// ��������(�������, ���� �������� ������, ����� ������, ������� �� ������), 
//��������(�������, ���� ������ �������, ����� �������, ������� �� �������, ������� �����), 
//����������(�����, ���� �������� �������, ����� �������, ���� �� �������) � ����� �������� ��������� 
//���������� �� �����, � ���������� ���������� ���(�������� ������, ������ �������, �������� �������).
//3.	�������� ����(�����) � n �볺���, ������� ����� ���������� � ���� �� �����, 
//� ����� ����������� ����� �볺���, �� ������ ������������� � ������ � ������ ����.
#pragma once
#include "zavd.h"

class Investor : public Client {
private:
    string depositDate;
    double depositAmount;
    double interestRate;

public:
    Investor(int id, string fname, string lname, string addr, string pass, string date, double amount, double rate)
        : Client(id, fname, lname, addr, pass), depositDate(date), depositAmount(amount), interestRate(rate) {
    }

    void show() const override {
        cout << "�������� ID: " << id << "\n"
            << "ϲ�: " << firstName << " " << lastName << "\n"
            << "������: " << address << "\n"
            << "�������: " << passport << "\n"
            << "���� �������� ������: " << depositDate << "\n"
            << "����� ������: " << depositAmount << "\n"
            << "³������: " << interestRate << "%\n";
    }

    bool matchC(const string& date) const override {
        return depositDate == date;
    }

    ~Investor() override {}
};