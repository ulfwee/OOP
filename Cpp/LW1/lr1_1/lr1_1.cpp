#include "Animal.h"
#include <iostream>
#include <conio.h>
using namespace std;

void print(Animal obj) {
	cout << "Animals: \n";
	obj.printAnimal();

}
int main() {
	string nameanim;
	string typeanim;
	int ageanim;
	cout << "Name: "; cin >> nameanim;
	cout << "Type: "; cin >> typeanim;
	cout << "Age: "; cin >> ageanim;

	
	Animal animal;
	Animal* animal1;
	animal1 = new Animal;
	Animal List[2] = {
		Animal("ggg", "kk", 4),
		Animal("lll", "jjj", 5)
	};
	
	animal.setAnimal("Klopa", "cat", 3);
	animal1->setAnimal("Zhuchka", "dog", 6);
	animal.setAnimal(nameanim, typeanim, ageanim);
	
	void (Animal:: * show)();
	show = &Animal::printAnimal;
	(animal.*show)();

	(List[0].*show)();

	animal1->printAnimal();


	animal.~Animal();
	animal1->~Animal();
	List[0].~Animal();
	List[1].~Animal();
	_getch();
	return 0;
}