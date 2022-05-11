using System;
using System.Globalization;

class Retangulo 
  {
    public double Largura;
    public double Altura;
  
    public double Area() 
      {
      return Largura * Altura;
      }
  
    public double Perimetro() 
      {
        return 2 * (Largura + Altura);
      }
  
    public double Diagonal() 
      {
        return Math.Sqrt(Largura * Largura + Altura * Altura);
      }
  }

 
class Program 
  {
    static void Main(string[] args) 
      {
        Retangulo ret = new Retangulo();
      
        Console.WriteLine("Entre a largura e altura do retângulo: ");
        ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      
        Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
      }
  }
