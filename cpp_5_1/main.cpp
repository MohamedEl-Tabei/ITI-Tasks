#include <iostream>
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
    int GetX()
    {
        return x;
    }
    int GetY()
    {
        return y;
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
};
class Line_
{
private:
    Point p1;
    Point p2;
    int lColor;
public:
    Line_(int x1,int y1,int x2,int y2,int _color):p1(x1,y1),p2(x2,y2)
    {
        lColor=_color;
    }
    Point GetP1()
    {
        return p1;
    }
    Point GetP2()
    {
        return p2;
    }
    void Draw()
    {
        setcolor(lColor);
        line(p1.GetX(),p1.GetY(),p2.GetX(),p2.GetY());
    }


};
class Triangle_
{
private:
    Line_ _1;
    Line_ _2;
    Line_ _3;
    int tColor;
public:
    Triangle_(int x1,int y1,int x2,int y2,int x3,int y3,int _color): _1(x1,y1,x2,y2,_color), _2(x1,y1,x3,y3,_color),_3(x2,y2,x3,y3,_color)
    {
        tColor=_color;
    }

    void Draw()
    {
        setcolor(tColor);
        line(_1.GetP1().GetX(),_1.GetP1().GetY(),_1.GetP2().GetX(),_1.GetP2().GetY());
        line(_2.GetP1().GetX(),_2.GetP1().GetY(),_2.GetP2().GetX(),_2.GetP2().GetY());
        line(_3.GetP1().GetX(),_3.GetP1().GetY(),_3.GetP2().GetX(),_3.GetP2().GetY());
    }
};
int main()
{
    initgraph();
    Rectangle_ baseOfAbajora(300,460,500,520,8);
    Rectangle_ backOfAbajora(300,200,350,460,8);
    Circle_ lampOfAbajora(490,290,139,8);
    Circle_ c(330,225,80,8);
    Line_ upOfAbajora(300,200,525,230,8);
    Line_ downOfAbajora(300,200,450,340,8);
    Line_ light1(580,310,650,350,8);
    Line_ light2(580,330,650,370,8);
    Line_ light3(580,350,650,390,8);
    Triangle_ button(470,480,460,500,480,500,8);
    baseOfAbajora.Draw();
    backOfAbajora.Draw();
    downOfAbajora.Draw();
    upOfAbajora.Draw();
    button.Draw();
    light1.Draw();
    light2.Draw();
    light3.Draw();
    lampOfAbajora.Draw();
    c.Draw();
    return 0;
}
