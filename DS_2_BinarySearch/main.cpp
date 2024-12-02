#include <iostream>

using namespace std;
void selectionSort(int *arr,int _size)
{
    int mini=0;
    int temp;
    for(int i=0; i<_size-1; i++)
    {
        for(int j=i+1; j<_size; j++)
        {
            if(arr[mini]>arr[j])
            {
                mini=j;
            }
        }
        if(arr[mini]<arr[i])
        {
            temp=arr[mini];
            arr[mini]=arr[i];
            arr[i]=temp;
        }
    }

}
int binarySearch(int *arr,int _size,int element)
{
    selectionSort(arr,_size);
    int left=0;
    int right=_size-1;
    int mid;
    while(left<=right)
    {
        mid=left+(right-left)/2;

        if(arr[mid]==element)
            return mid;
        if(element<arr[mid])
        {
            right=mid-1;
        }
        else
        {
            left=mid+1;
        }
    }
    return-1;



}
int main()
{
    int arr[6]= {5,-9,-10,3,7,2};


    cout <<  binarySearch(arr,6,5) << endl;

    for(int i=0; i<6; i++)
        cout<<i<<" -> "<<arr[i]<<endl;
    return 0;
}
