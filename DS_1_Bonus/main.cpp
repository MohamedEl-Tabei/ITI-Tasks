#include <iostream>

using namespace std;
class Employee
{
private:
    int salary;
public:
    Employee(int s)
    {
        salary=s;
    }
    void setSalary(int s)
    {
        salary=s;
    }

    int getSalary()
    {
        return salary;
    }

};
void selectionSorting(Employee ** emps,int _size)
{
    int temp=emps[0]->getSalary();
    int indexMin;
    for(int i=0; i<_size-1; i++)
    {
        for(int j=i+1; j<_size; j++)
        {
            if(emps[i]->getSalary()>emps[j]->getSalary())
            {
                indexMin=j;
            }

        }
        if(emps[indexMin]->getSalary()<emps[i]->getSalary()){
            temp=emps[i]->getSalary();
            emps[i]->setSalary(emps[indexMin]->getSalary());
            emps[indexMin]->setSalary(temp);
        }
    }

}
void bubbleSorting(Employee ** emps,int _size)
{
    int temp;
    int last=_size;
    for(int i=0; i<_size; i++)
    {
        for(int j=0; j<last; j++)
        {
            if(emps[j+1]->getSalary()<emps[j]->getSalary())
            {
                temp=emps[j+1]->getSalary();
                emps[j+1]->setSalary(emps[j]->getSalary());
                emps[j]->setSalary(temp);
            }
        }
        last=last-1;
    }

}



void insetionSorting(Employee ** emps,int _size)
{
    int temp;
    int j=0;
    for(int i=0; i<_size; i++)
    {
        temp=emps[i]->getSalary();
        j=i-1;
        while(j>=0&&emps[j]->getSalary()>temp)//element before temp is greater
        {
            emps[j+1]->setSalary(emps[j]->getSalary());//shift every element before it
            j=j-1;
        }//put temp in the right position
        emps[j+1]->setSalary(temp);
    }
}

int main()
{
    Employee* employees[3]=
    {
        new Employee(50),
        new Employee(-20),
        new Employee(-100)
    };
    //bubbleSorting(employees,3);
    selectionSorting(employees,3);
    //insetionSorting(employees,3);
    for(int i=0; i<3; i++)
        cout<<employees[i]->getSalary()<<endl;
    return 0;
}
