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

    void insertAfter(int id,Employee* emp)//Bonus for the next lecture : Implement insert Node from the Doubly Linked list with all Cases

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
    void insertBefore(int id,Employee* emp)//Bonus for the next lecture : Implement insert Node from the Doubly Linked list with all Cases

    {
        Employee* ptr=pStart;
        Employee* ptrPrv=NULL;

        while(ptr->getId()!=id && ptr!=NULL)
        {
            ptr=ptr->pNext;
        }

        ptrPrv=ptr->pPrevious;

        ptr->pPrevious=emp;
        emp->pNext=ptr;
        emp->pPrevious=ptrPrv;
        if(ptrPrv!=NULL)
            ptrPrv->pNext=emp;
        else
            pStart=emp;


    }
    void deleteFromList(int id)
    {
        Employee* deletedEmp=pStart;
        Employee* pPrv;
        Employee* pNxt;
        while(deletedEmp!=NULL&&deletedEmp->getId()!=id)
        {
            deletedEmp=deletedEmp->pNext;
        }
        if(deletedEmp!=NULL)
        {
            pPrv=deletedEmp->pPrevious;
            pNxt=deletedEmp->pNext;

            if(pPrv!=NULL)
                pPrv->pNext=pNxt;
            else
                pStart= pNxt;
            if(pNxt!=NULL)
                pNxt->pPrevious=pPrv;
            else
                pEnd= pPrv;

            deletedEmp->pNext=NULL;
            deletedEmp->pPrevious=NULL;
            delete deletedEmp;

        }
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

};
int main()
{
    Employee* emp1=new Employee("Employee 1",500000,1,20);
    Employee* emp2=new Employee("Employee 2",88000,2,20);
    Employee* emp3=new Employee("Employee 3",100,3,20);
    Employee* emp4=new Employee("Employee 4",100000,4,20);
    Employee* emp5=new Employee("Employee 5",10,5,20);

    DoubleLinkedList list1(emp1,emp1);

    cout<<"List with one Employee"<<endl;
    list1.printList();

    cout<<endl<<endl<<"List after adding Employees"<<endl;
    list1.insertAfter(1,emp2);
    list1.insertAfter(2,emp3);
    list1.insertAfter(3,emp4);
    list1.insertAfter(4,emp5);
    list1.printList();

    cout<<endl<<endl<<"List after deleting Employee number 1"<<endl;
    list1.deleteFromList(1);
    list1.printList();


    cout<<endl<<endl<<"List after deleting Employee number 5"<<endl;
    list1.deleteFromList(5);
    list1.printList();

    cout<<endl<<endl<<"List after deleting Employee number 3"<<endl;
    list1.deleteFromList(3);
    list1.printList();


    //Bonus for the next lecture : Implement insert Node from the Doubly Linked list with all Cases
    cout<<endl<<endl<<"List after inserting Employee number 3"<<endl;
    list1.insertAfter(2,new Employee("Employee 3",1000,3,20));
    list1.printList();

    cout<<endl<<endl<<"List after inserting Employee number 1"<<endl;
    list1.insertBefore(2,new Employee("Employee 1",1000,1,20));
    list1.printList();

    cout<<endl<<endl<<"List after inserting Employee number 5"<<endl;
    list1.insertAfter(4,new Employee("Employee 5",1000,5,20));
    list1.printList();

    return 0;
}
