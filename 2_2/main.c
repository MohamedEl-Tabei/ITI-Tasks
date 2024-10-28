#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
void gotoxy( int column, int row )
{
    COORD coord;
    coord.X = column;
    coord.Y = row;
    SetConsoleCursorPosition(GetStdHandle( STD_OUTPUT_HANDLE ),coord);
}
int main()
{

    //magic box
    int size;
    int col;
    int row;
    int preNumber;
    //initial values

    do
    {
        system("cls");
        printf("Enter Size: ");
        scanf("%i",&size);

    }
    while(size%2==0||size==1);
    col=(size/2)+1;
    row=1;
    /////// magic box implementation //////////
    for(int i=1;i<=size*size;i++)
    {
        if(i!=1&&preNumber%size!=0)
        {
            col=col-1;
            row=row-1;
            if(col==0) col=size;
            if(row==0) row=size;
        }else if(i!=1) row=row+1;

        gotoxy(col*3,row*3);
        preNumber=i;
        printf("%i",i);
    }

    return 0;
}
