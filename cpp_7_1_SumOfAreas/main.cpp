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

    double GetDimension1()
    {
        return dimension1;
    };
    double GetDimension2()
    {
        return dimension2;
    };
    virtual void SetDimension1(double d)=0;
    virtual void SetDimension2(double d)=0;
    virtual double GetArea()=0;

};

class _Triangle:public Geoshape
{
public:
    _Triangle(double h,double b):Geoshape(h,b) {}
     void SetDimension1(double d) override
    {
        dimension1=d;
    };
    void SetDimension2(double d) override
    {
        dimension2=d;
    };
    double GetArea()
    {
        return dimension1*dimension2*(.5);
    }
};
class _Rectangle:public _Triangle
{
public:
    _Rectangle(double d1,double d2):_Triangle(d1,d2) {}
    double GetArea()
    {
        return dimension1*dimension2;
    }
};
class _Square:public _Rectangle
{
public:

    _Square(double d):_Rectangle(d,d) {}
    void SetDimension1(double d) override
    {
        dimension1=dimension2=d;
    };
    void SetDimension2(double d) override
    {
        dimension1=dimension2=d;
    };
    double GetArea() override
    {
        return dimension1*dimension2;
    }
};
class _Circle:public _Square
{
public:
    _Circle(double r):_Square(r) { }
    double GetArea() override
    {
        return dimension1*dimension2*3.14;
    }
};
double SumOfAreas(Geoshape **gArr,int gSize)
{
    double sum=0;
    for(int i=0;i<gSize;i++)
        sum=sum+gArr[i]->GetArea();
    return sum;

}
int main()
{
    //1-Add SumOfAreasv1,v2 to Geoshape
    Geoshape *gP[4]={new _Circle(7),new _Rectangle(3,2),new _Square(10),new _Triangle(20,10)};
    for(int i=0;i<4;i++)
        cout<<gP[i]->GetArea()<<" + ";
    cout<<"\b\b = "<<SumOfAreas(gP,4)<<endl;
    return 0;
}






