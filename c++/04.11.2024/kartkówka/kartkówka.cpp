#include <string>
#include <iostream>
using namespace std;


class Author {
public:
    string imie;
	string nazwisko;

	Author() : imie(""), nazwisko("") {}
	Author(const string& i, const string& n){
		this->imie = i;
		this->nazwisko = n;
	};

	void display() {
		cout << "Imie Autora: " << imie << "Nazwisko Autora: " << nazwisko << endl;
	}
};
class Publisher {

public:
	string Nazwa;
	Publisher() = default;
	Publisher(const string& a) {
		this->Nazwa = a;
	};
	void display() {
		cout << "Nazwa Publishera: " << Nazwa << endl;
	}
};

class Book {

public:
	string tytul_ksiazki;
	int rok_wydania;

	Author author;
	Publisher publisher;

	Book(const string& t, const int& r, Publisher& p, Author& a){
		this->publisher = p;
		this->author = a;		
		this->tytul_ksiazki = t;
		this->rok_wydania = r;
	};

	void display() {
		cout << "Dane ksiazki: " << tytul_ksiazki << "Rok Wydania: " << rok_wydania << endl;
	}
};

int main() {
	Author author("Bartek	", "Tolkien	");
	Publisher publisher("Polskie Wydawnictwo");
	Book book("Hobbit	", 1937, publisher, author);
	author.display();
	publisher.display();
	book.display();

	return 0;
}
























