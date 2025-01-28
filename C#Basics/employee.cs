: using System; class EmployeeSalaryCalculator
{     static void Main()
    {   
        Console.WriteLine("Name of Student= ");
        Console.WriteLine("PRN. of Student= 2022010");         
        Console.Write("\nEnter Hours Worked= ");        
         double hoursWorked = Convert.ToDouble(Console.ReadLine());        
          Console.Write("Enter Hourly Rate= ");        
           double hourlyRate = Convert.ToDouble(Console.ReadLine());         
           Console.Write("Enter Deductions= ");         
           double deductions = Convert.ToDouble(Console.ReadLine());        
            double salary = (hoursWorked * hourlyRate) - deductions;        
             Console.WriteLine("The Monthly Salary is= " + salary);
    }

