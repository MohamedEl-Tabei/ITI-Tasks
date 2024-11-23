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
        return last==sizeQ-1;
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
        if(isEmpty())
            first=last=0;
        else if(!isFull())
            last++;
        else
            return -99999;
        arr[last]=x;
        return x;
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
            if(last==-1)
                first=-1;
            return x;
        }
        else
            return -99999;

    }
    void ViewQueue()
    {

        if(isEmpty())
        {
            cout<<"\nEmpty !!!"<<endl;
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
    q.ViewQueue();
    for(int i=1; i<=5; i++)
        q.Enqueue(i);
    q.ViewQueue();
    for(int i=0; i<10; i++)
        q.Dequeue();
    q.ViewQueue();

    return 0;
}



