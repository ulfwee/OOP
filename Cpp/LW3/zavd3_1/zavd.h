//1.	�������� ����������� ���� �볺�� � ��������, 
//�� ���������� ������� �� ����� ���������� ��� �볺��� �����, 
//� ����� ��������� ���������� �볺��� ������� ������.
//2.	�������� ������ ����� : 
// ��������(�������, ���� �������� ������, ����� ������, ������� �� ������), 
//��������(�������, ���� ������ �������, ����� �������, ������� �� �������, ������� �����), 
//����������(�����, ���� �������� �������, ����� �������, ���� �� �������) � ����� �������� ��������� 
//���������� �� �����, � ���������� ���������� ���(�������� ������, ������ �������, �������� �������).
//3.	�������� ����(�����) � n �볺���, ������� ����� ���������� � ���� �� �����, 
//� ����� ����������� ����� �볺���, �� ������ ������������� � ������ � ������ ����.

#pragma once
#include <iostream>
#include <string>
using namespace std;

class Client {
protected:
    int id;
    string firstName; 
    string lastName;
    string address;
    string passport;

public:
    Client(int id, string fname, string lname, string addr, string pass)
        : id(id), firstName(fname), lastName(lname), address(addr), passport(pass) {
    }

    virtual void show() const = 0; 
    virtual bool matchC(const string& date) const = 0; 
    virtual ~Client() {}
};