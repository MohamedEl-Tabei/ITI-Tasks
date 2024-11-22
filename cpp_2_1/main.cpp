#include <iostream>

using namespace std;
int countDtr=0;
int countCtr=0;
class Complex
{
private:
    int real;
    int img;
public:
    Complex(int _real,int _img)
    {
        countCtr++;
        cout<<"Two Parameters Constructor called "<<countCtr<<endl;
        (*this).img=_img;
        this->real=_real;
    }
    Complex(int num)
    {
        countCtr++;
        cout<<"One Parameters Constructor called "<<countCtr<<endl;
        (*this).img=num;
        this->real=num;
    }
    Complex()
    {
        countCtr++;
        cout<<"Default Constructor called "<<countCtr<<endl;
    }
    ~Complex()
    {
        countDtr++;
        cout<<"Destructor called "<<countDtr<<endl;
    }
    void setReal(int _real)
    {
        real=_real;
    };
    int getReal() const
    {
        return real;
    };
    void setImg(int _img)
    {
        img=_img;
    };
    int getImg() const
    {
        return img;
    };
    Complex Add(Complex num)
    {
        Complex result;
        result.real=real+num.real;
        result.img=img+num.img;
        return result;
    };
    void print()
    {
        if(real!=0)
        {
            cout<<real;
        }
        if(img<0)
        {
            if(img!=-1)
                cout<<'-'<<img*-1<<'i';
            else
                cout<<'-'<<'i';
        }
        else if(img>0)
        {
            if(img!=1)
                cout<<'+'<<img<<'i';
            else
            {
                if(real==0)
                    cout<<'i';
                else
                    cout<<'+'<<'i';
            }


        }
        if(img==0&&real==0)
            cout<<0;
        cout<<endl;
    };
};
Complex Add(Complex const &x,Complex const &y)
{
    Complex result;
    result.setImg(x.getImg()+y.getImg());
    result.setReal(x.getReal()+y.getReal());
    return result;
}
int main()
{
    Complex num1=Complex(5);
    Complex num2=Complex(3,4);
    Complex num3;
    num3=Add(num1,num2);



    return 0;
}
