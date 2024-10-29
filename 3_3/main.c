#include <stdio.h>
#include <stdlib.h>

int main()
{
    //sort array
    int arr[5]={-11,-1,3,5,6};
    for(int i=0;i<5;i++){
        printf("Enter Number for index [%i]: ",i);
        scanf("%i",&arr[i]);
    }
    int temp;
    for(int i=0;i<5;i++)
    {

        for(int j=i;j<5;j++)
        {
            if(arr[i]>arr[j])
            {
                temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }

        }
    }
    for(int i=0;i<5;i++)
    {
        printf("%i \n",arr[i]);
    }
    return 0;
}
