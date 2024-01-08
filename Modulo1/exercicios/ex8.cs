using System;
class Program{
    static void Main(){
        //Faça um programa que peça o raio de um círculo e calcule a sua área. 
        double raio = 0;
        double area = 0;
        double pi = 3.14;
        Console.WriteLine("Calculando a área de um circulo");
        Console.WriteLine("Digite o raio do circulo");
        raio = Convert.ToDouble(Console.ReadLine());
        area = Math.Pow(raio,2) * pi;
        Console.WriteLine(string.Format("A área do circulo é {0}", area));

    }
}