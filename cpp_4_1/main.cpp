#include <iostream>

using namespace std;
class Complex
{

private:
    int real,img;
public:
    void setReal(int _real)
    {
        real=_real;
    }
    void setImg(int _img)
    {
        img=_img;
    }
    int getReal() const
    {
        return real;
    }
    int getImg() const
    {
        return img;
    }
    Complex()
    {
        real=img=0;
    }
    Complex(int _r,int _i)
    {
        real=_r;
        img=_i;
    }
    //cpy ctor useless
    Complex(const Complex& oldObj)
    {
        cout<<"Copy Constructor"<<endl;
        real=oldObj.real;
        img=oldObj.img;
    }
    //c1+c2
    Complex operator+(const Complex right){
        Complex result;
        result.img=right.img+img;
        result.real=right.real+real;
        return result;
    }
    //c1+=c2
    Complex& operator+=(const Complex right)
    {
        real=real+right.real;
        img=img+right.img;
        return *this;
    }
    //++c1
    Complex& operator++(){
        real++;
        img++;
        return *this;
    }
    //c1++
    Complex operator++(int){
        Complex result;
        result.img=img;
        result.real=real;
        real++;
        img++;
        return result;
    }
    //c1+10
    Complex operator+(int num)
    {
        Complex result;
        result.img=img;
        result.real=real+num;
        return result;
    }
    //c1>c2
    int operator>(Complex right){

        return real>right.real;
    }
    //(int)c1
    operator int(){
        return real;
    }
    //c1=c2  useless




};
//10+c1
Complex operator+(int left,Complex right)
{
    return right+left;
}
int main()
{
    Complex c1(5,6), c2(5,4);
    Complex result;
    result=c1+c2;
    cout<<result.getReal()<<"+"<<result.getImg()<<endl;
    ///////////////////////////////////////////////////////
    result+=c1;
    cout<<result.getReal()<<"+"<<result.getImg()<<endl;
    ///////////////////////////////////////////////////////
    ++result;
    cout<<result.getReal()<<"+"<<result.getImg()<<endl;
     ///////////////////////////////////////////////////////
    c1=result++;
    cout<<c1.getReal()<<"+"<<c1.getImg()<<endl;
    cout<<result.getReal()<<"+"<<result.getImg()<<endl;
    ///////////////////////////////////////////////////////
    result=c1+10;
    cout<<result.getReal()<<"+"<<result.getImg()<<endl;
    ///////////////////////////////////////////////////////
    int x=result.getReal()>c1.getReal();
    cout<<x<<endl;
    ///////////////////////////////////////////////////////
    x=result;
    cout<<x<<endl;
    ///////////////////////////////////////////////////////
    result=10+c1;
    cout<<result.getReal()<<"+"<<result.getImg()<<endl;
    return 0;
}





