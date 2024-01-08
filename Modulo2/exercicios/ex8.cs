using System;
class program{
    static void Main(){
        //Faça um Programa que peça um número correspondente a um determinado ano e em seguida 
        //informe se este ano é ou não bissexto.
        int ano = 0;
        Console.WriteLine("Digite um ano qualquer");
        ano = Convert.ToInt32(Console.ReadLine());

        if(ano >= 1996 && ano % 4 == 0){
            Console.WriteLine("Este ano é bissexto!!");
        }
        else{
            Console.WriteLine("Este não é bissexto!!");
        }
    }
}