using System;
class Program{
    static void Main(){
        // EX4 - Faça um Programa que converta metros para centímetros.
        double metros = 0;
        double centimetros = 0;
        Console.WriteLine("Digite a quantidade de metros!");
        metros = Convert.ToDouble(Console.ReadLine());
        centimetros = metros * 100;
        Console.WriteLine(string.Format("{0} Metro(s) convertida em centimetros é: {1}CM(s)", metros, centimetros));

    }
}