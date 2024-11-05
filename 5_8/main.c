#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

#define SIZEOFSTR 30

#define SPACE 32
#define RIGHT 77
#define LEFT 75
#define BACKSPACE 8
#define DELETE 83
#define HOME 71
#define END 79
#define ESC 27

//8- Line Editor
void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}
void gotoxy( int column, int row )
{
    COORD coord;
    coord.X = column;
    coord.Y = row;
    SetConsoleCursorPosition(GetStdHandle( STD_OUTPUT_HANDLE ),coord);
}
int main()
{
    char str[SIZEOFSTR];
    char *pCurrent,*pFirst,*pLast;
    int current,first,last;
    char ch;

    int flag;
    //initialization
    flag=0;
    current=20;
    first=20;
    last=20;
    pCurrent=str;
    pFirst=str;
    pLast=str;
    //change background
    for(int i=0; i<SIZEOFSTR; i++)
    {
        str[i]='_';
        gotoxy(current+i,10);
        textattr(10);
        printf("%c",str[i]);

    }
    do
    {
        ch=getch();
        if(ch==-32) //extended
        {
            ch=getch();
            switch(ch)
            {
            case LEFT:
                if(current!=first)
                {
                    current--;
                    pCurrent--;
                    gotoxy(current,10);

                }

                break;
            case RIGHT:
                if(pCurrent<(pFirst+SIZEOFSTR-2))
                {

                    if(current==last)
                    {
                        last++;
                        pLast++;
                    }
                    pCurrent++;
                    current++;
                    gotoxy(current,10);
                }
                else
                {
                    current=last;
                }
                break;
            case DELETE:
                if(current!=first)
                {
                    gotoxy(current+1,10);
                    *(pCurrent+1)='_';
                    printf("%c",*(pCurrent+1));


                }

                break;
            case HOME:
                current=first;
                pCurrent=pFirst;
                gotoxy(current,10);
                break;
            default:
                break;
            }
        }
        else if(ch==13||ch==ESC)
        {
            flag=1;
        }
        else// normal
        {

            if(ch==BACKSPACE)
            {

                if(pLast==pCurrent)
                {
                    pLast--;
                    last--;
                }
                if(current!=first)
                {
                    current--;
                    pCurrent--;
                    gotoxy(current,10);

                }

                *pCurrent='_';
                printf("%c",*pCurrent);

            }
            else
            {
                *pCurrent=ch;
                gotoxy(current,10);

                printf("%c",*pCurrent);
                if(pCurrent<(pFirst+SIZEOFSTR-2))
                {

                    if(current==last)
                    {
                        last++;
                        pLast++;
                    }
                    pCurrent++;
                    current++;
                    gotoxy(current,10);
                }
                else
                {
                    current=last;
                }
            }


        }

    }
    while(flag==0);
    *pLast='\0';
    textattr(7);
    gotoxy(3,13);
    printf("%s",pFirst);

    return 0;
}
