#include <iostream>

using namespace std;
void merge_(int* arr,int left, int med,int right)
{
    int leftSize=med-left+1;
    int rightSize=right-med;

    int* leftArr=new int[leftSize];
    int* rightArr=new int[rightSize];

    int i,j,k;

    for(i=0; i<leftSize; i++)
        leftArr[i]=arr[left+i];

    for(j=0; j<rightSize; j++)
        rightArr[j]=arr[med+j+1];

    i=j=0;
    k=left;

    while(i<leftSize&&j<rightSize)
    {
        if(leftArr[i]<rightArr[j])
        {
            arr[k]=leftArr[i];
            i=i+1;
        }

        else
        {
            arr[k]=rightArr[j];
            j=j+1;
        }

        k=k+1;
    }
    while(i<leftSize)
    {
        arr[k]=leftArr[i];
        i=i+1;
        k=k+1;
    }
    while(j<rightSize)
    {
        arr[k]=rightArr[j];
        j=j+1;
        k=k+1;
    }
}

void mergeSort(int* arr,int left,int right)
{
    int med=left+(right-left)/2;
    if(left<right)
    {
        mergeSort(arr,left,med);
        mergeSort(arr,med+1,right);

        merge_(arr,left,med,right);
    }
}

int main()
{
    int arr[10]= {3,2,5,0,1,8,7,6,9,4};

    cout<<"Array before sorting"<<endl;
    for(int i=0; i<10; i++)
        cout<<arr[i]<<"\t";

    mergeSort(arr,0,9);

    cout<<endl<<endl<<"Array after sorting"<<endl;
    for(int i=0; i<10; i++)
        cout<<arr[i]<<"\t";


    return 0;
}
