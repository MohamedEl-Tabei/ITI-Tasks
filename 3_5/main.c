#include <stdio.h>
#include <stdlib.h>

int main()
{
    //avg of column
    int arr[3][4]=
    {
        {
            1,2,3,4
        },
        {
            6,2,3,4
        },
        {
            1,2,3,4
        }
    };
    int avgs[4]={0};
    for(int c=0;c<4;c++){
        for(int r=0;r<3;r++){
            avgs[c]=avgs[c]+arr[r][c];
        }
    }
    for(int i=0 ;i<4;i++){
        avgs[i]=avgs[i]/4;
        printf("%i \n",avgs[i]);
    }
    return 0;
}
