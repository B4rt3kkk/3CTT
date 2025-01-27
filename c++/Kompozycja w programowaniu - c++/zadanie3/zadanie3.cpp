#include <iostream>
#include <string>
using namespace std;

class Engine {
public:
	int power;
	double capacity;

	Engine(int p, double c) : power(p), capacity(c) {}
	void display() const {
		cout << "Engine Power: " << power << "HP, CAPACITY: " << capacity << endl;
	}
};
class Car {
public:
	string model;
	Engine engine;
	Car(const string& m, const Engine& e) : model(m), engine(e) {}
	void display() const {
		cout << "Car Model: " << model << endl;
		engine.display();
	}

};

int main()
{
	Engine engine(150, 2.0);
	Car car("Toyota", engine);
	car.display();


	return 0;
}
