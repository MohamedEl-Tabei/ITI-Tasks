#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

#define SPACE 32
#define RIGHT 77
#define LEFT 75
#define UP 72
#define DOWN 80
#define BACKSPACE 8
#define DELETE 83
#define HOME 71
#define END 79
#define ESC 27
//4- one employee with line editor

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
char getAsci(char _ch)
{
    _ch=getch();
    if(_ch==-32)
    {
        _ch=getch();
    }
    return _ch;

}
char* lineEditor(int _size,int x,int y,int startKey,int endKey)
{
    _size++;
    char ch;
    //counters
    int first,current,last;

    //pointers
    char *firstPtr,*currentPtr,*lastPtr;

    //string
    char *arr;
    arr=malloc(_size);

    //condition
    int flag=0;
    //initialization
    first=current=last=x;

    firstPtr=arr;
    currentPtr=arr;
    lastPtr=arr;

    for(int i=0; i<_size; i++)
    {
        gotoxy(current+i,y);
        textattr(10);
        printf("_");
    }
    do
    {
        gotoxy(current,y);
        ch=getAsci(ch);
        switch(ch)
        {
        case LEFT:
            if(first!=current)
            {
                current--;
                currentPtr--;

            }
            break;
        case RIGHT:
            if(currentPtr<(firstPtr+_size-2))
            {
                if(current==last)
                {
                    last++;
                    lastPtr++;
                }
                current++;
                currentPtr++;
            }
            break;
        case 13:
            flag=1;
            break;
        default:
            if((int)ch<=endKey&&(int)ch>=startKey)
            {
                printf("%c",ch);
                *currentPtr=ch;
                if(currentPtr<(firstPtr+_size-2))
                {
                    if(current==last)
                    {
                        last++;
                        lastPtr++;
                    }
                    current++;
                    currentPtr++;
                }
            }
            break;

        }

    }
    while(flag==0);
    lastPtr++;
    *lastPtr='\0';
    //gotoxy(0,15);

    //printf("%s",arr);
    textattr(7);

    return firstPtr;
}
struct Employee
{
    int ssn;
    char *name[10];
    int age;
    int salary;
    int commission;
    int deduction;
};
int main()
{
    void *ptrLiner;
    //Numbers 48-57
    //Upper 65-90
    char* labels[7]= {"SSN", "Name", "Age","Salary","Commission","Deduction","Net salary"};
    int colX,rowY;
    struct Employee emp;
    //
    //
    printf(" Enter New Employee ");
    //
    rowY=5;
    colX=20;
    ////////////////////////

    ///////////////////
    gotoxy(colX,rowY);
    printf("%s: ",labels[0]);

    ptrLiner=lineEditor(3,colX+12,rowY,48,57);
    emp.ssn=atoi(ptrLiner);
    free(ptrLiner);
    for(int i=1; i<7; i++)
    {
        if(i%2==0)
        {
            rowY=rowY+1;
            colX=20;
            gotoxy(colX,rowY);
            printf("%s: ",labels[i]);
        }
        else
        {

            colX=70;
            gotoxy(colX,rowY);
            printf("%s: ",labels[i]);
        }
        switch(i)
        {
        //{"SSN", "Name", "Age","Salary","Commission","Deduction","Net salary"};
        case 1:
            ptrLiner=lineEditor(10,colX+12,rowY,65,90);
            strcpy(emp.name,ptrLiner);
            free(ptrLiner);
            break;
        case 2:
            ptrLiner=lineEditor(3,colX+12,rowY,48,57);
            emp.age=atoi(ptrLiner);
            free(ptrLiner);
            break;
        case 3:
            ptrLiner=lineEditor(3,colX+12,rowY,48,57);
            emp.salary=atoi(ptrLiner);
            free(ptrLiner);
            break;
        case 4:
            ptrLiner=lineEditor(3,colX+12,rowY,48,57);
            emp.commission=atoi(ptrLiner);
            free(ptrLiner);
            break;
        case 5:
            ptrLiner=lineEditor(3,colX+12,rowY,48,57);
            emp.deduction=atoi(ptrLiner);
            free(ptrLiner);
            break;
        }
    }


    //gotoxy(colX[cursor]+12,rowY[cursor]);
    int netSalary=emp.salary+emp.commission-emp.deduction;
    printf("%i",netSalary);

    gotoxy(20,20);
    for(int i=0; i<7; i++)
    {
        textattr(10);
        gotoxy((i*15),20);
        printf("%s",labels[i]);
        textattr(7);
        switch(i)
        {
        //{"SSN", "Name", "Age","Salary","Commission","Deduction","Net salary"};
        case 0:
            gotoxy((i*15),21);
                        printf("%i",emp.ssn);

            break;
        case 1:
            gotoxy((i*15),21);
            printf("%s",emp.name);

            break;
        case 2:
            gotoxy((i*15),21);
            printf("%i",emp.age);

            break;
        case 3:
            gotoxy((i*15),21);
            printf("%i",emp.salary);

            break;
        case 4:
            gotoxy((i*15),21);
            printf("%i",emp.commission);

            break;
        case 5:
            gotoxy((i*15),21);
            printf("%i",emp.deduction);

            break;
        case 6:
            gotoxy((i*15),21);
            printf("%i",netSalary);

            break;
        }
    }

    return 0;
}
