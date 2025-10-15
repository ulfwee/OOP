
//2.	�������� ������ ����� : 
// ��������(�������, ���� �������� ������, ����� ������, ������� �� ������), 
//��������(�������, ���� ������ �������, ����� �������, ������� �� �������, ������� �����), 
//����������(�����, ���� �������� �������, ����� �������, ���� �� �������) � ����� �������� ��������� 
//���������� �� �����, � ���������� ���������� ���(�������� ������, ������ �������, �������� �������).
//3.	�������� ����(�����) � n �볺���, ������� ����� ���������� � ���� �� �����, 
//� ����� ����������� ����� �볺���, �� ������ ������������� � ������ � ������ ����.

#pragma once
#include "zavd.h"

class Creditor :public Client {
protected:
    string creditDate;
    double creditAmount;
    double interestRate;
    double remainingDebt;
public:
    Creditor(int id, string fname, string lname, string addr, string pass, string date, double amount, double rate, double debt)
        : Client(id, fname, lname, addr, pass), creditDate(date), creditAmount(amount), interestRate(rate), remainingDebt(debt) {
    }

    void show() const override {
        cout << "�������� ID: " << id << "\n"
            << "ϲ�: " << firstName << " " << lastName << "\n"
            << "������: " << address << "\n"
            << "�������: " << passport << "\n"
            << "���� ������ �������: " << creditDate << "\n"
            << "����� �������: " << creditAmount << "\n"
            << "³������: " << interestRate << "%\n"
            << "������� �����: " << remainingDebt << "\n";
    }

    bool matchC(const string& date) const override {
        return creditDate == date;
    }

    ~Creditor() override {}
};