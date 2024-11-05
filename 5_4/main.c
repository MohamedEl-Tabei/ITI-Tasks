#include <stdio.h>
#include <stdlib.h>
void swap(int *x,int*y){
    int temp;

    temp =*x;
    *x=*y;
    *y=temp;

}
int main()
{
    int x=5;
    int y=9;
    printf("Before x=%i & y=%i \n",x,y);
    swap(&x,&y);
    printf("Before x=%i & y=%i \n",x,y);
    return 0;
}
//4- pass by value/address    swap
