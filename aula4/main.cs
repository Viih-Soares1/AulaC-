using System;

class Program{
    static void Main(){
        // METODOS DE CONVERSAO DE DADOS
        // Convert.ToString();
        // Convert.ToDouble():
        // COnvert.ToInt();
        // Convert.ToInt32();
        // long n1= Convert.ToInt64();
       double n1,n2, res = 0;

       Console.WriteLine("Digite um numero");
       n1 = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite outro numero");
       n2 = Convert.ToDouble(Console.ReadLine()); 
       res = n1 + n2;
       Console.WriteLine("A soma de " + n1 + " + " + n2 + " é igual a: "+ res);
        
    }
}