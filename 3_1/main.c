#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[10];
    for(int i=0;i<10;i++)
    {

        printf("Enter Number In [%i]: ",i);
        scanf("%i",&arr[i]);
    }
    for(int i=0;i<10;i++)
    {
        printf("|[%i]: %i| ",i,arr[i]);
    }
    return 0;
}
