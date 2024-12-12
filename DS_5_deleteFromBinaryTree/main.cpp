#include <iostream>

using namespace std;


class Employee
{
private:
    int id;
public:
    Employee* pLeft;
    Employee* pRight;
    Employee(int _id)
    {
        id=_id;
        pLeft=NULL;
        pLeft=NULL;
    }
    int getId()
    {
        return id;
    }
    void setId(int _id)
    {
        id=_id;
    }
};

class BinaryTree
{
    Employee *pParent;
    Employee* insert_(Employee *pRoot,Employee* newEmp)
    {
        if(pRoot==NULL)
        {
            newEmp->pLeft=NULL;
            newEmp->pRight=NULL;
            return newEmp;
        }
        else if(newEmp->getId()<pRoot->getId())
        {
            pRoot->pLeft=insert_(pRoot->pLeft,newEmp);
        }
        else
        {
            pRoot->pRight=insert_(pRoot->pRight,newEmp);
        }
        return pRoot;
    }
    void inOrder(Employee *ptr)
    {
        if(ptr!=NULL)
        {
            inOrder(ptr->pLeft);
            cout<<ptr->getId()<<"\t";
            inOrder(ptr->pRight);

        }

    }
    Employee* deleteFrom(Employee *ptr,int id)
    {
        Employee *p,*p2;

        if(ptr!=NULL)
        {
            if(id<ptr->getId())
            {
                ptr->pLeft=deleteFrom(ptr->pLeft,id);
            }
            else if(id>ptr->getId())
            {
                ptr->pRight=deleteFrom(ptr->pRight,id);
            }
            else// is the deleted employee
            {
                if(ptr->pRight==ptr->pLeft)
                {
                    delete ptr;
                    return NULL;
                }
                else if(ptr->pRight==NULL)
                {
                    p=ptr->pLeft;
                    delete ptr;
                    return p;
                }
                else if(ptr->pLeft==NULL)
                {
                    p=ptr->pRight;
                    delete ptr;
                    return p;
                }
                else
                {
                    p2=ptr->pRight;
                    p=ptr->pRight;

                    while(p->pLeft)
                        p=p->pLeft;
                    p->pLeft=ptr->pLeft;
                    delete ptr;
                    return p2;
                }
            }
            return ptr;
        }
        return ptr;
    }
public:
    BinaryTree()
    {
        pParent=NULL;
    }
    void insertNewEmployee(Employee *newEmployee)
    {
        pParent=insert_(pParent,newEmployee);
    }
    void printInOrder()
    {
        inOrder(pParent);
    }
    void deletEmployeeById(int id)
    {
        pParent=deleteFrom(pParent,id);
    }
};
int main()
{
    BinaryTree tree;
    tree.insertNewEmployee(new Employee(5));
    tree.insertNewEmployee(new Employee(8));
    tree.insertNewEmployee(new Employee(2));
    tree.insertNewEmployee(new Employee(4));
    tree.insertNewEmployee(new Employee(7));
    tree.insertNewEmployee(new Employee(9));
    tree.printInOrder();

    cout<<endl<<endl<<"Tree in order after delete 9"<<endl;
    tree.deletEmployeeById(9);
    tree.printInOrder();

    cout<<endl<<endl<<"Tree in order after delete 2"<<endl;
    tree.deletEmployeeById(2);
    tree.printInOrder();

    cout<<endl<<endl<<"Tree in order after delete 5"<<endl;
    tree.deletEmployeeById(5);
    tree.printInOrder();
    return 0;
}
