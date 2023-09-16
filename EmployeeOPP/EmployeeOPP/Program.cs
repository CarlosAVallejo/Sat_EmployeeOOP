﻿using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year, Emp;
    string firstName, lastName;
    decimal salary;
    


    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("Que tipo de empleado desea ingresar \n 1. Asalariado 2. Por Horas 3. Por comision ");
    Emp = Convert.ToInt32(Console.ReadLine());

    

    Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar Salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine(salaryEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
