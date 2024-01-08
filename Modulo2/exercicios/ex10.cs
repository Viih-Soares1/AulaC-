using System;
class program{
    static void Main(){
        //Faça um programa que pergunte que horas são e consoante, diga “Bom dia”, “Boa Tarde” ou 
        //“Boa Noite”.
        double horas = 0;
        Console.WriteLine("Que horas são?");
        horas = Convert.ToDouble(Console.ReadLine());
        if(horas >= 6 && horas <= 11){
            Console.WriteLine("Bom dia!");
        }
        else if(horas >= 12 && horas <= 18 ){
            Console.WriteLine("Boa Tarde!");
        }
        else{
            Console.WriteLine("Boa Noite");
        }
    }
}