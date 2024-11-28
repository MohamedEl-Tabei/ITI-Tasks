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
class Shape
{
protected :
    int color;
public:
    Shape(int _color)
    {
        color=_color;
    }
    int getColor()
    {
        return color;
    }
    virtual void Draw()=0;
};
class Rectangle_:public Shape
{
private:
    Point upperLeft;
    Point lowerRight;
public:
    Rectangle_(int x1,int y1,int x2,int y2,int _color):upperLeft(x1,y1),lowerRight(x2,y2),Shape(_color)
    {    }
    void Draw() override
    {
        setcolor(color);
        rectangle(upperLeft.GetX(),upperLeft.GetY(),lowerRight.GetX(),lowerRight.GetY());
    }
};
class Circle_:public Shape
{

private:
    Point center;
    int r;
public:
    Circle_(int x,int y,int _r,int _color):center(x,y),Shape(_color)
    {
        r=_r;
    }

    void Draw()override
    {
        setcolor(color);
        circle(center.GetX(),center.GetY(),r);
    }
};
class Line_:public Shape
{
private:
    Point p1;
    Point p2;
public:
    Line_(int x1,int y1,int x2,int y2,int _color):p1(x1,y1),p2(x2,y2),Shape(_color)
    {    }

    Point GetP1()
    {
        return p1;
    }
    Point GetP2()
    {
        return p2;
    }
    void Draw()override
    {
        setcolor(color);
        line(p1.GetX(),p1.GetY(),p2.GetX(),p2.GetY());
    }


};
class Triangle_:public Shape
{
private:
    Line_ _1;
    Line_ _2;
    Line_ _3;
public:
    Triangle_(int x1,int y1,int x2,int y2,int x3,int y3,int _color): _1(x1,y1,x2,y2,_color), _2(x1,y1,x3,y3,_color),_3(x2,y2,x3,y3,_color),Shape(_color)
    {    }

    void Draw() override
    {
        setcolor(color);
        line(_1.GetP1().GetX(),_1.GetP1().GetY(),_1.GetP2().GetX(),_1.GetP2().GetY());
        line(_2.GetP1().GetX(),_2.GetP1().GetY(),_2.GetP2().GetX(),_2.GetP2().GetY());
        line(_3.GetP1().GetX(),_3.GetP1().GetY(),_3.GetP2().GetX(),_3.GetP2().GetY());
    }
};
class Picture
{
private:
    Shape **arrShapes;
    int sizeP;
public:
    Picture()
    {
        arrShapes=NULL;
        sizeP=0;
    }
    void setShapes(Shape** ptr,int _size)
    {
        sizeP=_size;
        arrShapes=ptr;
    };


    void execute()
    {
        for(int i=0; i<sizeP; i++)
        {
            setcolor(arrShapes[i]->getColor());
            arrShapes[i]->Draw();
        }

    }
};
int main()
{

    ///2-Draw abajora via enhanced picture

    initgraph();
    Shape* shapes[]=
    {
        new Rectangle_(300,460,500,520,8),new Rectangle_(300,200,350,460,8),
        new Line_(300,200,525,230,8),new Line_ (300,200,450,340,8),new Line_ (580,310,650,350,8),new Line_ (580,330,650,370,8),
        new Line_ (580,350,650,390,8),new Triangle_ (470,480,460,500,480,500,8),
        new Circle_(490,290,139,8),new Circle_(330,225,80,8)
    };
    Picture p;
    p.setShapes(shapes,10);
    p.execute();
    int x;
    cin>>x;
    return 0;
}//10

