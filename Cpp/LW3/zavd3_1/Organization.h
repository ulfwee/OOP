
//2.	�������� ������ ����� : 
// ��������(�������, ���� �������� ������, ����� ������, ������� �� ������), 
//��������(�������, ���� ������ �������, ����� �������, ������� �� �������, ������� �����), 
//����������(�����, ���� �������� �������, ����� �������, ���� �� �������) � ����� �������� ��������� 
//���������� �� �����, � ���������� ���������� ���(�������� ������, ������ �������, �������� �������).
//3.	�������� ����(����`1`�) � n �볺���, ������� ����� ���������� � ���� �� �����, 
//� ����� ����������� ����� �볺���, �� ������ ������������� � ������ � ������ ����.

#pragma once
#include "zavd.h"

class Organization : public Client {
private:
    string accountDate;
    string accountNumber;
    double accountBalance;

public:
    Organization(int id, string name, string addr, string pass, string date, string accNum, double balance)
        : Client(id, name, "", addr, pass), accountDate(date), accountNumber(accNum), accountBalance(balance) {
    }

    void show() const override {
        cout << "���������� ID: " << id << "\n"
            << "�����: " << firstName << "\n"
            << "������: " << address << "\n"
            << "�������: " << passport << "\n"
            << "���� �������� �������: " << accountDate << "\n"
            << "����� �������: " << accountNumber << "\n"
            << "���� �� �������: " << accountBalance << "\n";
    }

    bool matchC(const string& date) const override {
        return accountDate == date;
    }

    ~Organization() override {}
};
