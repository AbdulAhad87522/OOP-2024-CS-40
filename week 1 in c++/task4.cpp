#include <iostream>
using namespace std;
main()
{
    int x = 50;
int *ptr = &x;
ptr = ptr + 1;
cout << ptr;

}