using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace struct_
{
    internal struct Employee
    {
        static int count;
        //ID, name,security level, salary, hire date and Gender.
        int id;
        string name;
        decimal salary;
        SecurityLevel securityLevel;
        Gender gender;
        HireDate hireDate;
        static Employee()
        {
            count = 0;
        }
        public Employee()
        {
            count++;
            id = count;
            name = "";
            salary = 0;
            securityLevel = 0;
            gender = Gender.M;
            hireDate = new HireDate();
        }
        public override string  ToString() {
            return $"{id} | {name} | {salary} | {securityLevel} | {gender} | {hireDate}";
        }
        public void setName(string name) {
            this.id=count++;
            this.name = name;
        }
        public string getName() {return this.name;}
        public void setSalary(decimal salary) {this.salary = salary;}
        public decimal getSalary() { return this.salary;}
        public void setSecurityLevel(SecurityLevel securityLevel) { this.securityLevel = securityLevel;}
        public SecurityLevel getSecurityLevel() {return this.securityLevel;}
        public void setGender(Gender gender) {this.gender = gender;}
        public Gender getGender() {return this.gender;}
        public void setHireDate(HireDate hireDate) { this.hireDate = hireDate;}
        public HireDate getHireDate() {return this.hireDate;}

    }
}
