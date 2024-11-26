#include <iostream>

using namespace std;
//2- Stack


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

    }
    //cpy ctor  MUST
    Stack(const Stack &oldStack)
    {
        cout<<"Copy Constructor"<<endl;
        delete []this->arr;
        top=oldStack.top;
        _size=oldStack._size;
        arr=new int[_size];
        for(int i=0; i<top; i++)
            arr[i]=oldStack.arr[i];

    }

    void Push(int data)
    {
        if(!isFull())
        {
            arr[top]=data;
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
    }
    friend void viewStack(Stack&);
    //= operator MUST
    Stack& operator=(const Stack &rightStack)
    {
        delete []this->arr;
        top=rightStack.top;
        _size=rightStack._size;
        arr=new int[_size];
        for(int i=0; i<top; i++)
            arr[i]=rightStack.arr[i];
        return *this;

    }
    //Stack reverseStack()
    void reverseStack()
    {
        Stack temp1(_size);
        Stack temp2(_size);
        while(!isEmpty())
            temp1.Push(Pop());
        while(!temp1.isEmpty())
            temp2.Push(temp1.Pop());
        while(!temp2.isEmpty())
            Push(temp2.Pop());

    }
    //==
    int operator==(const Stack& rightStack)
    {
        Stack index(_size);
        int isExist=0;
        if(top!=rightStack.top)
            return 0;
        else
        {
            for(int i=0; i<top; i++)
            {
                for(int j=0; j<top; j++)
                {
                    for(int k=0; k<index.top; k++)
                    {
                        if(index.arr[k]==j)
                            isExist=1;
                    }
                    if(isExist)
                    {
                        isExist=0;
                    }
                    else if(rightStack.arr[i]==arr[j])
                        index.Push(j);
                }
            }
        }
        //cout<<index.top<<endl;
        //cout<<top<<endl;
        if(index.top!=top)
            return 0;
        return 1;


    }
    //+
    Stack operator +(const Stack& rightStack)
    {
        Stack result(rightStack._size+_size);
        for(int i=top-1; i>=0; i--)
            result.Push(arr[i]);
        for(int i=rightStack.top-1; i>=0; i--)
            result.Push(rightStack.arr[i]);
        return result;

    }



};
void viewStack(Stack& _stack)
{
    int top=_stack.top;
    if(_stack.isEmpty())
    {
        cout<<"Empty"<<endl;
    }
    else
    {
        for(int i=top-1; i>=0; i--)
        {
            cout<<_stack.arr[i]<<endl;
        }
    }


}





int main()
{
    Stack s1(5);
    int x;
    for(int i=1; i<=5; i++)
        s1.Push(i);

    ///////////////view stack after s2=s1 ///////////////
    Stack s2=s1;
    cout<<"view s2 after s1=s2"<<endl;
    viewStack(s2);

    /////////////2 pop from s1 and view s1 & s2///////////////////
    s1.Pop();
    s1.Pop();
    cout<<"-------------------193----------------------------"<<endl;
    cout<<"view s1 after 2 pop"<<endl;
    viewStack(s1);
    cout<<"view s2 after 2 pop from s1"<<endl;
    viewStack(s2);

    //////////////push 55 to s1 and make s2=s1  //////////////////
    s1.Push(55);
    s2=s1;
    cout<<"---------------------202--------------------------"<<endl;
    cout<<"view s2 after push 55 to s1 and make s2=s1"<<endl;
    viewStack(s2);

    ///////////////reverse s2/////////////////
    s2.reverseStack();
    cout<<"--------------------208---------------------------"<<endl;
    cout<<"view s2 after reverse"<<endl;
    viewStack(s2);

    ////////////////s1==s2////////////////
    s2=s1;
    //s1.Pop();
    x=s2==s1;
    cout<<"----------------------216-------------------------"<<endl;
    cout<<"view if s1==s2"<<endl;
    cout<<x<<endl;

    ///////////////resutlt after s1+s2/////////////////
    cout<<"---------------------221--------------------------"<<endl;
    cout<<"view of result=s1+s2"<<endl;
    Stack result=s2+s1;
    viewStack(result);

    return 0;
}
