using System;
class Program{
    static void Main(){
        // EX 6 - Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu 
        // peso ideal, usando a seguinte fórmula: (72.7*altura) – 58   
        double peso = 0;
        string nome;
        double altura = 0;
        Console.WriteLine("\bIMC");
        Console.WriteLine("Digite seu nome");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua altura");
        altura = Convert.ToDouble(Console.ReadLine());
        peso = (72.7*altura) - 58;
        Console.WriteLine(string.Format("Olá {0}, seu peso ideal é {1}", nome, peso));

    }
}