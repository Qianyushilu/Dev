#include<iostream>
using namespace std;
int main ()
{
    /*int Month=0;
    cout << "�������·ݣ�1-12����" << endl;
    cin >> Month;
    if (Month>=3&&Month<=5)
    {
        cout<< "��ǰ�Ǵ���"<<endl;
    }
    else if (Month>=6&&Month<=8)
    {
        cout << "��ǰ������"<<endl;
    }
    else if (Month>=9&&Month<=11)
    {
        cout << "��ǰ������"<<endl;
    }
    else if (Month==12||Month==1||Month==2)
    {
        cout << "��ǰ�Ƕ���"<<endl;
    }
    else
    {
        cout << "�������!������1-12"<<endl;

    }
    return 0; */
    
    double a,b,c,d,n;
    cout << "������a��" <<endl;
    cin >> a ;
    cout << "������b��" <<endl;
    cin >> b;
    cout << "������c��" <<endl;
    cin >> c;
    cout << "������d��" <<endl;
    cin >> d;
    if(a>b) n=a;
    if(c>n) n=c;
    if (d>n) n>c;
    cout << n << endl;
    return 0;
    

}
