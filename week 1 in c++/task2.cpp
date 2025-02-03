#include <iostream>
using namespace std;
main()
{
    int x = 100;
    int y = 200;
    int *p = &x,*q = &y;
    p  = q;
    cout<<*p;
}