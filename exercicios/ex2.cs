using System;

class Program{
    static void Main(){
        // Faça um Programa que peça dois números e imprima a soma.
        double n1 = 0;
        double n2 = 0;
        double res = 0;
        Console.WriteLine("Digite um numero qualquer");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro numero qualquer");
        n2 = Convert.ToDouble(Console.ReadLine());
        res = n1 + n2;
        Console.WriteLine(string.Format("A Soma entre {0} e {1} é igual a: {2}", n1, n2, res));

    }
}