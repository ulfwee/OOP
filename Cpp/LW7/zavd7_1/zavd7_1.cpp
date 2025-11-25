#include <iostream>
#include <map>
#include <deque>
#include <iterator>
#include <vector>
#include <ctime>
#include <cstdlib>
#include <iomanip>

using namespace std;

int main() {
    setlocale(0, "ukr");
    srand(time(nullptr));
    string array[7] = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    multimap<string, float> measurements;
    multimap < string, float>::iterator myIt;
    
    for (int i = 0;i < array->length();i++) measurements.insert(make_pair(array[i], static_cast<float>(rand()) / RAND_MAX * 30.0f));

    for (auto myIt = measurements.begin(); myIt != measurements.end(); ++myIt) {
        cout << myIt->first << " -> " <<setprecision(3) << myIt->second << endl;
    }
    cout << endl;


    cout << "\nMonday:\n";
    auto range = measurements.equal_range("Monday");
    for (auto myIt = range.first; myIt != range.second; ++myIt) {
        cout << myIt->second << endl;
    }

    deque<float> queue;

    queue.push_back(1.5f);
    queue.push_back(2.7f);
    queue.push_front(0.9f);  
    queue.push_front(0.4f);

    cout << "\nDeque значень\n";
    for (float x : queue) {
        cout << x << " ";
    }

    queue.pop_front();
    queue.pop_back();

    cout << "\n\nПісля видалення\n";
    for (float x : queue) {
        cout << x << " ";
    }

    return 0;
}

