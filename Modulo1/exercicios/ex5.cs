using System;
class Program{
    static void Main(){
        // EX5 -  Faça um programa que peça a altura e o comprimento de um quadrilátero e mostre a sua área.
        double comp = 0;
        double altura = 0;
        double area = 0;
        Console.WriteLine("Calculando a altura do quadrilátero!");
        Console.WriteLine("Digite a altura");
        altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o comprimento");
        comp = Convert.ToDouble(Console.ReadLine());
        area = comp * altura;
        Console.WriteLine(string.Format("A área deste quadrilátero é {0}", area));

    }
}