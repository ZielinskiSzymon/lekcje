#include <iostream>
using namespace std;

int main() {
	int liczba= 39101;
	int nieparzyste=0;
	int p=1;

	//cout << "Podaj liczbe: ";
	//cin >> liczba;
	
	while (liczba>0){
		if (liczba % 2 == 1) {
			nieparzyste = liczba % 10;
			p=nieparzyste;
			nieparzyste += p;
			p *= 10;
		}
		liczba = liczba / 10;
	}
	cout << nieparzyste;
}