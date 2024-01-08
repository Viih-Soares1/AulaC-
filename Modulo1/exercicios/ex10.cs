using System;
class Program{
    static void Main(){
        double  tamanho_arquivo = 0;
        double  velocidade_internet = 0;  
        double tamanhoMB = 0;  
        double tempo_download = 0;    

        Console.WriteLine("Digite o tamnho do arquivo em MB");
        tamanho_arquivo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a velocidade da sua internet");
        velocidade_internet = Convert.ToDouble(Console.ReadLine());
        tamanhoMB = tamanho_arquivo * 8;
        tempo_download = tamanhoMB / velocidade_internet ;
        Console.WriteLine(string.Format("O arquivo baixará em {0} segundos. ", tempo_download)); 

    }
}