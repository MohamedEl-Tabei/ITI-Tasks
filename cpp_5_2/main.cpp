#include <iostream>
#include <chrono>
#include <thread>
#include "graphics.h"
using namespace std;
class Point
{
private:
    int x;
    int y;
public:
    Point(int _x,int _y)
    {
        x=_x;
        y=_y;
    }
    void SetY(int _y)
    {
        y=_y;
    }
    void SetX(int _x)
    {
        x=_x;
    }
    int GetX()
    {
        return x;
    }
    int GetY()
    {
        return y;
    }
};
class Circle_
{

private:
    Point center;
    int r;
    int cColor;
public:
    Circle_(int x,int y,int _r,int _color):center(x,y)
    {
        r=_r;
        cColor=_color;
    }
    void Draw()
    {
        setcolor(cColor);
        circle(center.GetX(),center.GetY(),r);
    }
    void SetY(int y)
    {
        center.SetY(y);
    }
    void SetX(int x)
    {
        center.SetX(x);
    }
};
class Rectangle_
{
private:
    Point upperLeft;
    Point lowerRight;
    int rColor;
public:
    Rectangle_(int x1,int y1,int x2,int y2,int _color):upperLeft(x1,y1),lowerRight(x2,y2)
    {
        rColor=_color;
    }
    void Draw()
    {
        setcolor(rColor);
        rectangle(upperLeft.GetX(),upperLeft.GetY(),lowerRight.GetX(),lowerRight.GetY());
    }
};
int main()
{
    initgraph();

    int z;

    Rectangle_ base(230,200,270,350,8);
    Rectangle_ b(210,300,290,350,8);

    Circle_ c1(150,150,50,8);


    Circle_ c2(350,150,50,8);

    int x=250;
    int y=150;
    Circle_ c(x,y,50,8);
    Circle_ fan(x,y,200,8);


    Circle_ c3(250,50,50,8);


    Circle_ c4(250,250,50,8);
    for (int i = 0; i < 3600; i++)
    {

        c1.SetX(x + 45 * cos(i * 3.14 / 180.0));
        c1.SetY(y + 45 * sin(i * 3.14  / 180.0));

        c2.SetX(x - 45 * cos(i * 3.14  / 180.0));
        c2.SetY(y - 45 * sin(i * 3.14  / 180.0));

        c3.SetX(x + 45 * sin(i * 3.14  / 180.0));
        c3.SetY(y - 45 * cos(i * 3.14  / 180.0));

        c4.SetX(x - 45 * sin(i * 3.14  / 180.0));
        c4.SetY(y + 45 * cos(i * 3.14  / 180.0));

        system("cls");

        base.Draw();
        fan.Draw();
        b.Draw();
        c1.Draw();
        c2.Draw();
        c3.Draw();
        c4.Draw();
        c.Draw();

        this_thread::sleep_for(chrono::milliseconds(10));
    }
    cin>>z;
    return 0;
}
