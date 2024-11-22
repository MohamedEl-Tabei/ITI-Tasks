#include <stdio.h>
#include <stdlib.h>
#include<string.h>
void GetAlphabet(char *str,char ch)
{
    //1
    int size=strlen(str);
    int lastReplacement=0;
    int lastIndex;
    for(int i=0; i<size; i++)
    {
        //2
        if(str[i]==ch)
        {
            //3
            lastReplacement=lastReplacement+1;
        }//3
        else //4
        {
            str[i-lastReplacement]=str[i];
            lastIndex=(i-lastReplacement)+1;
        }//4
    }//2
    str[lastIndex]='\0';
    printf("%s",str);
}//1
int main()
{
    char str[]="***A**B***D";
    GetAlphabet(str,'*');
    return 0;
}
