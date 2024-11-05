#include <iostream>

using namespace std;
class Complex
{
private:
    int real;
    int img;
public:
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
    int num;
    Complex num1;
    Complex num2;
    Complex result;
    for(int i=0; i<10; i++)
    {
        cout<<"________________________________"<<endl;

        cout<<"Add member"<<endl;
        //real 1
        cout<<"number1 real: ";
        cin>>num;
        num1.setReal(num);
        //img 1
        cout<<"number1 img: ";
        cin>>num;
        num1.setImg(num);
        //real 2
        cout<<"number2 real: ";
        cin>>num;
        num2.setReal(num);
        //img 2
        cout<<"number 2 img: ";
        cin>>num;
        num2.setImg(num);
        result= num1.Add(num2);

        cout<<"Add member"<<endl;
        result.print();
        cout<<"Add standalone"<<endl;
        result=Add(num1,num2);
        result.print();

    }
    return 0;
}
