#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#define SIZE 6
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

struct Employee
{
    int ssn;
    char name[15];
    int age ;
    int salary;
    int commission ;
    int deduction;
};
int main()
{
    //Employee
    //ssn name age salary commission deduction
    //netSalary
    char labels[SIZE][15]= {"SSN", "Name","Age","Salary","Commission","Deduction"};
    char addMore='n';
    int cursor=0;
    int index=0;
    int netSalary;
    int asci;
    int ssnIsUsed=0;
    struct Employee employees[3];
    for(int employeeNum=0; employeeNum<3; employeeNum++) //set ssn to -1
    {
        employees[employeeNum].ssn=-1;
    }
    do
    {
        system("cls");
        ssnIsUsed=0;
        printf("Enter Employee Number %i Data \n\n",index);
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
        index=index+1;
        netSalary=employees[index-1].salary+employees[index-1].commission-employees[index-1].deduction;
        printf("\n\n\n%s's net salary is %i\n\n",employees[index-1].name,netSalary);
        printf("Do you want enter employee number %i ? ",index);
        scanf("%c",&addMore);
        if(index==3)
            addMore='n';

    }
    while(addMore!='n');
    system("cls");
    for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
    {
        gotoxy((labelNum*20),0);
        printf("%s",labels[labelNum]);

    }
    for(int employeeNum=0; employeeNum<3; employeeNum++)//table of employees
    {
        if(employees[employeeNum].ssn>0)
        {
            for(int labelNum=0; labelNum<SIZE; labelNum++)//labels of table of employees
            {
                gotoxy((labelNum*20),2+employeeNum);
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
    printf("\n\n\n");
    return 0;
}
