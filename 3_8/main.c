#include <stdio.h>
#include <stdlib.h>
int main()
{
    // asciii for normal and extended

    char ch;
    do
    {
        ch=getch();
        switch(ch)
        {
        case -32:
            ch=getch();
            printf("Extended\n");
            break;
        default:
            printf("%c Is Normal\n",ch);
            break;

        }


    }
    while(ch!=13);
    return 0;
}
