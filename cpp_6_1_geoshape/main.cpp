#include <iostream>

using namespace std;
class Geoshape
{
protected:
    double dimension1;
    double dimension2;
public:
    Geoshape()
    {
        dimension1=dimension2=0;
    }
    Geoshape(double d1,double d2)
    {
        dimension1=d1;
        dimension2=d2;
    }
    void SetDimension1(double d)
    {
        dimension1=d;
    };
    void SetDimension2(double d)
    {
        dimension2=d;
    };
    double GetDimension1()
    {
        return dimension1;
    };
    double GetDimension2()
    {
        return dimension2;
    };

};

class _Triangle:public Geoshape
{
public:
    _Triangle(double h,double b):Geoshape(h,b) {}
    double GetArea()
    {
        return dimension1*dimension2*(.5);
    }
};
class _Rectangle:public Geoshape
{
public:
    _Rectangle(double d1,double d2):Geoshape(d1,d2) {}
    double GetArea()
    {
        return dimension1*dimension2;
    }
};
class _Square:protected _Rectangle
{
public:

    _Square(double d):_Rectangle(d,d) {}
    void SetDimension1(double d)
    {
        dimension1=dimension2=d;
    };
    void SetDimension2(double d)
    {
        dimension1=dimension2=d;
    };
    double GetDimension1()
    {
        return dimension1;
    };
    double GetDimension2()
    {
        return dimension2;
    };
    double GetArea()
    {
        return dimension1*dimension2;
    }
};
class _Circle:public _Square
{
public:
    _Circle(double r):_Square(r) { }
    double GetArea()
    {
        return dimension1*dimension2*3.14;
    }
};
int main()
{
    ///inheritance
    ////1- Geoshape    Rect,Sq,tri,cir :geoshape
    _Square s(4);
    _Circle c(5);
    _Rectangle r(6,7);
    _Triangle t(8,9);

    cout <<"Square area = "<<s.GetDimension1()<<" * "<<s.GetDimension2()<<" = "<<s.GetArea() << endl;
    cout <<"Circle area = "<<c.GetDimension1()<<" * "<<c.GetDimension2()<<" * (22/7) = "<<c.GetArea() << endl;
    cout <<"Rectangle area = "<<r.GetDimension1()<<" * "<<r.GetDimension2()<<" = "<<r.GetArea() << endl;
    cout <<"Triangle area = "<<t.GetDimension1()<<" * "<<t.GetDimension2()<<" * (1/2) = "<<t.GetArea() << endl<<endl<<endl;
    //////////////////////////////////////////
    s.SetDimension2(40);
    c.SetDimension2(50);
    r.SetDimension2(60);
    t.SetDimension2(80);
    //////////////////////////////////////////
    cout << "After setting new values to dimension 2 in all shapes"<< endl<<endl;

    cout <<"Square area = "<<s.GetDimension1()<<" * "<<s.GetDimension2()<<" = "<<s.GetArea() << endl;
    cout <<"Circle area = "<<c.GetDimension1()<<" * "<<c.GetDimension2()<<" * (22/7) = "<<c.GetArea() << endl;
    cout <<"Rectangle area = "<<r.GetDimension1()<<" * "<<r.GetDimension2()<<" = "<<r.GetArea() << endl;
    cout <<"Triangle area = "<<t.GetDimension1()<<" * "<<t.GetDimension2()<<" * (1/2) = "<<t.GetArea() << endl<<endl<<endl;
    return 0;
}




