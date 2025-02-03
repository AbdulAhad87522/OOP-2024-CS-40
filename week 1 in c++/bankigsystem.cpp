#include <iostream>
#include <windows.h>
#include <conio.h>
using namespace std;
int menu();
void getloan(int &loan);
void depositmoney(int &money);
void withdrawmoney(int &money_withdraw);
void deduct_zakat(int &zakat_money,int final_money);
void total_money(int final_money);

main()
{
    int loan,money,money_withdraw,zakat_money;
    int final_money;
    int option;
    while(option != 6)
    {
        system("cls");
        option = menu();
        if(option == 1)
        {
            getloan(loan);
            cout<<loan;
        }
        if(option == 2)
        {
            depositmoney(money);
            final_money += money;
            getch();

        }
        if(option == 3)
        {
            withdrawmoney(money_withdraw);
            final_money -= money_withdraw;
            cout<<final_money;
            getch();
        }
        if(option == 4)
        {
            deduct_zakat(zakat_money,final_money);
            getch();
        }
        if(option == 5)
        {
            total_money(final_money);
            getch();
        }
        else if(option == 6)
        {
            cout<<"invalid option."<<endl;
        }
    }
}

int menu()
{
    int option;
    cout<<"1.Get loan."<<endl;
    cout<<"2.deposit money."<<endl;
    cout<<"3.Withdraw money."<<endl;
    cout<<"4.Deduct zakat."<<endl;
    cout<<"5.Total money."<<endl;
    cout<<"6.Exit."<<endl<<endl;
    cout<<"Enter your option: ";
    cin>>option;
    return option;
}

void getloan(int &loan)
{
    cout<<"how much loan you want: ";
    cin>>loan;
}

void depositmoney(int &money)
{
    cout<<"How much money you want to deposit.";
    cin>>money;
}

void withdrawmoney(int &money_withdraw)
{
    cout<<"Enter the money you want to withdraw.";
    cin>>money_withdraw;
}

void deduct_zakat(int &zakat_money,int final_money)
{
    zakat_money = (final_money*(2.5/100));
    cout<<"the deducted zakat is: "<<zakat_money<<endl;
}
void total_money(int final_money)
{
    cout<<"total amount of money in ypur account is; ";
    cout<<final_money<<endl;
}