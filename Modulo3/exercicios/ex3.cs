using System;
class program{
    static void Main(){
        //Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50
        Console.WriteLine("Somente os números impares do 1 até o 50!");
        for(int i = 0; i <= 50; i++){
            if(i % 2 == 1){
                Console.WriteLine(i);
            }
        }
    }
}