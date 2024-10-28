#include <stdio.h>
#include <stdlib.h>

int main()
{
    //Calcolutor
    float num1;
    float num2;
    char operatr;
    float result;

    printf("Enter number1: ");
    scanf("%f",&num1);
    printf("Enter number2: ");
    scanf("%f",&num2);
    _flushall();
    printf("Enter operator: ");
    scanf("%c",&operatr);
    switch(operatr)
    {
    case '+':
        result=num1+num2;
        break;
    case '-':
        result=num1-num2;
        break;
    case '*':
        result=num1*num2;
        break;
    case '/':
        result=num1/num2;
        break;
    default:
        printf("invalid");
        return 0;
    }
    printf("%.1f %c %.1f = %.1f",num1,operatr,num2,result);
    return 0;
}
