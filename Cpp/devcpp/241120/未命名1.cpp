#include<iostream>
using namespace std;
int main ()
{
    /*int Month=0;
    cout << "请输入月份（1-12）：" << endl;
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
        cout << "当前是秋天"<<endl;
    }
    else if (Month==12||Month==1||Month==2)
    {
        cout << "当前是冬天"<<endl;
    }
    else
    {
        cout << "输入错误!请输入1-12"<<endl;

    }
    return 0; */
    
    double a,b,c,d,n;
    cout << "请输入a：" <<endl;
    cin >> a ;
    cout << "请输入b：" <<endl;
    cin >> b;
    cout << "请输入c：" <<endl;
    cin >> c;
    cout << "请输入d：" <<endl;
    cin >> d;
    if(a>b) n=a;
    if(c>n) n=c;
    if (d>n) n>c;
    cout << n << endl;
    return 0;
    

}
