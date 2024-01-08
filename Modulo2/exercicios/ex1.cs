using System;
class Program{
    static void Main(){
        // Faça um programa que peça dois numeros e mostre o maior deles
        int n1 = 0;
        int n2 = 0;
        Console.WriteLine("Digite dois numeros qualquer");
        n1 = Convert.ToInt32(Console.ReadLine());        
        n2 = Convert.ToInt32(Console.ReadLine());
        if(n1 > n2){
            Console.WriteLine(string.Format("O numero maior digitado é  {0}", n1));
        }
        else if(n1 == n2){
            Console.WriteLine(string.Format("{0} e {0} são iguais!", n1, n2));
        }  
        else{
            Console.WriteLine(string.Format("O numero maior digitado é  {0}", n2));
        }
    }
}