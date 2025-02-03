#include <iostream>
using namespace std;
main()
{
    int x = 10;
    int *ptr= &x;
    int **ptr_to_ptr = &ptr;
    cout<<**ptr_to_ptr<<endl;
    cout<<*ptr_to_ptr<<endl;
    cout<<ptr_to_ptr<<endl;
    cout<<&x<<endl;
    cout<<&ptr<<endl;
}