using System;
class Program{
    static void Main(){
        //Faça um Programa que peça um número e informe se o número é inteiro ou decimal.
        double n1 = 0;
        Console.WriteLine("Digite um numero qualquer");
        n1 = Convert.ToDouble(Console.ReadLine());
        if( n1 % 2 == 0 || n1 % 2 == 1){
            Console.WriteLine("Este número é inteiro");
        }
        else {
            Console.WriteLine("Este número é decimal");
        }
    }
}