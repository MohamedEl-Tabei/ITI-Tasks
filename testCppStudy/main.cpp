#include <iostream>

using namespace std;
class Base
{
public:
    int x;
    Base(int y)
    {
        x=y;
        ++x;
    }
    Base(){

    }
};
class child : public Base
{
public:
    child(int c)
    {
        //x+=1;
    }
    void print()
    {
        cout<<"x="<<x;
    }
};
int main()
{
    child c(1);
    c.print();
}
