#include <stdio.h>
#include <stdlib.h>
void displayArray(int *ptr,int size)
{
    for(int i=0; i<size; i++)
    {

        printf("%i\n",ptr[i]);
    }

}
int main()
{
    int arr[3]={1,2,3};
    displayArray(arr,3);
    return 0;
}
//5- pass array as input param []   ,pass pointer
