#include <stdio.h>
#include <stdlib.h>

int main()
{
    //1- pointer to integer  read & write
    int number;
    int *numberPtr;
    numberPtr=&number;
    printf("Enter Number: ");
    scanf("%i",numberPtr);
    printf("The number is %i",*numberPtr);

    return 0;
}


