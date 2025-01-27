#include <iostream>
using namespace std;

class Silnik {
    public:
        int moc;
        Silnik (int _moc) {
		    this -> moc = _moc;
        }
};

class Samochod {
    private:
        Silnik silnik;

    public:
		Samochod(int moc) :silnik(moc) {}
		void jedzie() {
			cout << "Samochod jedzie z mocą: " << endl;
        }
};


int main()
{
    std::cout << "Zadanie 1 - Kompozycja\n";
}

