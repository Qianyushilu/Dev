#include<iostream>
using namespace std;
int main ()
{
    int Month{0};
    cin >> Month;
    if (Month>=3&&Month<=5)
    {
        cout<< "当前是春天"<<endl;
    }
    else if (Month>=6&&Month<=8)
    {
        cout << "当前是夏天"<<endl;
    }
    else if (Month>=9&&Month<=11)
    {
        cout << "当前是夏天"<<endl;
    }
    else if (Month==12||Month==1||Month==2)
    {
        cout << "当前是冬天"<<endl;
    }
    else
    {
        cout << "输入错误！请输入1-12"<<endl;

    }

 

}