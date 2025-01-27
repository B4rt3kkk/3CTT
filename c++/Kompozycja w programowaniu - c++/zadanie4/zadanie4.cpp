#include <iostream>
#include <string>
using namespace std;

class Autor {
public:
	string imie, nazwisko;

	Autor() : imie(""), nazwisko(""){}
	Autor(const string &i, const string& n) : imie(i), nazwisko(n) {
		this->imie = i;
		this->nazwisko = n;
	}
	void display() const {
		cout << "imie: " << imie << "nazwisko: " << nazwisko << endl;
	}
};
class Book {
public:
	string tytul;
	Autor autor;
	Book(const string& t, const Autor& a) : tytul(t), autor(a) {}
	void display() const {
		cout << "Tytuł książki " << tytul << endl;
		autor.display();
	}

};

int main()
{
	Autor autor("Jan", "Kowalski");
	Book ksiazka("C++: Zaczynając od podstaw", autor);
	ksiazka.display();

	return 0;
}
