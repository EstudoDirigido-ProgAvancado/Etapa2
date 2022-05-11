using System;


class Program 
  {
    static void Main(string[] args) 
      {
        Console.Write("Digite o valor de representação da Matriz: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nAgora, os valores da Matriz: ");
        
        
      
        int[,] mat = new int[n, n];

        for (int i = 0; i < n; i++) 
          {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++) 
              {
                mat[i, j] = int.Parse(values[j]);
              }
          }

        Console.WriteLine("Diagonal Principal:");
        for (int i = 0; i < n; i++) 
          {
            Console.Write(mat[i,i] + " ");
          }
        Console.WriteLine();

        int count = 0;
        for (int i = 0; i < n; i++) 
          {
            for (int j = 0; j < n; j++) 
              {
                if (mat[i,j] < 0) 
                  {
                    count++;
                  }
              }
          }
        Console.WriteLine("Números negativos: " + count);

      }
  }
