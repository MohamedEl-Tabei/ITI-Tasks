#include <iostream>

using namespace std;

class Employee
{
private:
    int age;
public:
    Employee(int _age)
    {
        age=_age;
    }
    void setAge(int _age)
    {
        age=_age;
    }
    int getAge()
    {
        return age;
    }


};

void selectionSort(Employee **emps,int _size)
{
    int mini=0;
    int temp;
    for(int i=0; i<_size-1; i++)
    {
        for(int j=i+1; j<_size; j++)
        {
            if(emps[mini]->getAge()>emps[j]->getAge())
            {
                mini=j;
            }
        }
        if(emps[mini]->getAge()<emps[i]->getAge())
        {
            temp=emps[mini]->getAge();
            emps[mini]->setAge(emps[i]->getAge());
            emps[i]->setAge(temp);
        }
    }

}
int binarySearch_Age(Employee **emps,int _size,int age)
{
    selectionSort(emps,_size);
    cout<<"Employees after sorting"<<endl;
    for(int i=0;i<_size;i++)
        cout<<i<<" -> "<<emps[i]->getAge()<<endl;
    int left=0;
    int right=_size-1;
    int mid;
    while(left<=right)
    {
        mid=left+(right-left)/2;

        if(emps[mid]->getAge()==age)
            return mid;
        if(age<emps[mid]->getAge())
        {
            right=mid-1;
        }
        else
        {
            left=mid+1;
        }
    }
    return-1;



}

int main()
{
    Employee *employees[3]=
    {
        new Employee(50),
        new Employee(30),
        new Employee (60)
    };
    cout<<"Employee index is "<<binarySearch_Age(employees,3,50);

    return 0;
}
