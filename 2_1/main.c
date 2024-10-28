#include <stdio.h>
#include <stdlib.h>
int daysForTheMonth(int m,int y)
{

    if(m==4||m==6||m==9||m==11)
    {
        return 30;
    }
    else
    {
        if(m==2)
        {
            if((y%4==0&&y%100!=0)||y%400==0)
                return 28;
            else
                return 29;
        }
        else
        {
            return 31;
        }
    }
}

int main()
{
    // Birthday
    int currentYear=2024;
    int currentMonth=10;
    int currentDay=28;
    int maxNumberOfDay;
    int month;
    int year;
    int day;
    do
    {
        system("cls");
        printf("Enter year: ");
        scanf("%i",&year);
    }
    while(year<1980||year>currentYear);

    do
    {
        system("cls");
        printf("Year: %i \n",year);
        printf("Enter month: ");
        scanf("%i",&month);
    }
    while(month>12||month<1||(year==currentYear&&month>currentMonth));
    maxNumberOfDay=daysForTheMonth(month,year);
    do
    {
        system("cls");
        printf("Year: %i \n",year);
        printf("Month: %i \n",month);
        printf("Enter day: ");
        scanf("%i",&day);
    }
    while(day>maxNumberOfDay||day<0||(month==currentMonth&&year==currentYear&&day>currentDay));
    year=currentYear-year;
    month=currentMonth-month;
    if(month<0)
    {
        year=year-1;
        month=month+12;
    }
    day=currentDay-day;
    if(day<0)
    {
        day=day+daysForTheMonth(currentMonth,currentYear);
        month=month-1;

    }
    printf("Your Age: %iY %iM %iD",year,month,day);
    return 0;
}
