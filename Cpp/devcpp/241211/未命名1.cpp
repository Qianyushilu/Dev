#include<iostream>
using namespace std;
int main(){
    /*
	int num[]{5,8,12,3,6};
    int size = sizeof(num)/sizeof(int);
    int max{0},min{0};
    for(int i=0;i<size;i++){
        if(num[i]>=num[max]){
            max=i;
        }
        if(num[i]<=num[min]){
            min=i;
        }
    }
    cout << min << " " << max << endl;
    swap(num[0],num[max]);
    swap(num[size-1],num[min]);
    for(int j=0;j<size;j++){
	    cout << num[j] << ",";
    }
    */
    int arr[]{19,16,10,8,5};
    int size=sizeof(arr)/sizeof(arr[0]);
    int num=0;
    for(int i=0;i<size;i++){
    	cout << arr[i] << " ";
	}
	cout << "ÇëÊäÈëÊý×Ö£º" << endl; 
    cin >> num;

}
