#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#define SIZE 4
int isHover(int cursor,int index)
{
    return cursor==index;
}
int moveCursor(int cursor)
{
    char ch;
    ch=getch();
    switch(ch)
    {
    case -32:
        ch=getch();

        //switch for arrows
        switch(ch)
        {
        case 80: //down
            if(cursor>=SIZE-1)
                cursor=0;
            else
                cursor++;
            return cursor;
            break;
        case 72://up
            if(cursor<=0)
                cursor=SIZE-1;
            else
                cursor--;
            return cursor;
            break;


        }
    case 9:
        if(cursor>=SIZE-1)
            cursor=0;
        else
            cursor++;
        return cursor;
        break;
    case 27:
        return-1;
    case 13:
        switch(cursor)
        {
        case 0:
            system("cls");
            printf("This is file");
            return-1;
            break;
        case 1:
            system("cls");
            printf("This is new");
            return-1;
            break;
        case 2:
            system("cls");
            printf("This is display");
            return-1;
            break;
        default:
            return -1;
        }
        break;
    //End
    default:
        return cursor;



    }
}
void gotoxy( int column, int row )
{
    COORD coord;
    coord.X = column;
    coord.Y = row;
    SetConsoleCursorPosition(GetStdHandle( STD_OUTPUT_HANDLE ),coord);
}
void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}
int main()
{
    //Highlighted menu
    char menu[SIZE][10]= {"File","New","Display","Exit"};
    int yArray[SIZE];
    int cursor=0;
    int flag=0;

    do
    {
        system("cls");
        for(int i=0; i<SIZE; i++)//print menu and get y
        {
            if(isHover(cursor,i))
                textattr(4);
            else
                textattr(7);
            gotoxy(55,(i+5));
            yArray[i]=(i+5);
            printf("%s",menu[i]);
        }
        cursor=moveCursor(cursor);
        if(cursor<0)
            return 1;
    }
    while(flag==0);

    return 0;
}
