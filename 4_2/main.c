#include <stdio.h>
#include <stdlib.h>
#define SIZE 20
int main()
{
    //read string from user then print it reversely
    char ch;
    char str[SIZE];
    int lastIndex=-1;
    int index=0;
    printf("Enter Statement : \n");
    do{
        ch=getche();
        lastIndex++;
        str[index]=ch;
        index++;
    }while(ch!=13);

    printf("\nStatement Reverse : \n");

    for(int i=lastIndex;i>=0;i--)
        printf("%c",str[i]);



    return 0;
}
