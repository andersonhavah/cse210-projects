using System;

namespace employee_demo
{
    public abstract class Employee
    {
        protected string _name;
        protected string _idNumber;

        public Employee()
        {

        }

        public string GetName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }

        public string GetIdNumber()
        {
            return _idNumber;
        }

        public void setIdNumber(string idNumber)
        {
            _idNumber = idNumber;
        }

        public abstract float GetPay();

    }
}