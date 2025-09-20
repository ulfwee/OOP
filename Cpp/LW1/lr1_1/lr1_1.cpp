#include "Animal.h"
#include <iostream>
#include <conio.h>
using namespace std;

void print(Animal obj) {
	cout << "Animals: \n";
	obj.printAnimal();

}
int main() {
	Animal animal;
	Animal* animal1;
	animal1 = new Animal;
	Animal List[2];
	animal.setAnimal("Klopa", "cat", 3);
	animal1->setAnimal("Zhuchka", "dog", 6);
	animal.printAnimal();
	animal1->printAnimal();
	animal.~Animal();
	animal1->~Animal();
	List[0].~Animal();
	List[1].~Animal();
	_getch();
	return 0;
}