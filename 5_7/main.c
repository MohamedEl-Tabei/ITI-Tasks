#include <stdio.h>
#include <stdlib.h>
struct Employee{
int age;
char name[20];
int salary;
};
int main()
{

    struct Employee *empP;
    struct Employee emp;
    empP=&emp;
    empP->age=20;
    strcpy(empP->name,"Mohamed");
    empP->salary=1000;

    printf("%i\n",empP->age);
    printf("%s\n",empP->name);
    printf("%i\n",empP->salary);
    return 0;
}
//7- pointer to struct of employee   ->

