#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

#define SIZE 7
#define MENUSIZE 8

#define BGGREEN 32
#define COLORGREEN 10
#define COLORWHITE 7
#define COLORRED 4

#define UP 72
#define DOWN 80
#define LEFT 75
#define RIGHT 77
#define TAB 9
#define HOME 71
#define END 79
#define ESC 27
#define SPACE 32
struct Employee
{
    int ssn;
    char name[15];
    int age ;
    int salary;
    int commission ;
    int deduction;
};
int isHover(int cursor,int index)
{
    return cursor==index;
}
int cursorIncrement(int cursor)
{
    cursor=cursor+1;
    if(cursor==MENUSIZE)
    {
        cursor=1;
    }
    return cursor;
}
int cursorDecrement(int cursor)
{
    cursor=cursor-1;
    if(cursor==0)
    {
        cursor=MENUSIZE-1;
    }
    return cursor;
}
int getAsci()
{
    char ch;
    ch=getch();
    switch(ch)
    {
    case -32:
        ch=getch();
        return ch;
    default:
        return ch;

    }

}
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
    //Array of 10 Employees with highlighted menu
    char menu[MENUSIZE][20]= {" Home ","New","Display All","Display By SSN","Display By Name","Delete By Name","Delete All","Exit"};
    char labels[SIZE][15]= {"SSN", "Name","Age","Salary","Commission","Deduction","Net Salary"};
    char addMore='n';
    int cursor=1;
    int index=-1;
    int netSalary;
    int asci=1;
    int ssnIsUsed=0;
    char searchAgain;
    struct Employee emp;
    struct Employee employees[10];
    for(int employeeNum=0; employeeNum<10; employeeNum++) //set ssn to -1
    {
        employees[employeeNum].ssn=-1;
    }


    do
    {
        system("cls");
        for(int pageNum=0; pageNum<MENUSIZE; pageNum++)
        {
            gotoxy(50,pageNum+6);
            if(pageNum==0)
            {
                gotoxy(58,pageNum+5);
                textattr(32);
            }
            else if(cursor==pageNum)
            {
                textattr(10);
            }
            else
            {
                textattr(7);
            }
            printf("%s",menu[pageNum]);
        }
        asci=getAsci();
        switch(asci) //to move in menu
        {
        case RIGHT:
        case TAB:
        case SPACE:
        case DOWN:
            cursor=cursorIncrement(cursor);
            break;
        case LEFT:
        case UP:
            cursor=cursorDecrement(cursor);
            break;
        default:
            break;

        }
        if(asci==13) //if press Enter
        {
            switch(cursor)
            {
            case 1: //New
                do
                {

                    do
                    {
                        system("cls");
                        gotoxy(58,0);
                        textattr(BGGREEN);
                        printf(" Add New Employee ");
                        gotoxy(0,1);
                        ssnIsUsed=0;
                        textattr(COLORWHITE);
                        printf("Enter Employee Index: ");
                        _flushall();
                        scanf("%i",&index);
                        _flushall();
                    }
                    while(employees[index].ssn!=-1);
                    for(int labelNum=0; labelNum<SIZE; labelNum++)
                    {
                        if(labelNum%2==0)
                        {
                            gotoxy(20,3+labelNum);
                            printf("%s: ",labels[labelNum]);
                            switch(labelNum)
                            {
                            case 0:
                                do
                                {

                                    gotoxy(20,3+labelNum);
                                    printf("%s: ",labels[labelNum]);
                                    textattr(7);
                                    scanf("%i",&employees[index].ssn);

                                    for(int i=0; i<index; i++)
                                    {
                                        if(employees[index].ssn==employees[i].ssn)
                                        {
                                            textattr(4);
                                            ssnIsUsed=1;
                                            break;
                                        }
                                        else
                                        {
                                            gotoxy(20,3+labelNum);
                                            printf("%s: ",labels[labelNum]);
                                            textattr(7);
                                            ssnIsUsed=0;
                                        }
                                    }
                                }
                                while(ssnIsUsed!=0);
                                break;
                            case 2:
                                scanf("%i",&employees[index].age);
                                break;
                            case 4:
                                scanf("%i",&employees[index].commission);
                                break;
                            case 6:
                                netSalary=employees[index].salary+employees[index].commission-employees[index].deduction;
                                printf("%i",netSalary);
                                break;
                            }
                        }
                        else
                        {
                            gotoxy(50,3+labelNum-1);
                            printf("%s: ",labels[labelNum]);
                            switch(labelNum)
                            {
                            case 1:
                                _flushall();
                                scanf("%s",employees[index].name);
                                _flushall();
                                break;
                            case 3:
                                scanf("%i",&employees[index].salary);
                                break;
                            case 5:
                                scanf("%i",&employees[index].deduction);
                                break;

                            }

                        }
                    }
                    _flushall();
                    printf("\n\nDo you want enter new employee number (y/n)? ");
                    scanf("%c",&addMore);
                    if(index==10)
                        addMore='n';

                }
                while(addMore!='n');
                break;
            case 2: //Display All
                system("cls");
                gotoxy(58,0);
                textattr(BGGREEN);
                printf(" Display All ");
                textattr(COLORGREEN);

                for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
                {
                    gotoxy((labelNum*16),2);
                    printf("%s",labels[labelNum]);

                }
                textattr(COLORWHITE);

                for(int employeeNum=0; employeeNum<10; employeeNum++)//table of employees
                {
                    if(employees[employeeNum].ssn>0)
                    {
                        for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
                        {
                            gotoxy((labelNum*16),4+employeeNum);
                            switch(labelNum)
                            {
                            case 0:
                                printf("%i",employees[employeeNum].ssn);
                                break;
                            case 2:
                                printf("%i",employees[employeeNum].age);
                                break;
                            case 4:
                                printf("%i",employees[employeeNum].commission);
                                break;
                            case 6:
                                netSalary=employees[employeeNum].salary+employees[employeeNum].commission-employees[employeeNum].deduction;
                                printf("%i",netSalary);
                                break;
                            case 1:
                                printf("%s",employees[employeeNum].name);
                                break;
                            case 3:
                                printf("%i",employees[employeeNum].salary);
                                break;
                            case 5:
                                printf("%i",employees[employeeNum].deduction);
                                break;


                            }

                        }
                    }
                }
                textattr(COLORGREEN);
                printf("\n\nTo go home press any key");
                asci=getAsci();
                if(asci==ESC)
                    asci=0;
                break;
            case 3: //Display By SSN
                do
                {
                    emp.salary=-1;
                    system("cls");
                    gotoxy(58,0);
                    textattr(BGGREEN);
                    printf(" Display BY SSN ");
                    textattr(COLORWHITE);
                    gotoxy(0,2);
                    printf("\nEnter SSN: ");
                    scanf("%i",&emp.ssn);
                    for(int i=0; i<10; i++)
                    {

                        if(employees[i].ssn==emp.ssn)
                        {
                            emp.age=employees[i].age;
                            emp.commission=employees[i].commission;
                            emp.deduction=employees[i].deduction;
                            strcpy(emp.name,employees[i].name);
                            emp.salary=employees[i].salary;
                        }
                    }
                    for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
                    {
                        textattr(COLORGREEN);
                        gotoxy((labelNum*16),4);
                        printf("%s",labels[labelNum]);
                        textattr(COLORWHITE);

                        gotoxy((labelNum*16),6);


                        if(emp.salary!=-1)
                        {

                            switch(labelNum)
                            {
                            case 0:
                                printf("%i",emp.ssn);
                                break;
                            case 2:
                                printf("%i",emp.age);
                                break;
                            case 4:
                                printf("%i",emp.commission);
                                break;
                            case 6:
                                netSalary=emp.salary+emp.commission-emp.deduction;
                                printf("%i",netSalary);
                                break;
                            case 1:
                                printf("%s",emp.name);
                                break;
                            case 3:
                                printf("%i",emp.salary);
                                break;
                            case 5:
                                printf("%i",emp.deduction);
                                break;
                            }
                        }


                    }
                    if(emp.salary==-1)
                    {
                        gotoxy(0,8);
                        textattr(COLORRED);
                        printf("There is no employee with ssn %i",emp.ssn);
                    }
                    gotoxy(0,10);
                    textattr(COLORGREEN);
                    _flushall();
                    printf("\n\nDo you want display another employee (y/n)? ");
                    scanf("%c",&searchAgain);
                    _flushall();


                }
                while(searchAgain!='n');
                _flushall();
                break;
            case 4: //Display By Name
                do
                {
                    emp.salary=-1;
                    emp.ssn=-1;
                    strcpy(emp.name,"");
                    system("cls");
                    gotoxy(58,0);
                    textattr(BGGREEN);
                    printf(" Display BY Name ");
                    textattr(COLORWHITE);
                    gotoxy(0,2);
                    printf("\nEnter Name: ");
                    scanf("%s",emp.name);
                    for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
                    {
                        textattr(COLORGREEN);
                        gotoxy((labelNum*16),4);
                        printf("%s",labels[labelNum]);
                    }
                    int j=0;
                    for(int i=0; i<10; i++)
                    {
                        if(strcmpi(emp.name,employees[i].name)==0)
                        {
                            emp.ssn=employees[i].ssn;
                            for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
                            {
                                textattr(COLORWHITE);

                                gotoxy((labelNum*16),6+j);
                                switch(labelNum)
                                {
                                case 0:
                                    printf("%i",employees[i].ssn);
                                    break;
                                case 2:
                                    printf("%i",employees[i].age);
                                    break;
                                case 4:
                                    printf("%i",employees[i].commission);
                                    break;
                                case 6:
                                    netSalary=employees[i].salary+employees[i].commission-employees[i].deduction;;
                                    printf("%i",netSalary);
                                    break;
                                case 1:
                                    printf("%s",employees[i].name);
                                    break;
                                case 3:
                                    printf("%i",employees[i].salary);
                                    break;
                                case 5:
                                    printf("%i",employees[i].deduction);
                                    break;
                                }
                            }
                            j++;
                        }
                    }

                    if(emp.ssn==-1)
                    {
                        gotoxy(0,8);
                        textattr(COLORRED);
                        printf("There is no employee with name %s",emp.name);
                    }
                    gotoxy(0,10);
                    textattr(COLORGREEN);
                    _flushall();
                    printf("\n\nDo you want display another employee (y/n)? ");
                    scanf("%c",&searchAgain);
                    _flushall();
                }
                while(searchAgain!='n');
                _flushall();
                break;
            case 5: //Delete By Name
                do
                {
                    emp.salary=-1;
                    emp.ssn=-1;
                    strcpy(emp.name,"");
                    system("cls");
                    gotoxy(58,0);
                    textattr(BGGREEN);
                    printf(" Delete BY Name ");
                    textattr(COLORWHITE);
                    gotoxy(0,2);
                    printf("\nEnter Name: ");
                    scanf("%s",emp.name);
                    for(int i=0; i<10; i++)
                    {
                        if(strcmpi(emp.name,employees[i].name)==0)
                        {
                            emp.ssn=employees[i].ssn;
                            textattr(COLORRED);
                            printf("%s whose ssn is %i is deleted\n",emp.name,emp.ssn);
                            strcpy(employees[i].name,"");
                            employees[i].age=-1;
                            employees[i].commission=-1;
                            employees[i].deduction=-1;
                            employees[i].ssn=-1;
                            employees[i].salary=-1;


                        }
                    }

                    if(emp.ssn==-1)
                    {
                        gotoxy(0,8);
                        textattr(COLORRED);
                        printf("There is no employee with name %s",emp.name);
                    }
                    gotoxy(0,10);
                    textattr(COLORGREEN);
                    _flushall();
                    printf("\n\nDo you want delete another employees (y/n)? ");
                    scanf("%c",&searchAgain);
                    _flushall();
                }
                while(searchAgain!='n');
                _flushall();
                break;
            case 6: //Delete All
                system("cls");
                for(int i=0; i<10; i++)
                {

                    if( employees[i].ssn!=-1)
                    {
                        textattr(COLORRED);
                        printf("%s whose ssn is %i is deleted\n", employees[i].name, employees[i].ssn);
                        strcpy(employees[i].name,"");
                        employees[i].age=-1;
                        employees[i].commission=-1;
                        employees[i].deduction=-1;
                        employees[i].ssn=-1;
                        employees[i].salary=-1;
                    }



                }
                textattr(COLORGREEN);
                printf("\n\nTo go home press any key");
                asci=getAsci();
                if(asci==ESC)
                    asci=0;
                textattr(COLORWHITE);
                break;
            case 7: //Exit
                asci=ESC;
                break;
            default:
                break;
            }
        }
    }
    while(asci!=ESC);







    printf("\n\n\n");
    return 0;
}

