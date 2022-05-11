using System;
using System.Globalization;
using System.Collections.Generic;


class Employee 
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; private set; }

    public Employee(int id, string name, double salary) 
      {
        Id = id;
        Name = name;
        Salary = salary;
      }

      public void IncreaseSalary(double percentage) 
        {
          Salary += Salary * percentage / 100.0;
        }

      public override string ToString() 
        {
          return Id + ", "+ Name + ", "+ Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
  }

class Program 
  {
    static void Main(string[] args) 
      {
        Console.Write("Quantos funcionários a cadastrar? ");
        int n = int.Parse(Console.ReadLine());

        List<Employee> list = new List<Employee>();

        for (int i = 1; i <= n; i++) 
          {
            Console.WriteLine("Funcionário #" + i + ":");
            Console.Write("Id: ");            
            int id = int.Parse(Console.ReadLine());
          
            Console.Write("Nome: ");
            string name = Console.ReadLine();
          
            Console.Write("Salario: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          
            list.Add(new Employee(id, name, salary));
            Console.WriteLine();
          }

        Console.Write("Entre com ID do Funcionário que terá aumento: ");
        int searchId = int.Parse(Console.ReadLine());

        Employee emp = list.Find(x => x.Id == searchId);
      
        if (emp != null) 
          {
            Console.Write("Insira a porcentegem: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);
          }
        else 
          {
            Console.WriteLine("ID inexistente");
          }

        Console.WriteLine();
        Console.WriteLine("Lista atualizada de Funcionários:");
      
        foreach (Employee obj in list) 
          {
            Console.WriteLine(obj);
          }
      }
  }


