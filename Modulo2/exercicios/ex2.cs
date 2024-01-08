using System;
class Program{
    static void Main(){
        //Faça um Programa que peça um valor e mostre se o valor é positivo ou negativo.
        int n1 = 0;
        Console.WriteLine("Digite um numero qualquer");
        n1 = Convert.ToInt32(Console.ReadLine());
        if (n1 > 0){
            Console.WriteLine("Este número é positivo");
        }
        else if (n1 == 0){
            Console.WriteLine("Este número é neutro");
        }
        else{
            Console.WriteLine("Este número é negativo");
        }
         
    }
}