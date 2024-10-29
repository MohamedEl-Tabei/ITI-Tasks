#include <stdio.h>
#include <stdlib.h>

int main()
{
    //min & max
    int max;
    int min;
    int arr[9]={7,3,5,6,8,-1,-11,33,99};
    max=arr[0];
    min=arr[0];
    for(int i=0;i<9;i++){
        printf("Enter Number for index[%i]: ",i);
        scanf("%i",&arr[i]);
    }
    for(int i=1;i<9;i++){
        if(max<arr[i]) max=arr[i];
        if(min>arr[i]) min=arr[i];
    }

    printf("Max=%i  &&  Min=%i",max,min);
    return 0;
}
