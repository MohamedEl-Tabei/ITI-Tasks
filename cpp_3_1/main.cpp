#include <iostream>
using namespace std;
template <class T>
class Stack
{
private:
    int top;
    int _size;
    T *arr;
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
        arr=new T[_size];

    }
    void Push(T data)
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
    void Pop()
    {
        if(!isEmpty())
        {
            top--;
            cout<<"Pop "<<arr[top]<<endl;
        }
        else
        {
            cout<<"Empty "<<endl;
        }

    }
    void Peak()
    {
        if(!isEmpty())
            cout<<arr[top-1]<<" is peak"<<endl;
        else
            cout<<"Empty "<<endl;
    }
    ~Stack()
    {
        delete [] arr;
    }



};
int main()
{
    //1- template class with stack   no ViewStack
    Stack<int> _stack(4);

    _stack.Peak();
    _stack.Pop();

    for(int i=0; i<5; i++)
    {
        _stack.Push(i);
        _stack.Peak();
        cout<<"----------------"<<endl;
    }
    for(int i=0; i<5; i++)
    {
        _stack.Pop();
        _stack.Peak();
        cout<<"----------------"<<endl;

    }

    return 0;
}



