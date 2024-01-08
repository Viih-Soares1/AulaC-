using System;
class program{
    static void Main(){
        // Faça um Programa que leia três números e mostre o maior deles.
        int n1, n2, n3 =0;
        Console.WriteLine("Digite três números!");
        Console.WriteLine("Digite o primeiro número!");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número!");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número!");
        n3 = Convert.ToInt32(Console.ReadLine());
        if(n1 > n2 && n1 > n3){
            Console.WriteLine(string.Format("O primeiro número ({0}) é o maior", n1));
        }
        else if(n2 > n1 && n2 > n3){
            Console.WriteLine(string.Format("O segundo número ({0}) é o maior", n2));
        }
        else{
            Console.WriteLine(string.Format("O terceiro número ({0}) é o maior", n3));
        }

    }
}