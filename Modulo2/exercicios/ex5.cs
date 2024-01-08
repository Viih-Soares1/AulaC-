using System;
class Program{
    static void Main(){
        int num = 0;
        Console.WriteLine("Digite um número!");
        num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0){
            Console.WriteLine("Este número é par!");
        }
        else{
            Console.WriteLine("Este número é impar!");
        }
    }
}