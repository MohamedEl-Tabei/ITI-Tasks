#include <iostream>

using namespace std;

void insetionSorting(int *arr,int _size)
{
    int temp;
    int j=0;
    for(int i=0; i<_size; i++)
    {
        temp=arr[i];
        j=i-1;
        while(j>=0&&arr[j]>temp)//element before temp is greater
        {
            arr[j+1]=arr[j];//shift every element before it
            j=j-1;
        }//put temp in the  position
        arr[j+1]=temp;
    }
}
int main()
{
    int arr[5]= {8,-2,5,-7,4};
    insetionSorting(arr,5);
    for(int i=0; i<5; i++)
    {
        cout<<arr[i]<<endl;
    }
    return 0;
}
