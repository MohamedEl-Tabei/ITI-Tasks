#include <stdio.h>
#include <stdlib.h>

int main()
{
    //Multiply 2 matrix 3*2 * 2*1 =3*1

    int matrix1[3][2]=
    {
        {
            1,3
        },
        {
            1,2
        },
        {
            1,2
        }

    };
    int matrix2 [2][1]={{3},{3}};
    int result[3][1]={0};
    for(int r=0;r<3;r++){

        for(int c=0;c<2;c++){
            result[r][0]=result[r][0]+matrix1[r][c]*matrix2[0][c];
        }
    }

    for(int i=0;i<3;i++){
        printf("%i  ",result[i][0]);
    }
    return 0;
}
