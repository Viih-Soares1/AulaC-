using System;
class program{
    static void Main(){
        // Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele 
        //deseja realizar.
        int n1 = 0;
        int n2 = 0;
        int res = 0;
        int opcao = 0;
        Console.WriteLine("Digite dois numeros");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Agora escolha qual das opções você deseja efetuar a operação");
        inicio:
        Console.WriteLine("  [1] - SOMA \n [2] - SUBTRAÇÃO \n [3] - MULTIPLICAÇÃO  \n [4] - DIVISÃO" );
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao){
            case 1:
                res = n1 + n2;
                Console.WriteLine(string.Format("A soma desses dois números é {0}", res));
                break;
            case 2:
                res = n1 - n2;
                Console.WriteLine(string.Format("A subtração desses dois números é {0}", res));
                break;
            case 3:
                res = n1 * n2;
                Console.WriteLine(string.Format("A multiplicação desses dois números é {0}", res));
                break;
            case 4: 
                res = n1 / n2;
                Console.WriteLine(string.Format("A divisão desses dois números é {0}", res));
                break;
            default:
                Console.WriteLine("Opção inválida!");
                goto inicio;
        }
      
    }
}