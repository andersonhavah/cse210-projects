using System;
using employee_demo;
using learning05;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);

        Rectangle rectangle = new Rectangle("red", 5, 3);

        Circle circle = new Circle("pink", 8);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The shape of {shape.GetColor()} color and has an area of {shape.GetArea()}.\n");
        }





        // HourlyEmployee hEmployee= new HourlyEmployee();
        // hEmployee.setName("James");
        // hEmployee.setIdNumber("152");
        // hEmployee.SetPayRate(15);
        // hEmployee.SetHoursWorked(48);

        // SalaryEmployee sEmployee= new SalaryEmployee();
        // sEmployee.setName("Samantha");
        // sEmployee.setIdNumber("653");
        // sEmployee.SetSalary(70000);

        // DisplayEmployeeInformation(sEmployee);
        // DisplayEmployeeInformation(hEmployee);

        // List<Employee> employees = new List<Employee>();
        // employees.Add(hEmployee);
        // employees.Add(sEmployee);

        // foreach (Employee employee in employees)
        // {
        //     float pay = employee.GetPay();
        // }
    }

    // public static void DisplayEmployeeInformation(Employee employee)
    // {
    //     float pay = employee.GetPay();
    //     Console.WriteLine($"{employee.GetName()} will be paid ${pay}.");

    // }
}