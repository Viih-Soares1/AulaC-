using System;
class Program{
    static void Main(){
        inicio:
        Console.WriteLine("Escolha uma das opções");
        Console.WriteLine("Opção [1]");
        Console.WriteLine("Opção [2]");
        Console.WriteLine("Opção [3]");
        int res = int.Parse(Console.ReadLine());

        switch(res){
            case 1:
                Console.WriteLine("Selecionado 1"); 
                break;
            case 2:
                Console.WriteLine("Selecionado 2"); 
                break;
            case 3: 
                Console.WriteLine("Selecionado 3");
                break;
            default:
                Console.WriteLine("Nenhuma seleção");
                goto inicio;

        }
    }
}