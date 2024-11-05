#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num;
    int *nump;
    int **numpp;
    num=5;

    nump=&num;
    numpp=nump;

    printf("Number is %i",*numpp);
    return 0;
}
//3- pointer to pointer of integer Write ONLY
