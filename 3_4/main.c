#include <stdio.h>
#include <stdlib.h>

int main()
{
    //search in array

    int arr[11]={1,2,3,4,1,5,6,2,1,9,10};
    int indexes[3]={-1,-1,-1};
    int number;
    int count=0;
    for(int i=0;i<11;i++)
    {
        printf("Enter Number in index [%i]: ",i);
        scanf("%i",&arr[i]);
    }
    printf("Search a number: ");
    scanf("%i",&number);
    for(int i=0;i<11;i++){
        if(arr[i]==number)
        {
            indexes[count]=i;
            count++;
        }
    }
    for(int i=0;i<3;i++)
        if(indexes[i]>=0)printf("Number %i is in index %i \n",number,indexes[i]);
    return 0;
}
