#include <iostream>

using namespace std;
class Queue
{
private:
    int first;
    int last;
    int sizeQ;
    int *q;
    void SetLast()
    {
        last=(last+1)%sizeQ;
    }
    void SetFirst()
    {
        first=(first+1)%sizeQ;
    }
public:
    Queue(int _size)
    {
        first=-1;
        last=first;
        sizeQ=_size;
        q=new int[sizeQ];
    }

    int IsFull()
    {
        return (last+1)%sizeQ==first;
    }
    int IsEmpty()
    {
        return first==-1;
    }
    int Enqueue(int x)
    {
        if(IsEmpty())
        {
            first=0;
            last=0;
        }
        else if(IsFull())
        {
            return -9999;
        }
        else
        {
            SetLast();
        }
        q[last]=x;
        return x;
    }
    int Dequeue()
    {
        int x=-99999;
        if(IsEmpty())
        {
            return x;
        }
        else if(first==last)
        {
            first=-1;
            last=-1;
            return x;
        }
        else
        {
            x=q[first];
            SetFirst();
            return x;
        }
    }
    void ViewQueue()
    {
        int i=first;

        if(IsEmpty())
        {
            cout<<"\nEmpty !!!"<<endl;
        }
        else
        {
            while(i!=last)
            {
                cout<<q[i]<<"  ";
                i=(i+1)%sizeQ;
            }
            cout<<q[i]<<"  \n";
        }
    }

};

int main()
{
    //4- implement Circular Queue

    Queue q(4);
    ///////////////////
    q.ViewQueue();
    //////////////////
    for(int i=1; i<=3; i++)
        q.Enqueue(i);
    q.ViewQueue();
    /////////////////
    for(int i=1; i<=2; i++)
        q.Dequeue();
    q.ViewQueue();
    /////////////////
    for(int i=77; i<=80; i++)
        q.Enqueue(i);
    q.ViewQueue();
    /////////////////
    q.Dequeue();
    q.Enqueue(100);
    q.ViewQueue();
    /////////////////
    for(int i=1; i<=4; i++)
        q.Dequeue();
    q.ViewQueue();

    return 0;
}
