#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
    //1- read first name , last name print full name
    char firstName[15];
    char lastName[15];
    char fullName[32];

    printf("Enter First Name: ");
    scanf("%s",firstName);
    printf("Enter Last Name: ");
    scanf("%s",lastName);
    strcpy(fullName,firstName);
    strcat(fullName," ");
    strcat(fullName, lastName);
    printf("Your name is %s",fullName);
    return 0;
}
