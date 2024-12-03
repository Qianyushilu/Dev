#include<iostream>
using namespace std;
int main(){
    int xueyuan=8;
    int year=2006;
    while(xueyuan<=99){
        xueyuan*=1.25;
        year++;
        cout<<xueyuan<<" "<<year<<endl;
    }
    cout << year << endl;
}
