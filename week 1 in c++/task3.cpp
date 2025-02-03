#include <iostream>
using namespace std;
main()
{
    char arr[20];
int i;
for ( i = 0; i < 10; i++ ){
	*(arr + i) = 65 + i; // ‘65’ is ASCII code of ‘A’
    cout << arr[i];
}
}