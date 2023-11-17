using System;
class Program{
    static void Main(){
        // Faça um Programa que peça 2 números inteiros e um número real. 
        // Calcule e mostre: o produto do dobro do primeiro com metade do segundo. 
        // a soma do triplo do primeiro com o terceiro.
        // o terceiro elevado ao cubo.
        int n1 = 0;
        int n2 = 0;
        double n3 = 0;
        double res = 0;
        Console.WriteLine("Digite um número inteiro");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número inteiro");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro numero qualquer");
        n3 = Convert.ToDouble(Console.ReadLine());
        res = Math.Pow(n1, 2) * (n2 / 2);
        Console.WriteLine(string.Format("O produto do dobro do primeiro número com metade do segundo é {0}",res));
        res = (n1 * 3) + n3;
        Console.WriteLine(string.Format("A soma do triplo do primeiro numero com o terceiro é {0}", res));
        res = Math.Pow(n3, 3);
        Console.WriteLine(string.Format("O terceiro numero elevado ao cubo é {0}", res));       
    }
}