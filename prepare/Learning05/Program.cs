using System;
using employee_demo;
using learning05;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);
        string squareColor = square.GetColor();
        double squareArea = square.GetArea();
        Console.WriteLine($"The square has a color of {squareColor} and an area of {squareArea}.\n");

        Rectangle rectangle = new Rectangle("red", 5, 3);
        string rectangleColor = rectangle.GetColor();
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine($"The rectangle has a color of {rectangleColor} and an area of {rectangleArea}.\n");

        Circle circle = new Circle("pink", 8);
        string circleColor = circle.GetColor();
        double circleArea = circle.GetArea();
        Console.WriteLine($"The circle has a color of {circleColor} and an area of {circleArea}.\n");





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