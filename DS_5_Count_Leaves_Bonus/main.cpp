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
    int numberOfLeaves;
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
    int countLeaves_(Employee *ptr)//Bonus: Implement a function that will count the leaves of a binary tree.
    {
        if(ptr!=NULL)
        {
            if(ptr->pLeft==ptr->pRight&&ptr->pLeft==NULL)
                numberOfLeaves++;
            countLeaves_(ptr->pLeft);
            countLeaves_(ptr->pRight);
        }
        return numberOfLeaves;

    }
public:
    BinaryTree()
    {
        pParent=NULL;
        numberOfLeaves=0;
    }
    void insertNewEmployee(Employee *newEmployee)
    {
        pParent=insert_(pParent,newEmployee);
    }
    int countLeaves()//Bonus: Implement a function that will count the leaves of a binary tree.
    {
        numberOfLeaves=0;
        return countLeaves_(pParent);
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


    cout<<"Number of leaves -> "<<tree.countLeaves()<<endl;


    return 0;
}
