#pragma once
#include <vector>
#include "zavd.h"

class Group {
private:
    std::vector<Client*> list;   

public:
    Group() {}

    void add(Client* c) {
        list.push_back(c);
    }

    void showAll() const {
        cout << "\n=== ¬м≥ст групи ===\n";
        for (auto c : list) {
            c->show();
            cout << "-------------------\n";
        }
    }

    class Iterator {
    private:
        Client** ptr;
    public:
        Iterator(Client** p) : ptr(p) {}

        Client* operator*() { return *ptr; }

        Iterator& operator++() {
            ptr++;
            return *this;
        }

        bool operator!=(const Iterator& other) const {
            return ptr != other.ptr;
        }
    };

    Iterator begin() {
        return Iterator(list.data());
    }

    Iterator end() {
        return Iterator(list.data() + list.size());
    }

    void forEach(void (*func)(Client*)) {
        for (auto c : list) func(c);
    }
};
