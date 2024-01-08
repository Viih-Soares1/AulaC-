using System;

class Program{
    static void Main(){
// EX1- Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número]
    double n1 = 0;
    Console.WriteLine("Digite um numero qualquer");
    n1= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(string.Format("O número digitado foi {0} " , n1));



    }
}