using System;

class Program{
    static void Main(){
       // EX3 - Faça um Programa que peça as 4 notas bimestrais e mostre a média.
       double n1 = 0; 
       double n2 = 0;  
       double n3 = 0;  
       double n4 = 0; 
       double res = 0;
       Console.WriteLine("Digite a primeira nota");
       n1 = Convert.ToDouble(Console.ReadLine());
       res++;
       Console.WriteLine("Digite a segunda nota");
       n2 = Convert.ToDouble(Console.ReadLine());
       res++;
       Console.WriteLine("Digite a terceira nota");
       n3 = Convert.ToDouble(Console.ReadLine());
       res++;
       Console.WriteLine("Digite a quarta nota");
       n4 = Convert.ToDouble(Console.ReadLine());
       res++;
       res = (n1 + n2+ n3 + n4) / res ; 
       Console.WriteLine(string.Format("A média das quatro notas é: {0}", res));
       
    }
}