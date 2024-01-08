using System;
class Program{
    static void Main(){
        //Faça um Programa que verifique se uma letra digitada é "F" ou "M". Conforme a letra escrever: 
        //F - Feminino, M - Masculino, Sexo Inválido.
        inicio:
        string sexo = "";
        Console.WriteLine("Qual o sexo  (F/M)");
        sexo = Console.ReadLine();
        switch(sexo){
            case "F":
            case "f":
                Console.WriteLine("Selecionado Feminino");
                break;
            case "m":
            case "M":
                Console.WriteLine("Selecionado Masculino");
                break;
            default:
                Console.WriteLine("Seleção Inválida");
                goto inicio;
        }
    }
}