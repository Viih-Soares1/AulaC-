using System;
class Program{
    static void Main(){
        double mts_quad = 0;
        double qtd_lts = 0;
        double valor_total = 0;
        double latas = 0;
        
        Console.WriteLine("Bem Vindo à loja!");
        Console.WriteLine("Digite Quantos metros quadrados quer pintar");
        mts_quad = Convert.ToDouble(Console.ReadLine());
        qtd_lts = mts_quad / 3 ;
        latas = qtd_lts / 18;
        valor_total = latas * 80;
        Console.WriteLine(string.Format("A quantidade de latas necessárias são de {0} e o valor total é {1}",latas, valor_total));
    }
}