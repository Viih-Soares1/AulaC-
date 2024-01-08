using System;
class program{
    static void Main(){
        //Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor 
        // seja inválido e continue pedindo até que o usuário informe um valor válido.
        int nota = 0;
        inicio:
        Console.WriteLine("De 0 a 10, que nota você daria a este programa?");
        nota = Convert.ToInt32(Console.ReadLine());
        if(nota >= 0 && nota <= 10){
            Console.WriteLine("Obrigado pela nota!");
        }
        else{
            Console.WriteLine("Nota inválida!");
            goto inicio;
        }
       
    }
}