using System;
class Program{
    static void Main(){
        // Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular 
        // a média alcançada por aluno e apresentar: A mensagem "Aprovado", se a média alcançada for 
        // maior ou igual a sete; A mensagem "Reprovado", se a média for menor do que sete; A 
        // mensagem "Aprovado com Distinção", se a média for igual a dez.  
        int n1, n2 = 0;
        double res = 0;
        Console.WriteLine("Digite as duas notas");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        res = (n1 + n2) / 2;
        if(res >= 7 && res <= 9){
            Console.WriteLine(string.Format("Aprovado! Média {0}", res));
        }  
        else if(res == 10){
            Console.WriteLine(string.Format("Aprovado com distinção! Média {0}", res));
        }  
        else{
            Console.WriteLine(string.Format("Reprovado! Média {0}", res));
        }
    }
}