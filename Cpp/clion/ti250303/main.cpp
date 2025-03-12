#include<bits/stdc++.h>
using namespace std;
int main() {
    int L,x=0;
    cin >> L;
    for (int i=2;i<=L;i++) {
        for (int j=2;j<i;j++) {
            if (i%j==0) {
                break;;
            }
            else{
                cout << i << endl;
                x++;
                break;
            }
        }
    }
    cout<< x;
}