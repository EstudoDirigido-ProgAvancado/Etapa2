using System;
using System.Globalization;


class Aluno 
  {
    public string Nome;
    public double Nota1, Nota2, Nota3;
  
    public double NotaFinal() 
      {
        return Nota1 + Nota2 + Nota3;
      }
  
    public bool Aprovado() 
      {
        if (NotaFinal() >= 60.0) 
          {
            return true;
          }
        else 
          {
            return false;
          }
      }
  
    public double NotaRestante() 
      {
        if (Aprovado()) 
        {
          return 0.0;
        }
        else 
        {
          return 60.0 - NotaFinal();
        }
      }
  }


class Program 
  {
    static void Main(string[] args) 
      {
        Aluno aluno = new Aluno();
      
        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();
      
        Console.WriteLine("Digite as três notas do aluno:");
        aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      
        Console.WriteLine("\nNOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
      
        if (aluno.Aprovado()) 
          {
            Console.WriteLine("\nAPROVADO");
          }
        else 
          {
            Console.WriteLine("\nREPROVADO");
            Console.WriteLine("FALTARAM "
            + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
            + " PONTOS");
          }
      }
  }
