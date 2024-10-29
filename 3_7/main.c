#include <stdio.h>
#include <stdlib.h>

int main()
{
    //bonus 3*3  *   3*2  = 3*2

    int matrix1[3][3]=
    {
        {
            1,3,3
        },
        {
            1,2,4
        },
        {
            1,2,3
        }
    };
    int matrix2[3][2]=
    {
        {
            1,2
        },
        {
            1,2
        },
        {
            1,2
        }
    };
    int result[3][2]={{0}};
    for(int r1=0;r1<3;r1++){
        for(int c1=0;c1<3;c1++)
        {
            for(int c2=0;c2<2;c2++){
                result[r1][c2]=result[r1][c2]+(matrix1[r1][c1]*matrix2[c1][c2]);
            }

        }

    }
    for(int r=0;r<3;r++){
        for(int c=0;c<2;c++)
        {
            printf("%i  ",result[r][c]);
        }
        printf("\n");
    }
    return 0;
}
