#include <iostream>

using namespace std;
class Queue
{
private:
    int first;
    int last;
    int sizeQ;
    int *arr;
    int isEmpty()
    {
        return first==-1;
    }
    int isFull()
    {
        return last==sizeQ;
    }
public:
    Queue(int _sizeQ)
    {
        first=-1;
        last=-1;
        sizeQ=_sizeQ;
        arr=new int[sizeQ];
    }
    int Enqueue(int x)
    {
        if(first<0)
            first=last=0;
        if(!isFull())
        {

            last++;
        }
        if(last<sizeQ)
        {
            arr[last]=x;
            return x;
        }
        else
            return -99999;
    }
    int Dequeue()
    {
        int x;
        if(!isEmpty())
        {
            x=arr[first];
            arr[first]=-99999;
            for(int i=first; i<last; i++)
            {
                arr[i]=arr[i+1];
            }
            last--;
            return x;
        }
        else
            return -99999;

    }
    void ViewQueue()
    {

        if(isEmpty())
        {
            cout<<"Empty !!!"<<endl;
        }
        else
        {
            for(int i=first; i<=last; i++)
                cout<<arr[i]<<"  ";
        }
    }






};
int main()
{
    //3- implement Shift Queue

    Queue q(4);
    q.Enqueue(1);
    q.Enqueue(2);

    q.Enqueue(3);
    q.Enqueue(4);
    q.Enqueue(5);


    q.ViewQueue();

    return 0;
}



