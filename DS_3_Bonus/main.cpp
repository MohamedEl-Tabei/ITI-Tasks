#include <iostream>
#include<string>
using namespace std;
class Employee
{
private:
    string name;
    int salary;
    int id;
    int age;
public:
    Employee* pNext;
    Employee* pPrevious;
    Employee(string _name,int _salary,int _id,int _age)
    {
        name=_name;
        salary=_salary;
        id=_id;
        age=_age;
        pNext=NULL;
        pPrevious=NULL;
    }
    Employee(const Employee &emp)
    {
        name=emp.name;
        salary=emp.salary;
        id=emp.id;
        age=emp.age;
        pNext=NULL;
        pPrevious=NULL;
    }
    string getName()
    {
        return name;
    }
    int getSalary()
    {
        return salary;
    }
    int getId()
    {
        return id;
    }
    int getAge()
    {
        return age;
    }
    void setName(string _name)
    {
        name=_name;
    }
    void setSalary(int _salary)
    {
        salary=_salary;
    }
    void setId(int _id)
    {
        id=_id;
    }
    void setAge(int _age)
    {
        age=_age;
    }
    void print()
    {
        cout<<name<<"\t|\t"<<salary<<"\t|\t"<<id<<"\t|\t"<<age<<endl;
    }
};
class DoubleLinkedList
{
private:
    Employee* pStart;
    Employee* pEnd;
public :
    DoubleLinkedList(Employee* ps,Employee* pe)
    {
        pStart=ps;
        pEnd=pe;
    }
    void insertAfter(int id,Employee* emp)
    {
        Employee* ptr=pStart;
        Employee* ptrNxt=NULL;

        while(ptr->getId()!=id && ptr!=NULL)
        {
            ptr=ptr->pNext;
        }

        ptrNxt=ptr->pNext;

        ptr->pNext=emp;
        emp->pPrevious=ptr;
        emp->pNext=ptrNxt;
        if(ptrNxt!=NULL)
            ptrNxt->pPrevious=emp;
        else
            pEnd=emp;
    }
    void printList()
    {
        Employee* ptr=pStart;

        while(ptr!=NULL)
        {
            ptr->print();
            ptr=ptr->pNext;
        }
    }
    void swapEmployees(Employee  *emp1,Employee* emp2)
    {
        Employee* temp=new Employee(*emp1);

        emp1->setAge(emp2->getAge());
        emp1->setId(emp2->getId());
        emp1->setName(emp2->getName());
        emp1->setSalary(emp2->getSalary());

        emp2->setAge(temp->getAge());
        emp2->setId(temp->getId());
        emp2->setName(temp->getName());
        emp2->setSalary(temp->getSalary());

    }
    void sortListBySalary()
    {
        Employee* ptr1=pStart;
        Employee* ptr2=pStart;
        Employee* temp=NULL;
        while(ptr1!=NULL)
        {
            ptr2=ptr1->pNext;
            temp=ptr1;
            while(ptr2!=NULL)
            {
                if(temp->getSalary()>ptr2->getSalary())
                {
                    temp=ptr2;
                }

                ptr2=ptr2->pNext;
            }

            if(temp->getSalary()<ptr1->getSalary())
            {

                swapEmployees(temp,ptr1);
            }
            ptr1=ptr1->pNext;

        }
    }
};
int main()
{
    Employee* emp1=new Employee("Employee 1",500,1,20);
    Employee* emp2=new Employee("Employee 2",880,2,20);
    Employee* emp3=new Employee("Employee 3",100,3,20);
    Employee* emp4=new Employee("Employee 4",50,4,20);
    Employee* emp5=new Employee("Employee 5",200,5,20);

    DoubleLinkedList list1(emp1,emp1);


    cout<<endl<<endl<<"List before sorting based on salary"<<endl;
    list1.insertAfter(1,emp2);
    list1.insertAfter(2,emp3);
    list1.insertAfter(3,emp4);
    list1.insertAfter(4,emp5);
    list1.printList();

    cout<<endl<<endl<<"List after sorting based on salary"<<endl;
    list1.sortListBySalary();
    list1.printList();





    return 0;
}
