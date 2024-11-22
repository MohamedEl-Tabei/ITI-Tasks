#include <iostream>
using namespace std;
class Stack
{
private:
    static int counter;
    int top;
    int _size;
    int *arr;
    int isEmpty()
    {
        return top==0;
    };
    int isFull()
    {
        return top==_size;
    };
public:
    Stack(int __size)
    {
        top=0;
        _size=__size;
        arr=new int[_size];
        cout<<"Constructor created"<<endl;
        counter++;

    }
    void Push(int data)
    {
        if(!isFull())
        {
            arr[top]=data;
            cout<<"Push "<<data<<endl;
            top++;
        }
        else
            cout<<"Full!"<<endl;
    };
    int Pop()
    {
        int x;
        if(!isEmpty())
        {
            top--;
            x=arr[top];
            //top--;
            return x;
        }
        else
        {
            return -9999;
        }

    }
    int Peak()
    {
        if(!isEmpty())
            return arr[top-1];
        else
            return -999999;
    }
    ~Stack()
    {
        delete [] arr;
        cout<<"Destructor created"<<endl;
        counter--;
    }
    friend void viewStack(Stack);
    static int getCounter()
    {
        return counter;
    }


};
void viewStack(Stack _stack)
{
    int top=_stack.top;
    if(_stack.isFull())
        top--;
    if(_stack.isEmpty())
    {
        cout<<"Empty"<<endl;
    }
    else
    {
        cout<<"View Stack"<<endl;
        for(int i=top; i>=0; i--)
        {
            cout<<_stack.arr[i]<<endl;
        }
    }


}
int Stack::counter=0;

int main()
{
    //2- stack with static counter and standalone friend
    Stack _stack(4);
    cout<<Stack::getCounter()<<" Constructors"<<endl;
    cout<<"----------------"<<endl;
    cout<<"Peak "<<_stack.Peak()<<endl;
    cout<<"Pop "<<_stack.Pop()<<endl;

    for(int i=0; i<5; i++)
    {
        _stack.Push(i);
        cout<<"Peak "<<_stack.Peak()<<endl;
        cout<<"----------------"<<endl;
    }


    for(int i=0; i<5; i++)
    {
        cout<<"Pop "<<_stack.Pop()<<endl;
        cout<<"Peak "<<_stack.Peak()<<endl;
        cout<<"----------------"<<endl;

    }
    cout<<Stack::getCounter()<<" Constructors"<<endl;
    cout<<"----------------"<<endl;
    viewStack(_stack);
    cout<<Stack::getCounter()<<" Constructors"<<endl;
    cout<<"----------------"<<endl;
    cout<<"----------------"<<endl;
    cout<<Stack::getCounter()<<" Constructors"<<endl;
    cout<<"----------------"<<endl;


     for(int i=0; i<5; i++)
    {
        _stack.Push(i);
    }
    cout<<"----------------"<<endl;
    viewStack(_stack);
    cout<<"----------------"<<endl;
    return 0;
}





