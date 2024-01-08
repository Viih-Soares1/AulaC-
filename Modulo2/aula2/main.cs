using System;
class Program{
    static void Main(){
        inicio:
        Console.WriteLine("Digite um numero de 0 a 10");
        int n1 =Convert.ToInt32(Console.ReadLine());
        if (n1 >= 0 && n1 <=10 ){
            Console.WriteLine("Número válido");
        }
        else{
            Console.WriteLine("Numero Inválido!");
            goto inicio;
        }
    }
}