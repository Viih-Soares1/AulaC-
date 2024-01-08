using System;
class Program{
    static void Main(){
        // Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas
        // no mês. Calcule e mostre o total do seu salário no referido mês 
        double horas = 0;       
        double ganho_por_hora = 0;
        double salario = 0;

        Console.WriteLine("Digite quantas horas trabalhadas no mês");
        horas = Convert.ToDouble(Console.ReadLine());            
        Console.WriteLine("Digite quanto é seu ganho por hora");
        ganho_por_hora = Convert.ToDouble(Console.ReadLine());
        salario = horas * ganho_por_hora;
        Console.WriteLine(string.Format("Seu salário no mês será de: {0}", salario));
    }
}